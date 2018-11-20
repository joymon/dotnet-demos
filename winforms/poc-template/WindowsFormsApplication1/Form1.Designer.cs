namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.AzCopyPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.NInParallelButton = new System.Windows.Forms.Button();
            this.NumberOfDownloadsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateAzCopyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AnalysisIdTextBox = new System.Windows.Forms.TextBox();
            this.AzCopyCommandTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BlockSizelabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ParallelOperationsnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BlockSizetrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.UploadFilesUsingAzCopySDKbutton = new System.Windows.Forms.Button();
            this.UploadUsingAzCopySDKbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LogsTextBox = new System.Windows.Forms.TextBox();
            this.UploadUsingAzCopyButton = new System.Windows.Forms.Button();
            this.BrowseFolderButton = new System.Windows.Forms.Button();
            this.SourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.SATextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BlobContainerTextBox = new System.Windows.Forms.TextBox();
            this.LogFileSystemWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDownloadsNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParallelOperationsnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockSizetrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogFileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download single";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AzCopyPathTextBox
            // 
            this.AzCopyPathTextBox.Location = new System.Drawing.Point(96, 13);
            this.AzCopyPathTextBox.Name = "AzCopyPathTextBox";
            this.AzCopyPathTextBox.Size = new System.Drawing.Size(475, 20);
            this.AzCopyPathTextBox.TabIndex = 1;
            this.AzCopyPathTextBox.Text = "C:\\Program Files (x86)\\Microsoft SDKs\\Azure\\AzCopy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AzCopy path";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Download 2 in parallel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NInParallelButton
            // 
            this.NInParallelButton.Location = new System.Drawing.Point(499, 92);
            this.NInParallelButton.Name = "NInParallelButton";
            this.NInParallelButton.Size = new System.Drawing.Size(72, 23);
            this.NInParallelButton.TabIndex = 4;
            this.NInParallelButton.Text = "in parallel";
            this.NInParallelButton.UseVisualStyleBackColor = true;
            this.NInParallelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // NumberOfDownloadsNumericUpDown
            // 
            this.NumberOfDownloadsNumericUpDown.Location = new System.Drawing.Point(443, 92);
            this.NumberOfDownloadsNumericUpDown.Name = "NumberOfDownloadsNumericUpDown";
            this.NumberOfDownloadsNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.NumberOfDownloadsNumericUpDown.TabIndex = 5;
            this.NumberOfDownloadsNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Download";
            // 
            // GenerateAzCopyButton
            // 
            this.GenerateAzCopyButton.Location = new System.Drawing.Point(248, 52);
            this.GenerateAzCopyButton.Name = "GenerateAzCopyButton";
            this.GenerateAzCopyButton.Size = new System.Drawing.Size(148, 23);
            this.GenerateAzCopyButton.TabIndex = 7;
            this.GenerateAzCopyButton.Text = "Generate AzCopy Command";
            this.GenerateAzCopyButton.UseVisualStyleBackColor = true;
            this.GenerateAzCopyButton.Click += new System.EventHandler(this.GenerateAzCopyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination container";
            // 
            // AnalysisIdTextBox
            // 
            this.AnalysisIdTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.AnalysisIdTextBox.Location = new System.Drawing.Point(429, 16);
            this.AnalysisIdTextBox.Name = "AnalysisIdTextBox";
            this.AnalysisIdTextBox.Size = new System.Drawing.Size(142, 20);
            this.AnalysisIdTextBox.TabIndex = 8;
            this.AnalysisIdTextBox.Text = "testanalysis";
            // 
            // AzCopyCommandTextBox
            // 
            this.AzCopyCommandTextBox.Location = new System.Drawing.Point(3, 81);
            this.AzCopyCommandTextBox.Multiline = true;
            this.AzCopyCommandTextBox.Name = "AzCopyCommandTextBox";
            this.AzCopyCommandTextBox.Size = new System.Drawing.Size(577, 62);
            this.AzCopyCommandTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BlockSizelabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ParallelOperationsnumericUpDown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BlockSizetrackBar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.UploadFilesUsingAzCopySDKbutton);
            this.groupBox1.Controls.Add(this.UploadUsingAzCopySDKbutton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.UploadUsingAzCopyButton);
            this.groupBox1.Controls.Add(this.BrowseFolderButton);
            this.groupBox1.Controls.Add(this.SourceFolderTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GenerateAzCopyButton);
            this.groupBox1.Controls.Add(this.AzCopyCommandTextBox);
            this.groupBox1.Controls.Add(this.AnalysisIdTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 473);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload";
            // 
            // BlockSizelabel
            // 
            this.BlockSizelabel.AutoSize = true;
            this.BlockSizelabel.Location = new System.Drawing.Point(559, 153);
            this.BlockSizelabel.Name = "BlockSizelabel";
            this.BlockSizelabel.Size = new System.Drawing.Size(13, 13);
            this.BlockSizelabel.TabIndex = 24;
            this.BlockSizelabel.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Parallel Operations";
            // 
            // ParallelOperationsnumericUpDown
            // 
            this.ParallelOperationsnumericUpDown.Location = new System.Drawing.Point(116, 201);
            this.ParallelOperationsnumericUpDown.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.ParallelOperationsnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ParallelOperationsnumericUpDown.Name = "ParallelOperationsnumericUpDown";
            this.ParallelOperationsnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ParallelOperationsnumericUpDown.TabIndex = 21;
            this.ParallelOperationsnumericUpDown.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Block size (MB)";
            // 
            // BlockSizetrackBar
            // 
            this.BlockSizetrackBar.LargeChange = 8;
            this.BlockSizetrackBar.Location = new System.Drawing.Point(75, 150);
            this.BlockSizetrackBar.Maximum = 100;
            this.BlockSizetrackBar.Minimum = 4;
            this.BlockSizetrackBar.Name = "BlockSizetrackBar";
            this.BlockSizetrackBar.Size = new System.Drawing.Size(489, 45);
            this.BlockSizetrackBar.SmallChange = 4;
            this.BlockSizetrackBar.TabIndex = 20;
            this.BlockSizetrackBar.TickFrequency = 4;
            this.BlockSizetrackBar.Value = 4;
            this.BlockSizetrackBar.Scroll += new System.EventHandler(this.BlockSizetrackBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "AzCopy.exe Command";
            // 
            // UploadFilesUsingAzCopySDKbutton
            // 
            this.UploadFilesUsingAzCopySDKbutton.Location = new System.Drawing.Point(402, 201);
            this.UploadFilesUsingAzCopySDKbutton.Name = "UploadFilesUsingAzCopySDKbutton";
            this.UploadFilesUsingAzCopySDKbutton.Size = new System.Drawing.Size(169, 23);
            this.UploadFilesUsingAzCopySDKbutton.TabIndex = 18;
            this.UploadFilesUsingAzCopySDKbutton.Text = "Upload files using AzCopy SDK";
            this.UploadFilesUsingAzCopySDKbutton.UseVisualStyleBackColor = true;
            this.UploadFilesUsingAzCopySDKbutton.Click += new System.EventHandler(this.UploadFilesUsingAzCopySDKbutton_Click);
            // 
            // UploadUsingAzCopySDKbutton
            // 
            this.UploadUsingAzCopySDKbutton.Location = new System.Drawing.Point(248, 201);
            this.UploadUsingAzCopySDKbutton.Name = "UploadUsingAzCopySDKbutton";
            this.UploadUsingAzCopySDKbutton.Size = new System.Drawing.Size(148, 23);
            this.UploadUsingAzCopySDKbutton.TabIndex = 17;
            this.UploadUsingAzCopySDKbutton.Text = "Upload folder using AzCopy SDK";
            this.UploadUsingAzCopySDKbutton.UseVisualStyleBackColor = true;
            this.UploadUsingAzCopySDKbutton.Click += new System.EventHandler(this.UploadUsingAzCopySDKbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogFilePathTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LogsTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 240);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logs";
            // 
            // LogFilePathTextBox
            // 
            this.LogFilePathTextBox.Location = new System.Drawing.Point(66, 19);
            this.LogFilePathTextBox.Name = "LogFilePathTextBox";
            this.LogFilePathTextBox.Size = new System.Drawing.Size(508, 20);
            this.LogFilePathTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Log path";
            // 
            // LogsTextBox
            // 
            this.LogsTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogsTextBox.Location = new System.Drawing.Point(3, 45);
            this.LogsTextBox.Multiline = true;
            this.LogsTextBox.Name = "LogsTextBox";
            this.LogsTextBox.Size = new System.Drawing.Size(571, 192);
            this.LogsTextBox.TabIndex = 15;
            // 
            // UploadUsingAzCopyButton
            // 
            this.UploadUsingAzCopyButton.Location = new System.Drawing.Point(402, 52);
            this.UploadUsingAzCopyButton.Name = "UploadUsingAzCopyButton";
            this.UploadUsingAzCopyButton.Size = new System.Drawing.Size(169, 23);
            this.UploadUsingAzCopyButton.TabIndex = 14;
            this.UploadUsingAzCopyButton.Text = "Upload using AzCopy";
            this.UploadUsingAzCopyButton.UseVisualStyleBackColor = true;
            this.UploadUsingAzCopyButton.Click += new System.EventHandler(this.UploadUsingAzCopyButton_Click);
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.Location = new System.Drawing.Point(300, 13);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.Size = new System.Drawing.Size(21, 23);
            this.BrowseFolderButton.TabIndex = 13;
            this.BrowseFolderButton.Text = "...";
            this.BrowseFolderButton.UseVisualStyleBackColor = true;
            this.BrowseFolderButton.Click += new System.EventHandler(this.BrowseFolderButton_Click);
            // 
            // SourceFolderTextBox
            // 
            this.SourceFolderTextBox.Location = new System.Drawing.Point(79, 13);
            this.SourceFolderTextBox.Name = "SourceFolderTextBox";
            this.SourceFolderTextBox.ReadOnly = true;
            this.SourceFolderTextBox.Size = new System.Drawing.Size(215, 20);
            this.SourceFolderTextBox.TabIndex = 11;
            this.SourceFolderTextBox.Text = "c:\\temp\\source\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Source Folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Storage Account";
            // 
            // SATextBox
            // 
            this.SATextBox.Enabled = false;
            this.SATextBox.Location = new System.Drawing.Point(96, 39);
            this.SATextBox.Name = "SATextBox";
            this.SATextBox.Size = new System.Drawing.Size(475, 20);
            this.SATextBox.TabIndex = 12;
            this.SATextBox.Text = "parquetstore";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Blob Container";
            // 
            // BlobContainerTextBox
            // 
            this.BlobContainerTextBox.Location = new System.Drawing.Point(96, 65);
            this.BlobContainerTextBox.Name = "BlobContainerTextBox";
            this.BlobContainerTextBox.Size = new System.Drawing.Size(475, 20);
            this.BlobContainerTextBox.TabIndex = 14;
            this.BlobContainerTextBox.Text = "joysbackup";
            // 
            // LogFileSystemWatcher
            // 
            this.LogFileSystemWatcher.EnableRaisingEvents = true;
            this.LogFileSystemWatcher.Filter = "*.log";
            this.LogFileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.LogFileSystemWatcher.SynchronizingObject = this;
            this.LogFileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.LogFileSystemWatcher_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 594);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BlobContainerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SATextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfDownloadsNumericUpDown);
            this.Controls.Add(this.NInParallelButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AzCopyPathTextBox);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDownloadsNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParallelOperationsnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockSizetrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogFileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AzCopyPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button NInParallelButton;
        private System.Windows.Forms.NumericUpDown NumberOfDownloadsNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateAzCopyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AnalysisIdTextBox;
        private System.Windows.Forms.TextBox AzCopyCommandTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BrowseFolderButton;
        private System.Windows.Forms.TextBox SourceFolderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog SourceFolderBrowserDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SATextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BlobContainerTextBox;
        private System.Windows.Forms.Button UploadUsingAzCopyButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LogsTextBox;
        private System.IO.FileSystemWatcher LogFileSystemWatcher;
        private System.Windows.Forms.TextBox LogFilePathTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UploadUsingAzCopySDKbutton;
        private System.Windows.Forms.Button UploadFilesUsingAzCopySDKbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown ParallelOperationsnumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar BlockSizetrackBar;
        private System.Windows.Forms.Label BlockSizelabel;
    }
}

