namespace StudentAttendace
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
            this.submitButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pantsColorTextBox = new System.Windows.Forms.TextBox();
            this.shirtColorTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trueRadioButton = new System.Windows.Forms.RadioButton();
            this.falseRadioButton = new System.Windows.Forms.RadioButton();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(180, 210);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(142, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(180, 54);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(142, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // pantsColorTextBox
            // 
            this.pantsColorTextBox.Location = new System.Drawing.Point(180, 184);
            this.pantsColorTextBox.Name = "pantsColorTextBox";
            this.pantsColorTextBox.Size = new System.Drawing.Size(142, 20);
            this.pantsColorTextBox.TabIndex = 7;
            // 
            // shirtColorTextBox
            // 
            this.shirtColorTextBox.Location = new System.Drawing.Point(180, 158);
            this.shirtColorTextBox.Name = "shirtColorTextBox";
            this.shirtColorTextBox.Size = new System.Drawing.Size(142, 20);
            this.shirtColorTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(180, 106);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(180, 80);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "studenten Nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Voor Naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Achter Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Klas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Shirt Kleur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Broek Kleur";
            // 
            // trueRadioButton
            // 
            this.trueRadioButton.AutoSize = true;
            this.trueRadioButton.Location = new System.Drawing.Point(180, 133);
            this.trueRadioButton.Name = "trueRadioButton";
            this.trueRadioButton.Size = new System.Drawing.Size(43, 17);
            this.trueRadioButton.TabIndex = 4;
            this.trueRadioButton.TabStop = true;
            this.trueRadioButton.Text = "true";
            this.trueRadioButton.UseVisualStyleBackColor = true;
            // 
            // falseRadioButton
            // 
            this.falseRadioButton.AutoSize = true;
            this.falseRadioButton.Location = new System.Drawing.Point(229, 133);
            this.falseRadioButton.Name = "falseRadioButton";
            this.falseRadioButton.Size = new System.Drawing.Size(47, 17);
            this.falseRadioButton.TabIndex = 5;
            this.falseRadioButton.TabStop = true;
            this.falseRadioButton.Text = "false";
            this.falseRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(370, 54);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(381, 329);
            this.studentListBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.falseRadioButton);
            this.Controls.Add(this.trueRadioButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.shirtColorTextBox);
            this.Controls.Add(this.pantsColorTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "hakt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox pantsColorTextBox;
        private System.Windows.Forms.TextBox shirtColorTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton trueRadioButton;
        private System.Windows.Forms.RadioButton falseRadioButton;
        private System.Windows.Forms.ListBox studentListBox;
    }
}

