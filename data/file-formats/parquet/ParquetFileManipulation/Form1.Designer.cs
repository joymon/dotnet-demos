namespace ParquetFileManipulation
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
            this.ParquetDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileNametextBox = new System.Windows.Forms.TextBox();
            this.LoadRefDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ParquetDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParquetDataGrid
            // 
            this.ParquetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParquetDataGrid.Location = new System.Drawing.Point(12, 53);
            this.ParquetDataGrid.Name = "ParquetDataGrid";
            this.ParquetDataGrid.Size = new System.Drawing.Size(463, 196);
            this.ParquetDataGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadRefDataButton);
            this.groupBox1.Controls.Add(this.FileNametextBox);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(251, 14);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FileNametextBox
            // 
            this.FileNametextBox.Location = new System.Drawing.Point(6, 16);
            this.FileNametextBox.Name = "FileNametextBox";
            this.FileNametextBox.Size = new System.Drawing.Size(195, 20);
            this.FileNametextBox.TabIndex = 1;
            this.FileNametextBox.Text = "C:\\Temp\\Data\\customer.impala.parquet";
            // 
            // LoadRefDataButton
            // 
            this.LoadRefDataButton.Location = new System.Drawing.Point(332, 13);
            this.LoadRefDataButton.Name = "LoadRefDataButton";
            this.LoadRefDataButton.Size = new System.Drawing.Size(100, 23);
            this.LoadRefDataButton.TabIndex = 2;
            this.LoadRefDataButton.Text = "Load Ref Data";
            this.LoadRefDataButton.UseVisualStyleBackColor = true;
            this.LoadRefDataButton.Click += new System.EventHandler(this.LoadRefDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ParquetDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ParquetDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ParquetDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox FileNametextBox;
        private System.Windows.Forms.Button LoadRefDataButton;
    }
}

