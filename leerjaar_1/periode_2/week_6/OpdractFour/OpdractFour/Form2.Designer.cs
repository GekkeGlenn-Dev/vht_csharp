namespace OpdractFour
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CloseForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Something";
            // 
            // CloseForm2
            // 
            this.CloseForm2.Location = new System.Drawing.Point(261, 90);
            this.CloseForm2.Name = "CloseForm2";
            this.CloseForm2.Size = new System.Drawing.Size(75, 23);
            this.CloseForm2.TabIndex = 1;
            this.CloseForm2.Text = "CLOSE :D";
            this.CloseForm2.UseVisualStyleBackColor = true;
            this.CloseForm2.Click += new System.EventHandler(this.CloseForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 115);
            this.Controls.Add(this.CloseForm2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Opdracht 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseForm2;
    }
}