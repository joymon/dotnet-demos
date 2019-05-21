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
            this.NInParallelButton = new System.Windows.Forms.Button();
            this.SourceFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.SATextBox = new System.Windows.Forms.TextBox();
            this.LogFileSystemWatcher = new System.IO.FileSystemWatcher();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LogFilePathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.BrowseFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogFileSystemWatcher)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "DoAction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AzCopyPathTextBox
            // 
            this.AzCopyPathTextBox.Location = new System.Drawing.Point(96, 13);
            this.AzCopyPathTextBox.Name = "AzCopyPathTextBox";
            this.AzCopyPathTextBox.Size = new System.Drawing.Size(475, 20);
            this.AzCopyPathTextBox.TabIndex = 1;
            this.AzCopyPathTextBox.Text = "sample input 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input 1";
            // 
            // NInParallelButton
            // 
            this.NInParallelButton.Location = new System.Drawing.Point(474, 92);
            this.NInParallelButton.Name = "NInParallelButton";
            this.NInParallelButton.Size = new System.Drawing.Size(97, 23);
            this.NInParallelButton.TabIndex = 4;
            this.NInParallelButton.Text = "Do in parallel";
            this.NInParallelButton.UseVisualStyleBackColor = true;
            this.NInParallelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Input 2";
            // 
            // SATextBox
            // 
            this.SATextBox.Enabled = false;
            this.SATextBox.Location = new System.Drawing.Point(96, 39);
            this.SATextBox.Name = "SATextBox";
            this.SATextBox.Size = new System.Drawing.Size(475, 20);
            this.SATextBox.TabIndex = 12;
            this.SATextBox.Text = "Sample input 2";
            // 
            // LogFileSystemWatcher
            // 
            this.LogFileSystemWatcher.EnableRaisingEvents = true;
            this.LogFileSystemWatcher.Filter = "*.log";
            this.LogFileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.LogFileSystemWatcher.SynchronizingObject = this;
            this.LogFileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.LogFileSystemWatcher_Changed);
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
            // LogsTextBox
            // 
            this.LogsTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogsTextBox.Location = new System.Drawing.Point(3, 45);
            this.LogsTextBox.Multiline = true;
            this.LogsTextBox.Name = "LogsTextBox";
            this.LogsTextBox.Size = new System.Drawing.Size(571, 192);
            this.LogsTextBox.TabIndex = 15;
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
            // LogFilePathTextBox
            // 
            this.LogFilePathTextBox.Location = new System.Drawing.Point(66, 19);
            this.LogFilePathTextBox.Name = "LogFilePathTextBox";
            this.LogFilePathTextBox.Size = new System.Drawing.Size(508, 20);
            this.LogFilePathTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.BrowseFolderButton);
            this.groupBox1.Controls.Add(this.SourceFolderTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 473);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section 2";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 594);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SATextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NInParallelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AzCopyPathTextBox);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogFileSystemWatcher)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AzCopyPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NInParallelButton;
        private System.Windows.Forms.FolderBrowserDialog SourceFolderBrowserDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SATextBox;
        private System.IO.FileSystemWatcher LogFileSystemWatcher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox LogFilePathTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LogsTextBox;
        private System.Windows.Forms.Button BrowseFolderButton;
        private System.Windows.Forms.TextBox SourceFolderTextBox;
        private System.Windows.Forms.Label label4;
    }
}

