namespace EindOpdracht
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
            this.balanceLabel = new System.Windows.Forms.Label();
            this.openShopBtn = new System.Windows.Forms.Button();
            this.chackIfOddOrEven = new System.Windows.Forms.Button();
            this.transactionListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(42, 28);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(83, 25);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Balance";
            // 
            // openShopBtn
            // 
            this.openShopBtn.Location = new System.Drawing.Point(203, 12);
            this.openShopBtn.Name = "openShopBtn";
            this.openShopBtn.Size = new System.Drawing.Size(160, 160);
            this.openShopBtn.TabIndex = 1;
            this.openShopBtn.Text = "Spend my money!";
            this.openShopBtn.UseVisualStyleBackColor = true;
            this.openShopBtn.Click += new System.EventHandler(this.openShopBtn_Click);
            // 
            // chackIfOddOrEven
            // 
            this.chackIfOddOrEven.Location = new System.Drawing.Point(47, 100);
            this.chackIfOddOrEven.Name = "chackIfOddOrEven";
            this.chackIfOddOrEven.Size = new System.Drawing.Size(86, 38);
            this.chackIfOddOrEven.TabIndex = 2;
            this.chackIfOddOrEven.Text = "is my balance even or odd?";
            this.chackIfOddOrEven.UseVisualStyleBackColor = true;
            // 
            // transactionListBox
            // 
            this.transactionListBox.FormattingEnabled = true;
            this.transactionListBox.Location = new System.Drawing.Point(5, 196);
            this.transactionListBox.Name = "transactionListBox";
            this.transactionListBox.Size = new System.Drawing.Size(372, 173);
            this.transactionListBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transactions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transactionListBox);
            this.Controls.Add(this.chackIfOddOrEven);
            this.Controls.Add(this.openShopBtn);
            this.Controls.Add(this.balanceLabel);
            this.Name = "MainForm";
            this.Text = "AMO Bank";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button openShopBtn;
        private System.Windows.Forms.Button chackIfOddOrEven;
        private System.Windows.Forms.ListBox transactionListBox;
        private System.Windows.Forms.Label label2;
    }
}

