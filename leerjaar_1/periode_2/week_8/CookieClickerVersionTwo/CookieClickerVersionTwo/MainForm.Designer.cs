namespace CookieClickerVersionTwo
{
    partial class MainForm
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
            this.increaseCookiesButton = new System.Windows.Forms.Button();
            this.totalPoints = new System.Windows.Forms.Label();
            this.shopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // increaseCookiesButton
            // 
            this.increaseCookiesButton.BackgroundImage = global::CookieClickerVersionTwo.Properties.Resources.cookie;
            this.increaseCookiesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.increaseCookiesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.increaseCookiesButton.FlatAppearance.BorderSize = 0;
            this.increaseCookiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increaseCookiesButton.Location = new System.Drawing.Point(12, 105);
            this.increaseCookiesButton.Name = "increaseCookiesButton";
            this.increaseCookiesButton.Size = new System.Drawing.Size(200, 200);
            this.increaseCookiesButton.TabIndex = 0;
            this.increaseCookiesButton.UseVisualStyleBackColor = true;
            this.increaseCookiesButton.Click += new System.EventHandler(this.increaseCookiesButton_Click);
            // 
            // totalPoints
            // 
            this.totalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPoints.Location = new System.Drawing.Point(0, 9);
            this.totalPoints.Name = "totalPoints";
            this.totalPoints.Size = new System.Drawing.Size(223, 36);
            this.totalPoints.TabIndex = 1;
            this.totalPoints.Text = "0";
            this.totalPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shopBtn
            // 
            this.shopBtn.Location = new System.Drawing.Point(152, 413);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(60, 25);
            this.shopBtn.TabIndex = 2;
            this.shopBtn.Text = "button1";
            this.shopBtn.UseVisualStyleBackColor = true;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 450);
            this.Controls.Add(this.shopBtn);
            this.Controls.Add(this.totalPoints);
            this.Controls.Add(this.increaseCookiesButton);
            this.Name = "MainForm";
            this.Text = "Cookie Clicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button increaseCookiesButton;
        private System.Windows.Forms.Label totalPoints;
        private System.Windows.Forms.Button shopBtn;
    }
}

