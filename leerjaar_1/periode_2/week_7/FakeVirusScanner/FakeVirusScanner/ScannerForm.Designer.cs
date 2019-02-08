namespace FakeVirusScanner
{
    partial class ScannerForm
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
            this.scanButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.scannedFolderListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(478, 12);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(378, 20);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan this folder";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(12, 12);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(460, 20);
            this.folderTextBox.TabIndex = 1;
            this.folderTextBox.Text = "C:\\Users\\Public";
            // 
            // scannedFolderListBox
            // 
            this.scannedFolderListBox.FormattingEnabled = true;
            this.scannedFolderListBox.Location = new System.Drawing.Point(12, 38);
            this.scannedFolderListBox.Name = "scannedFolderListBox";
            this.scannedFolderListBox.Size = new System.Drawing.Size(844, 394);
            this.scannedFolderListBox.TabIndex = 2;
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 443);
            this.Controls.Add(this.scannedFolderListBox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.scanButton);
            this.Name = "ScannerForm";
            this.Text = "Fake Virus Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.ListBox scannedFolderListBox;
    }
}

