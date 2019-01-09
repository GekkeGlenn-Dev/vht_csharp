using System.Windows.Forms;

namespace CookieClicker
{
    partial class CookieForm
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
            this.countLabel = new System.Windows.Forms.Label();
            this.incrementButton = new System.Windows.Forms.Button();
            this.bonusCheckBox = new System.Windows.Forms.CheckBox();
            this.hotKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(50, 31);
            this.countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(36, 37);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "0";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incrementButton
            // 
            this.incrementButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.incrementButton.FlatAppearance.BorderSize = 0;
            this.incrementButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.incrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incrementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementButton.Location = new System.Drawing.Point(251, 23);
            this.incrementButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incrementButton.Name = "incrementButton";
            this.incrementButton.Size = new System.Drawing.Size(129, 51);
            this.incrementButton.TabIndex = 1;
            this.incrementButton.Text = "+1";
            this.incrementButton.UseVisualStyleBackColor = false;
            this.incrementButton.Click += new System.EventHandler(this.incrementButton_Click);
            // 
            // bonusCheckBox
            // 
            this.bonusCheckBox.AutoSize = true;
            this.bonusCheckBox.Location = new System.Drawing.Point(251, 83);
            this.bonusCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bonusCheckBox.Name = "bonusCheckBox";
            this.bonusCheckBox.Size = new System.Drawing.Size(130, 17);
            this.bonusCheckBox.TabIndex = 2;
            this.bonusCheckBox.Text = "Superbonus (+1 extra)";
            this.bonusCheckBox.UseVisualStyleBackColor = true;
            // 
            // hotKeyLabel
            // 
            this.hotKeyLabel.AutoSize = true;
            this.hotKeyLabel.Location = new System.Drawing.Point(8, 83);
            this.hotKeyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hotKeyLabel.Name = "hotKeyLabel";
            this.hotKeyLabel.Size = new System.Drawing.Size(119, 13);
            this.hotKeyLabel.TabIndex = 3;
            this.hotKeyLabel.Text = "Sneltoetsen: +, p, i, q, >";
            // 
            // CookieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 103);
            this.Controls.Add(this.hotKeyLabel);
            this.Controls.Add(this.bonusCheckBox);
            this.Controls.Add(this.incrementButton);
            this.Controls.Add(this.countLabel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(418, 142);
            this.MinimumSize = new System.Drawing.Size(418, 142);
            this.Name = "CookieForm";
            this.Text = "Mmmm Cookie\'s!";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CookieForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button incrementButton;
        private System.Windows.Forms.CheckBox bonusCheckBox;

        private void CookieForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    plusKey_Press(sender, e);
                    break;
                case 'p':
                    pKey_Press(sender, e);
                    break;
                case 'i':
                    iKey_Press(sender, e);
                    break;
                case 'q':
                    qKey_Press(sender, e);
                    break;
                case '>':
                    greaterThanKey_Press(sender, e);
                    break;
            }
        }

        private Label hotKeyLabel;
    }

}

