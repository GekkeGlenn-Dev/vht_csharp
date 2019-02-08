namespace StudentInfo
{
    partial class AddStudentForm
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
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentNumberLabel = new System.Windows.Forms.Label();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.studentAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(121, 9);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(75, 13);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "Naam Student";
            // 
            // studentNumberLabel
            // 
            this.studentNumberLabel.AutoSize = true;
            this.studentNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.studentNumberLabel.Name = "studentNumberLabel";
            this.studentNumberLabel.Size = new System.Drawing.Size(101, 13);
            this.studentNumberLabel.TabIndex = 1;
            this.studentNumberLabel.Text = "Studenten Nummer.";
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.Location = new System.Drawing.Point(15, 25);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNumberTextBox.TabIndex = 2;
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(330, 25);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.classNameTextBox.TabIndex = 4;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(121, 25);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.studentNameTextBox.TabIndex = 5;
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(332, 9);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(63, 13);
            this.classNameLabel.TabIndex = 7;
            this.classNameLabel.Text = "Class Name";
            // 
            // studentAddButton
            // 
            this.studentAddButton.Location = new System.Drawing.Point(436, 25);
            this.studentAddButton.Name = "studentAddButton";
            this.studentAddButton.Size = new System.Drawing.Size(82, 20);
            this.studentAddButton.TabIndex = 8;
            this.studentAddButton.Text = "Add Student";
            this.studentAddButton.UseVisualStyleBackColor = true;
            this.studentAddButton.Click += new System.EventHandler(this.studentAddButton_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 55);
            this.Controls.Add(this.studentAddButton);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.classNameTextBox);
            this.Controls.Add(this.studentNumberTextBox);
            this.Controls.Add(this.studentNumberLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Name = "AddStudentForm";
            this.Text = "Student Toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentNumberLabel;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Button studentAddButton;
    }
}