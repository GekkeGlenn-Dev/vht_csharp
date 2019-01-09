namespace HuiswerkP2L3
{
    partial class QuizeForm
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
            this.questionOneLabel = new System.Windows.Forms.Label();
            this.questionOneAnswerBox = new System.Windows.Forms.TextBox();
            this.questionTwoChoses = new System.Windows.Forms.GroupBox();
            this.bartBtn = new System.Windows.Forms.RadioButton();
            this.feddeBtn = new System.Windows.Forms.RadioButton();
            this.timBtn = new System.Windows.Forms.RadioButton();
            this.eltonBtn = new System.Windows.Forms.RadioButton();
            this.questionTwoLabel = new System.Windows.Forms.Label();
            this.questionThreeComboBox = new System.Windows.Forms.ComboBox();
            this.answersCheckBox = new System.Windows.Forms.Button();
            this.questionThreeLabel = new System.Windows.Forms.Label();
            this.questionTwoChoses.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionOneLabel
            // 
            this.questionOneLabel.AutoSize = true;
            this.questionOneLabel.Location = new System.Drawing.Point(12, 9);
            this.questionOneLabel.Name = "questionOneLabel";
            this.questionOneLabel.Size = new System.Drawing.Size(174, 13);
            this.questionOneLabel.TabIndex = 0;
            this.questionOneLabel.Text = "1. Wie is de Gekste man op aarde?";
            // 
            // questionOneAnswerBox
            // 
            this.questionOneAnswerBox.Location = new System.Drawing.Point(12, 34);
            this.questionOneAnswerBox.Name = "questionOneAnswerBox";
            this.questionOneAnswerBox.Size = new System.Drawing.Size(203, 20);
            this.questionOneAnswerBox.TabIndex = 1;
            // 
            // questionTwoChoses
            // 
            this.questionTwoChoses.Controls.Add(this.bartBtn);
            this.questionTwoChoses.Controls.Add(this.feddeBtn);
            this.questionTwoChoses.Controls.Add(this.timBtn);
            this.questionTwoChoses.Controls.Add(this.eltonBtn);
            this.questionTwoChoses.Location = new System.Drawing.Point(15, 95);
            this.questionTwoChoses.Name = "questionTwoChoses";
            this.questionTwoChoses.Size = new System.Drawing.Size(200, 116);
            this.questionTwoChoses.TabIndex = 2;
            this.questionTwoChoses.TabStop = false;
            this.questionTwoChoses.Text = "Antwoorden";
            // 
            // bartBtn
            // 
            this.bartBtn.AutoSize = true;
            this.bartBtn.Location = new System.Drawing.Point(6, 88);
            this.bartBtn.Name = "bartBtn";
            this.bartBtn.Size = new System.Drawing.Size(44, 17);
            this.bartBtn.TabIndex = 7;
            this.bartBtn.TabStop = true;
            this.bartBtn.Text = "Bart";
            this.bartBtn.UseVisualStyleBackColor = true;
            // 
            // feddeBtn
            // 
            this.feddeBtn.AutoSize = true;
            this.feddeBtn.Location = new System.Drawing.Point(6, 65);
            this.feddeBtn.Name = "feddeBtn";
            this.feddeBtn.Size = new System.Drawing.Size(55, 17);
            this.feddeBtn.TabIndex = 6;
            this.feddeBtn.TabStop = true;
            this.feddeBtn.Text = "Fedde";
            this.feddeBtn.UseVisualStyleBackColor = true;
            // 
            // timBtn
            // 
            this.timBtn.AutoSize = true;
            this.timBtn.Location = new System.Drawing.Point(6, 42);
            this.timBtn.Name = "timBtn";
            this.timBtn.Size = new System.Drawing.Size(45, 17);
            this.timBtn.TabIndex = 5;
            this.timBtn.TabStop = true;
            this.timBtn.Text = "Tim ";
            this.timBtn.UseVisualStyleBackColor = true;
            // 
            // eltonBtn
            // 
            this.eltonBtn.AutoSize = true;
            this.eltonBtn.Location = new System.Drawing.Point(6, 19);
            this.eltonBtn.Name = "eltonBtn";
            this.eltonBtn.Size = new System.Drawing.Size(49, 17);
            this.eltonBtn.TabIndex = 4;
            this.eltonBtn.TabStop = true;
            this.eltonBtn.Text = "Elton";
            this.eltonBtn.UseVisualStyleBackColor = true;
            // 
            // questionTwoLabel
            // 
            this.questionTwoLabel.AutoSize = true;
            this.questionTwoLabel.Location = new System.Drawing.Point(9, 69);
            this.questionTwoLabel.Name = "questionTwoLabel";
            this.questionTwoLabel.Size = new System.Drawing.Size(206, 13);
            this.questionTwoLabel.TabIndex = 3;
            this.questionTwoLabel.Text = "2. Wie is de leukste leeraat van ROCWB?";
            // 
            // questionThreeComboBox
            // 
            this.questionThreeComboBox.FormattingEnabled = true;
            this.questionThreeComboBox.Items.AddRange(new object[] {
            "Saai",
            "Gewoon",
            "Leuk",
            "Super Leuk",
            "Antwoord staat er niet bij"});
            this.questionThreeComboBox.Location = new System.Drawing.Point(12, 239);
            this.questionThreeComboBox.Name = "questionThreeComboBox";
            this.questionThreeComboBox.Size = new System.Drawing.Size(203, 21);
            this.questionThreeComboBox.TabIndex = 4;
            // 
            // answersCheckBox
            // 
            this.answersCheckBox.Location = new System.Drawing.Point(12, 266);
            this.answersCheckBox.Name = "answersCheckBox";
            this.answersCheckBox.Size = new System.Drawing.Size(203, 23);
            this.answersCheckBox.TabIndex = 5;
            this.answersCheckBox.Text = "Check";
            this.answersCheckBox.UseVisualStyleBackColor = true;
            this.answersCheckBox.Click += new System.EventHandler(this.answersCheckBox_Click);
            // 
            // questionThreeLabel
            // 
            this.questionThreeLabel.AutoSize = true;
            this.questionThreeLabel.Location = new System.Drawing.Point(12, 223);
            this.questionThreeLabel.Name = "questionThreeLabel";
            this.questionThreeLabel.Size = new System.Drawing.Size(97, 13);
            this.questionThreeLabel.TabIndex = 6;
            this.questionThreeLabel.Text = "3. Wat is deze les?";
            // 
            // QuizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 301);
            this.Controls.Add(this.questionThreeLabel);
            this.Controls.Add(this.answersCheckBox);
            this.Controls.Add(this.questionThreeComboBox);
            this.Controls.Add(this.questionTwoLabel);
            this.Controls.Add(this.questionTwoChoses);
            this.Controls.Add(this.questionOneAnswerBox);
            this.Controls.Add(this.questionOneLabel);
            this.Name = "QuizeForm";
            this.Text = "Form1";
            this.questionTwoChoses.ResumeLayout(false);
            this.questionTwoChoses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionOneLabel;
        private System.Windows.Forms.TextBox questionOneAnswerBox;
        private System.Windows.Forms.GroupBox questionTwoChoses;
        private System.Windows.Forms.RadioButton bartBtn;
        private System.Windows.Forms.RadioButton feddeBtn;
        private System.Windows.Forms.RadioButton timBtn;
        private System.Windows.Forms.RadioButton eltonBtn;
        private System.Windows.Forms.Label questionTwoLabel;
        private System.Windows.Forms.ComboBox questionThreeComboBox;
        private System.Windows.Forms.Button answersCheckBox;
        private System.Windows.Forms.Label questionThreeLabel;
    }
}

