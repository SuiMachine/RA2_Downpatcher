
namespace RA2_Downpatcher
{
	partial class RA2_Downpatcher
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.TB_OriginCNCLocation = new System.Windows.Forms.TextBox();
			this.Btn_BrowseCnCOriginLocation = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_DownpatchLocation = new System.Windows.Forms.TextBox();
			this.Btn_BrowseDownpatch_location = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.Btn_Start = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.downpatchingProgressBar = new System.Windows.Forms.ProgressBar();
			this.logView = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.Btn_Start, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 364);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.TB_OriginCNCLocation, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.Btn_BrowseCnCOriginLocation, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(698, 26);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Red Alert 2 1.0006 location (C&&C Ultimate Collection on Origin):";
			// 
			// TB_OriginCNCLocation
			// 
			this.TB_OriginCNCLocation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_OriginCNCLocation.Location = new System.Drawing.Point(316, 3);
			this.TB_OriginCNCLocation.Name = "TB_OriginCNCLocation";
			this.TB_OriginCNCLocation.Size = new System.Drawing.Size(295, 20);
			this.TB_OriginCNCLocation.TabIndex = 1;
			// 
			// Btn_BrowseCnCOriginLocation
			// 
			this.Btn_BrowseCnCOriginLocation.Location = new System.Drawing.Point(617, 3);
			this.Btn_BrowseCnCOriginLocation.Name = "Btn_BrowseCnCOriginLocation";
			this.Btn_BrowseCnCOriginLocation.Size = new System.Drawing.Size(75, 20);
			this.Btn_BrowseCnCOriginLocation.TabIndex = 2;
			this.Btn_BrowseCnCOriginLocation.Text = "Browse";
			this.Btn_BrowseCnCOriginLocation.UseVisualStyleBackColor = true;
			this.Btn_BrowseCnCOriginLocation.Click += new System.EventHandler(this.Btn_BrowseCnCOriginLocation_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 313F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.TB_DownpatchLocation, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.Btn_BrowseDownpatch_location, 2, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 37);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(698, 26);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Location where to create a downpatched copy:";
			// 
			// TB_DownpatchLocation
			// 
			this.TB_DownpatchLocation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_DownpatchLocation.Location = new System.Drawing.Point(316, 3);
			this.TB_DownpatchLocation.Name = "TB_DownpatchLocation";
			this.TB_DownpatchLocation.Size = new System.Drawing.Size(295, 20);
			this.TB_DownpatchLocation.TabIndex = 1;
			// 
			// Btn_BrowseDownpatch_location
			// 
			this.Btn_BrowseDownpatch_location.Location = new System.Drawing.Point(617, 3);
			this.Btn_BrowseDownpatch_location.Name = "Btn_BrowseDownpatch_location";
			this.Btn_BrowseDownpatch_location.Size = new System.Drawing.Size(75, 20);
			this.Btn_BrowseDownpatch_location.TabIndex = 2;
			this.Btn_BrowseDownpatch_location.Text = "Browse";
			this.Btn_BrowseDownpatch_location.UseVisualStyleBackColor = true;
			this.Btn_BrowseDownpatch_location.Click += new System.EventHandler(this.Btn_BrowseDownpatch_location_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.logView, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 103);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(698, 257);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// Btn_Start
			// 
			this.Btn_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Btn_Start.Location = new System.Drawing.Point(295, 71);
			this.Btn_Start.Name = "Btn_Start";
			this.Btn_Start.Size = new System.Drawing.Size(116, 23);
			this.Btn_Start.TabIndex = 3;
			this.Btn_Start.Text = "Start downpatching";
			this.Btn_Start.UseVisualStyleBackColor = true;
			this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.downpatchingProgressBar, 1, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(692, 26);
			this.tableLayoutPanel5.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Progress:";
			// 
			// downpatchingProgressBar
			// 
			this.downpatchingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.downpatchingProgressBar.Location = new System.Drawing.Point(72, 3);
			this.downpatchingProgressBar.Name = "downpatchingProgressBar";
			this.downpatchingProgressBar.Size = new System.Drawing.Size(617, 20);
			this.downpatchingProgressBar.TabIndex = 1;
			// 
			// logView
			// 
			this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logView.Location = new System.Drawing.Point(3, 35);
			this.logView.Name = "logView";
			this.logView.Size = new System.Drawing.Size(692, 219);
			this.logView.TabIndex = 1;
			this.logView.Text = "";
			this.logView.TextChanged += new System.EventHandler(this.logView_TextChanged);
			// 
			// RA2_Downpatcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 364);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "RA2_Downpatcher";
			this.Text = "Red Alert 2 Downpatcher GUI";
			this.Load += new System.EventHandler(this.RA2_Downpatcher_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_DownpatchLocation;
		private System.Windows.Forms.Button Btn_BrowseDownpatch_location;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TB_OriginCNCLocation;
		private System.Windows.Forms.Button Btn_BrowseCnCOriginLocation;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button Btn_Start;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ProgressBar downpatchingProgressBar;
		private System.Windows.Forms.RichTextBox logView;
	}
}

