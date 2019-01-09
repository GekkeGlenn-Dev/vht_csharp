namespace EindOpdracht
{
    partial class Shop
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
            this.buyFerrariBtn = new System.Windows.Forms.Button();
            this.buyNikesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buyFerrariBtn
            // 
            this.buyFerrariBtn.Location = new System.Drawing.Point(12, 12);
            this.buyFerrariBtn.Name = "buyFerrariBtn";
            this.buyFerrariBtn.Size = new System.Drawing.Size(150, 150);
            this.buyFerrariBtn.TabIndex = 0;
            this.buyFerrariBtn.Text = "Ferrari\r\n€ 1.200.000,-";
            this.buyFerrariBtn.UseVisualStyleBackColor = true;
            this.buyFerrariBtn.Click += new System.EventHandler(this.buyFerrariBtn_Click);
            // 
            // buyNikesBtn
            // 
            this.buyNikesBtn.Location = new System.Drawing.Point(168, 12);
            this.buyNikesBtn.Name = "buyNikesBtn";
            this.buyNikesBtn.Size = new System.Drawing.Size(150, 150);
            this.buyNikesBtn.TabIndex = 1;
            this.buyNikesBtn.Text = "Nike\'s\r\n€75,-";
            this.buyNikesBtn.UseVisualStyleBackColor = true;
            this.buyNikesBtn.Click += new System.EventHandler(this.buyNikesBtn_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 173);
            this.Controls.Add(this.buyNikesBtn);
            this.Controls.Add(this.buyFerrariBtn);
            this.Name = "Shop";
            this.Text = "AMO Shop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyFerrariBtn;
        private System.Windows.Forms.Button buyNikesBtn;
    }
}