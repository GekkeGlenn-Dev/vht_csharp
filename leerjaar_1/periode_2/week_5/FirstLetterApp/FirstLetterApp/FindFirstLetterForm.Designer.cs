namespace FirstLetterApp
{
    partial class FindFirstLetterForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.findFirstLetterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(105, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(343, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter your name:";
            // 
            // findFirstLetterButton
            // 
            this.findFirstLetterButton.Location = new System.Drawing.Point(454, 6);
            this.findFirstLetterButton.Name = "findFirstLetterButton";
            this.findFirstLetterButton.Size = new System.Drawing.Size(180, 20);
            this.findFirstLetterButton.TabIndex = 2;
            this.findFirstLetterButton.Text = "Find the first letter of my name";
            this.findFirstLetterButton.UseVisualStyleBackColor = true;
            this.findFirstLetterButton.Click += new System.EventHandler(this.findFirstLetterButton_Click);
            // 
            // FindFirstLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 32);
            this.Controls.Add(this.findFirstLetterButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindFirstLetterForm";
            this.Text = "First letter application - Figure out what the first letter of your name is";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button findFirstLetterButton;
    }
}

