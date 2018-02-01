namespace ProtectedDataTest
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
            this.UnProtectButton = new System.Windows.Forms.Button();
            this.ProtectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UnprotectedTextBox = new System.Windows.Forms.TextBox();
            this.ProtectedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProtectedASCIITextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProtectedDataAsUnicodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UnProtectButton
            // 
            this.UnProtectButton.Location = new System.Drawing.Point(300, 103);
            this.UnProtectButton.Name = "UnProtectButton";
            this.UnProtectButton.Size = new System.Drawing.Size(113, 23);
            this.UnProtectButton.TabIndex = 0;
            this.UnProtectButton.Text = "Unprotect / Decrypt";
            this.UnProtectButton.UseVisualStyleBackColor = true;
            this.UnProtectButton.Click += new System.EventHandler(this.UnProtectButton_Click);
            // 
            // ProtectButton
            // 
            this.ProtectButton.Location = new System.Drawing.Point(16, 103);
            this.ProtectButton.Name = "ProtectButton";
            this.ProtectButton.Size = new System.Drawing.Size(91, 23);
            this.ProtectButton.TabIndex = 1;
            this.ProtectButton.Text = "Protect/Encrypt";
            this.ProtectButton.UseVisualStyleBackColor = true;
            this.ProtectButton.Click += new System.EventHandler(this.ProtectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unprotected";
            // 
            // UnprotectedTextBox
            // 
            this.UnprotectedTextBox.Location = new System.Drawing.Point(16, 30);
            this.UnprotectedTextBox.Multiline = true;
            this.UnprotectedTextBox.Name = "UnprotectedTextBox";
            this.UnprotectedTextBox.Size = new System.Drawing.Size(397, 45);
            this.UnprotectedTextBox.TabIndex = 3;
            // 
            // ProtectedTextBox
            // 
            this.ProtectedTextBox.Location = new System.Drawing.Point(16, 217);
            this.ProtectedTextBox.Multiline = true;
            this.ProtectedTextBox.Name = "ProtectedTextBox";
            this.ProtectedTextBox.Size = new System.Drawing.Size(397, 45);
            this.ProtectedTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Protected data at -";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathLabel.Location = new System.Drawing.Point(105, 84);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(46, 13);
            this.FilePathLabel.TabIndex = 6;
            this.FilePathLabel.Text = "<path>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Protected data as ASCII";
            // 
            // ProtectedASCIITextBox
            // 
            this.ProtectedASCIITextBox.Location = new System.Drawing.Point(16, 145);
            this.ProtectedASCIITextBox.Multiline = true;
            this.ProtectedASCIITextBox.Name = "ProtectedASCIITextBox";
            this.ProtectedASCIITextBox.Size = new System.Drawing.Size(397, 45);
            this.ProtectedASCIITextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Protected data as binary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Protected data as unicode";
            // 
            // ProtectedDataAsUnicodeTextBox
            // 
            this.ProtectedDataAsUnicodeTextBox.Location = new System.Drawing.Point(16, 288);
            this.ProtectedDataAsUnicodeTextBox.Multiline = true;
            this.ProtectedDataAsUnicodeTextBox.Name = "ProtectedDataAsUnicodeTextBox";
            this.ProtectedDataAsUnicodeTextBox.Size = new System.Drawing.Size(397, 45);
            this.ProtectedDataAsUnicodeTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 335);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProtectedDataAsUnicodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProtectedASCIITextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.ProtectedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnprotectedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProtectButton);
            this.Controls.Add(this.UnProtectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnProtectButton;
        private System.Windows.Forms.Button ProtectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnprotectedTextBox;
        private System.Windows.Forms.TextBox ProtectedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProtectedASCIITextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProtectedDataAsUnicodeTextBox;
    }
}

