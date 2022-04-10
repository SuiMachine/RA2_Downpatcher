using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RA2_Downpatcher
{
	public partial class RA2_Downpatcher : Form
	{
		public Verification verification;
		private DownpatcherThread downpatcher;
		private delegate void UpdateProgressDelegate(int value);
		private delegate void AppendLogDelegate(string text);
		private delegate void RestartDelegate(bool success);

		public string OriginPath { get; private set; }
		public string DownpatchPath { get; private set; }


		public RA2_Downpatcher()
		{
			InitializeComponent();
		}

		private void RA2_Downpatcher_Load(object sender, EventArgs e)
		{
			verification = new Verification(this);
			var installedOriginPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\EA Games\\Command and Conquer Red Alert II");
			if(installedOriginPath != null && installedOriginPath.GetValueNames().Contains("Install Dir"))
			{
				TB_OriginCNCLocation.Text = installedOriginPath.GetValue("Install Dir", "").ToString();
				TB_DownpatchLocation.Text = Path.Combine(Path.GetPathRoot(TB_OriginCNCLocation.Text), "Westwood", "Red Alert 2 - Unpatched");
			}
		}

		private void Btn_BrowseCnCOriginLocation_Click(object sender, EventArgs e)
		{
			var fd = new CommonOpenFileDialog()
			{
				IsFolderPicker = true,
				EnsureFileExists = true,
				EnsurePathExists = true,
				Title = "Select a localisation, where Red Alert 2 v 1.0006 (Ultimate Collection) is installed"
			};

			var result = fd.ShowDialog();
			if(result == CommonFileDialogResult.Ok)
			{
				if (Directory.Exists(fd.FileName))
				{
					if(verification.VerifyOriginFilesExist(fd.FileName, out var missingFiles))
					{
						TB_OriginCNCLocation.Text = fd.FileName;
					}
					else
					{
						logView.Clear();
						logView.AppendText("Missing files:\n");
						foreach(var missingFile in missingFiles)
						{
							logView.AppendText(missingFile + "\n");
						}
						MessageBox.Show("Failed to verify Origin files. Check log.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					MessageBox.Show("Folder doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			fd.Dispose();
		}

		private void Btn_BrowseDownpatch_location_Click(object sender, EventArgs e)
		{
			var fd = new CommonOpenFileDialog()
			{
				IsFolderPicker = true,
				EnsureFileExists = true,
				Title = "Select a folder where a downpatch directory is going to be created"
			};

			var result = fd.ShowDialog();
			if(result == CommonFileDialogResult.Ok)
			{
				if(Directory.Exists(fd.FileName))
				{
					var files = Directory.GetFiles(fd.FileName, "*.*", SearchOption.AllDirectories);
					if (files.Length == 0)
					{
						TB_DownpatchLocation.Text = fd.FileName;
					}
					else
						MessageBox.Show("A folder for a downpatched version should be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Directory.CreateDirectory(fd.FileName);
					TB_DownpatchLocation.Text = fd.FileName;
				}
			}
			fd.Dispose();
		}

		private void Btn_Start_Click(object sender, EventArgs e)
		{
			this.OriginPath = TB_OriginCNCLocation.Text;
			this.DownpatchPath = TB_DownpatchLocation.Text;

/*			verification.GenerateXdeltaFiles(OriginPath, DownpatchPath);
			return;*/
			logView.Clear();
			logView.AppendText("Starting downpatching process...\n");

			if (!Directory.Exists(DownpatchPath))
				Directory.CreateDirectory(DownpatchPath);
			else
			{
				var files = Directory.GetFiles(DownpatchPath, "*.*", SearchOption.AllDirectories);
				if(files.Length > 0)
				{
					MessageBox.Show("Destination folder is not empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}

			if (downpatcher != null)
				throw new Exception("This should be null!");
			Btn_Start.Enabled = false;
			downpatcher = new DownpatcherThread(this, verification);
			downpatcher.Start();
		}

		internal void AppendLog(string text)
		{
			if (logView.InvokeRequired)
			{
				logView.Invoke(new AppendLogDelegate(AppendLog), new object[] { text });
			}
			else
			{
				logView.AppendText(text + "\n");
				logView.Select(logView.Text.Length - text.Length - 1, text.Length);
			}
		}

		internal void UpdateProgress(int precent)
		{
			if (downpatchingProgressBar.InvokeRequired)
			{
				downpatchingProgressBar.Invoke(new UpdateProgressDelegate(UpdateProgress), new object[] { precent });
			}
			else
			{
				downpatchingProgressBar.Value = precent;
			}
		}

		internal void Restart(bool success)
		{
			if(this.InvokeRequired)
			{
				this.Invoke(new RestartDelegate(Restart), new object[] { success });
			}
			else
			{
				downpatchingProgressBar.Value = 0;
				if (!success)
				{
					Btn_Start.Enabled = true;
				}

				if (this.downpatcher != null)
					this.downpatcher = null;
			}
		}

		private void logView_TextChanged(object sender, EventArgs e)
		{
			logView.SelectionStart = logView.Text.Length;
			logView.ScrollToCaret();
		}
	}
}
