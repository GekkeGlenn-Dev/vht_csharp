namespace Rekenen
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
            this.GoButton = new System.Windows.Forms.Button();
            this.InputLeftBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.InputLeftLabel = new System.Windows.Forms.Label();
            this.InputRightBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Location = new System.Drawing.Point(328, 393);
            this.GoButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(500, 22);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Gaan met die banaan!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // InputLeftBox
            // 
            this.InputLeftBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputLeftBox.Location = new System.Drawing.Point(11, 393);
            this.InputLeftBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputLeftBox.Name = "InputLeftBox";
            this.InputLeftBox.Size = new System.Drawing.Size(146, 20);
            this.InputLeftBox.TabIndex = 1;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(11, 15);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(61, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Resultaten:";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(674, 11);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(154, 20);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Resultaten Leegmaken";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(11, 35);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(817, 351);
            this.ResultBox.TabIndex = 6;
            this.ResultBox.Text = "Welkom in deze calculator applicatie!\r\n";
            // 
            // InputLeftLabel
            // 
            this.InputLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputLeftLabel.AutoSize = true;
            this.InputLeftLabel.Location = new System.Drawing.Point(161, 396);
            this.InputLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputLeftLabel.Name = "InputLeftLabel";
            this.InputLeftLabel.Size = new System.Drawing.Size(13, 13);
            this.InputLeftLabel.TabIndex = 7;
            this.InputLeftLabel.Text = "+";
            // 
            // InputRightBox
            // 
            this.InputRightBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputRightBox.Location = new System.Drawing.Point(178, 393);
            this.InputRightBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputRightBox.Name = "InputRightBox";
            this.InputRightBox.Size = new System.Drawing.Size(146, 20);
            this.InputRightBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 426);
            this.Controls.Add(this.InputRightBox);
            this.Controls.Add(this.InputLeftLabel);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.InputLeftBox);
            this.Controls.Add(this.GoButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Rekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox InputLeftBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label InputLeftLabel;
        private System.Windows.Forms.TextBox InputRightBox;
    }
}

