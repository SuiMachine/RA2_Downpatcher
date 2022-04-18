using Microsoft.Win32;
using RA2_Downpatcher.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace RA2_Downpatcher
{
	public class DownpatcherThread
	{
		Verification verificationInstance;
		RA2_Downpatcher downpatcherForm;
		Thread patchingTask;
		bool customCnCDraw = false;

		public DownpatcherThread(RA2_Downpatcher downpatcherForm, Verification verificationInstance, bool customCnCDraw)
		{
			this.downpatcherForm = downpatcherForm;
			this.verificationInstance = verificationInstance;
			this.customCnCDraw = customCnCDraw;
		}

		internal void Start()
		{
			patchingTask = new Thread(Patching);
			patchingTask.Start();
		}

		private void Patching()
		{
			if (!verificationInstance.VerifyOriginFiles(downpatcherForm.OriginPath))
			{
				downpatcherForm.Restart(false);
				return;
			}

			downpatcherForm.AppendLog("Copying files to a new directory");
			var files = verificationInstance.GetFileList();
			var sourceFolder = downpatcherForm.OriginPath;
			var destinationFolder = downpatcherForm.DownpatchPath;

			var totalFilesF = files.Length;
			int lastFullPercent = 0;
			int iterator = 0;
			foreach (var file in files)
			{
				downpatcherForm.AppendLog($"Copying \"{file}\".");
				var sourcePath = Path.Combine(sourceFolder, file);
				var destinationPath = Path.Combine(destinationFolder, file);
				var destDir = Directory.GetParent(destinationPath).FullName;
				if (!Directory.Exists(destDir))
					Directory.CreateDirectory(destDir);
				File.Copy(sourcePath, destinationPath, true);

				iterator++;
				var percent = (int)Lerp(10, 50, iterator / totalFilesF);
				if (percent != lastFullPercent)
				{
					downpatcherForm.UpdateProgress(percent);
					lastFullPercent = percent;
				}
			}
			downpatcherForm.UpdateProgress(50);
			downpatcherForm.AppendLog("Finished copying files!");
			ExtractXDeltas(destinationFolder);
			var xDeltaPath = Path.Combine(destinationFolder, "xdelta3.exe");
			File.WriteAllBytes(xDeltaPath, Resources.xdelta3);
			downpatcherForm.AppendLog("Downpatching...");
			foreach (var file in files)
			{
				var xDeltaFile = Path.Combine(destinationFolder, file.Remove(file.LastIndexOf(".")) + ".xdelta");
				if (File.Exists(xDeltaFile))
				{
					var sourceFile = Path.Combine(destinationFolder, file);
					var patchedFile = Path.Combine(destinationFolder, file + ".tmp");
					downpatcherForm.AppendLog($"Downpatching \"{file}\"");

					RunProcessAndRedirectOutput(xDeltaPath, $"-d -s \"{sourceFile}\" \"{xDeltaFile}\" \"{patchedFile}\"");

					if (File.Exists(patchedFile))
					{
						File.Delete(sourceFile);
						File.Move(patchedFile, sourceFile);
						File.Delete(xDeltaFile);
					}
				}
				else
				{
					downpatcherForm.AppendLog($"No xDelta found for \"{file}\" - skipping...");
				}
			}
			File.Delete(xDeltaPath);
			downpatcherForm.UpdateProgress(95);

			ApplyFinalPatches(destinationFolder);
			var _7zipPath = Path.Combine(destinationFolder, "7z.exe");

			downpatcherForm.AppendLog($"Installing compatibility fixes...");
			if (File.Exists(_7zipPath))
				File.Delete(_7zipPath);
			downpatcherForm.AppendLog($"We are done!");
			downpatcherForm.Restart(true);
		}

		private void ApplyFinalPatches(string folder)
		{
			var _7zipPath = Path.Combine(folder, "7z.exe");
			if (File.Exists(Path.Combine(folder, "ra2.ini")))
				File.Delete(Path.Combine(folder, "ra2.ini"));

			var fixesDest = Path.Combine(folder, "fixes.7z");
			File.WriteAllBytes(fixesDest, Resources.cncdraw_content);

			RunProcessAndRedirectOutput(_7zipPath, $"x \"{fixesDest}\"");
			if (File.Exists(fixesDest))
				File.Delete(fixesDest);

			var ddrawDestination = Path.Combine(folder, "ddraw.dll");
			if(customCnCDraw)
				File.WriteAllBytes(ddrawDestination, Resources.ddraw_broken);
			else
				File.WriteAllBytes(ddrawDestination, Resources.ddraw_original);

			downpatcherForm.AppendLog($"Setting registry path to a unpatched version...");
			var ra2Path = Path.Combine(folder, "Ra2.exe");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Westwood\\Red Alert 2", "InstallPath", ra2Path, RegistryValueKind.ExpandString);

			//Create shortcut
			object shDesktop = (object)"Desktop";
			IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
			string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Red Alert 2 - Unpatched.lnk";
			IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutAddress);
			shortcut.Description = "Unpatched Red Alert 2";
			shortcut.IconLocation = Path.Combine(folder, "RA2.ico");
			shortcut.TargetPath = ra2Path;
			shortcut.WorkingDirectory = folder;
			shortcut.Save();
		}

		private void ExtractXDeltas(string destinationFolder)
		{
			downpatcherForm.AppendLog("Extracting Xdeltas");
			var _7zipPath = Path.Combine(destinationFolder, "7z.exe");
			var xdeltas = Path.Combine(destinationFolder, "xdelta.7z");
			File.WriteAllBytes(_7zipPath, Resources._7za);
			File.WriteAllBytes(xdeltas, Resources.Xdelta);
			RunProcessAndRedirectOutput(_7zipPath, $"x xdelta.7z");
			File.Delete(xdeltas);
		}

		private void RunProcessAndRedirectOutput(string filePath, string arguments, string workDirectory = null)
		{
			var process = new Process();
			process.StartInfo.FileName = filePath;
			process.StartInfo.WorkingDirectory = workDirectory != null ? workDirectory : Directory.GetParent(filePath).FullName;
			process.StartInfo.Arguments = arguments;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			DataReceivedEventHandler delOutPutReceived = (sender, e) => { downpatcherForm.AppendLog(e.Data); };
			DataReceivedEventHandler delErrorDataReceived = (sender, e) => { downpatcherForm.AppendLog(e.Data); };
			process.OutputDataReceived += delOutPutReceived;
			process.ErrorDataReceived += delErrorDataReceived;
			process.WaitForExit();
			process.OutputDataReceived -= delOutPutReceived;
			process.ErrorDataReceived -= delErrorDataReceived;
		}



		private float Lerp(float a, float b, float t)
		{
			var result = a * (1f - t) + b * t;
			if (result > b)
				result = b;
			else if (result < a)
				result = a;

			return result;
		}
	}
}
