namespace RekenMachiene
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
            this.components = new System.ComponentModel.Container();
            this.numberOneTextBox = new System.Windows.Forms.TextBox();
            this.multiplayBtn = new System.Windows.Forms.Button();
            this.machtsVerheffingBtn = new System.Windows.Forms.Button();
            this.numberTwoTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.multiplayToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // numberOneTextBox
            // 
            this.numberOneTextBox.Location = new System.Drawing.Point(12, 12);
            this.numberOneTextBox.Name = "numberOneTextBox";
            this.numberOneTextBox.Size = new System.Drawing.Size(146, 20);
            this.numberOneTextBox.TabIndex = 0;
            // 
            // multiplayBtn
            // 
            this.multiplayBtn.Location = new System.Drawing.Point(12, 38);
            this.multiplayBtn.Name = "multiplayBtn";
            this.multiplayBtn.Size = new System.Drawing.Size(69, 23);
            this.multiplayBtn.TabIndex = 1;
            this.multiplayBtn.Text = "X";
            this.multiplayBtn.UseVisualStyleBackColor = true;
            this.multiplayBtn.Click += new System.EventHandler(this.multiplayBtn_Click);
            // 
            // machtsVerheffingBtn
            // 
            this.machtsVerheffingBtn.Location = new System.Drawing.Point(87, 38);
            this.machtsVerheffingBtn.Name = "machtsVerheffingBtn";
            this.machtsVerheffingBtn.Size = new System.Drawing.Size(71, 23);
            this.machtsVerheffingBtn.TabIndex = 2;
            this.machtsVerheffingBtn.Text = "^2";
            this.machtsVerheffingBtn.UseVisualStyleBackColor = true;
            this.machtsVerheffingBtn.Click += new System.EventHandler(this.machtsVerheffingBtn_Click);
            // 
            // numberTwoTextBox
            // 
            this.numberTwoTextBox.Location = new System.Drawing.Point(12, 67);
            this.numberTwoTextBox.Name = "numberTwoTextBox";
            this.numberTwoTextBox.Size = new System.Drawing.Size(146, 20);
            this.numberTwoTextBox.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 90);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(146, 33);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 132);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.numberTwoTextBox);
            this.Controls.Add(this.machtsVerheffingBtn);
            this.Controls.Add(this.multiplayBtn);
            this.Controls.Add(this.numberOneTextBox);
            this.MaximumSize = new System.Drawing.Size(186, 171);
            this.MinimumSize = new System.Drawing.Size(186, 171);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberOneTextBox;
        private System.Windows.Forms.Button multiplayBtn;
        private System.Windows.Forms.Button machtsVerheffingBtn;
        private System.Windows.Forms.TextBox numberTwoTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ToolTip multiplayToolTip;
    }
}

