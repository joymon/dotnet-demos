namespace HttpCapture
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
            this.MakeHttpCallbutton = new System.Windows.Forms.Button();
            this.MakeHttpCallUsingHttpClientbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogstextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeHttpCallbutton
            // 
            this.MakeHttpCallbutton.Location = new System.Drawing.Point(360, 25);
            this.MakeHttpCallbutton.Name = "MakeHttpCallbutton";
            this.MakeHttpCallbutton.Size = new System.Drawing.Size(233, 33);
            this.MakeHttpCallbutton.TabIndex = 0;
            this.MakeHttpCallbutton.Text = "Make Http Call using WebClient";
            this.MakeHttpCallbutton.UseVisualStyleBackColor = true;
            this.MakeHttpCallbutton.Click += new System.EventHandler(this.MakeHttpCallbutton_Click);
            // 
            // MakeHttpCallUsingHttpClientbutton
            // 
            this.MakeHttpCallUsingHttpClientbutton.Location = new System.Drawing.Point(360, 64);
            this.MakeHttpCallUsingHttpClientbutton.Name = "MakeHttpCallUsingHttpClientbutton";
            this.MakeHttpCallUsingHttpClientbutton.Size = new System.Drawing.Size(233, 33);
            this.MakeHttpCallUsingHttpClientbutton.TabIndex = 1;
            this.MakeHttpCallUsingHttpClientbutton.Text = "Make Http Call using HttpClient";
            this.MakeHttpCallUsingHttpClientbutton.UseVisualStyleBackColor = true;
            this.MakeHttpCallUsingHttpClientbutton.Click += new System.EventHandler(this.MakeHttpCallUsingHttpClientbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogstextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // LogstextBox
            // 
            this.LogstextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogstextBox.Location = new System.Drawing.Point(3, 18);
            this.LogstextBox.Multiline = true;
            this.LogstextBox.Name = "LogstextBox";
            this.LogstextBox.Size = new System.Drawing.Size(604, 171);
            this.LogstextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 295);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MakeHttpCallUsingHttpClientbutton);
            this.Controls.Add(this.MakeHttpCallbutton);
            this.Name = "Form1";
            this.Text = "Diagnostic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MakeHttpCallbutton;
        private System.Windows.Forms.Button MakeHttpCallUsingHttpClientbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LogstextBox;
    }
}

