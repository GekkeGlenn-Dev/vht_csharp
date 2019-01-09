namespace QuizApp
{
    partial class QuizForm
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
            this.songLabel = new System.Windows.Forms.Label();
            this.songAnswerTextBox = new System.Windows.Forms.TextBox();
            this.memeGroupBox = new System.Windows.Forms.GroupBox();
            this.dumpertMemeRadioButton = new System.Windows.Forms.RadioButton();
            this.forniteMemeRadioButton = new System.Windows.Forms.RadioButton();
            this.sonMemeRadioButton = new System.Windows.Forms.RadioButton();
            this.shootingMemeRadioButton = new System.Windows.Forms.RadioButton();
            this.breakComboBox = new System.Windows.Forms.ComboBox();
            this.memeLabel = new System.Windows.Forms.Label();
            this.breakLabel = new System.Windows.Forms.Label();
            this.checkAnswersButton = new System.Windows.Forms.Button();
            this.calculateLabel = new System.Windows.Forms.Label();
            this.calculateTextBox = new System.Windows.Forms.TextBox();
            this.memeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(24, 17);
            this.songLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(410, 25);
            this.songLabel.TabIndex = 0;
            this.songLabel.Text = "1. Wie schreef het liedje \'Shooting Stars\'?";
            // 
            // songAnswerTextBox
            // 
            this.songAnswerTextBox.Location = new System.Drawing.Point(30, 48);
            this.songAnswerTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.songAnswerTextBox.Name = "songAnswerTextBox";
            this.songAnswerTextBox.Size = new System.Drawing.Size(676, 31);
            this.songAnswerTextBox.TabIndex = 1;
            // 
            // memeGroupBox
            // 
            this.memeGroupBox.Controls.Add(this.dumpertMemeRadioButton);
            this.memeGroupBox.Controls.Add(this.forniteMemeRadioButton);
            this.memeGroupBox.Controls.Add(this.sonMemeRadioButton);
            this.memeGroupBox.Controls.Add(this.shootingMemeRadioButton);
            this.memeGroupBox.Location = new System.Drawing.Point(30, 158);
            this.memeGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.memeGroupBox.Name = "memeGroupBox";
            this.memeGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.memeGroupBox.Size = new System.Drawing.Size(680, 225);
            this.memeGroupBox.TabIndex = 2;
            this.memeGroupBox.TabStop = false;
            this.memeGroupBox.Text = "Antwoorden";
            // 
            // dumpertMemeRadioButton
            // 
            this.dumpertMemeRadioButton.AutoSize = true;
            this.dumpertMemeRadioButton.Location = new System.Drawing.Point(12, 169);
            this.dumpertMemeRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.dumpertMemeRadioButton.Name = "dumpertMemeRadioButton";
            this.dumpertMemeRadioButton.Size = new System.Drawing.Size(373, 29);
            this.dumpertMemeRadioButton.TabIndex = 3;
            this.dumpertMemeRadioButton.TabStop = true;
            this.dumpertMemeRadioButton.Text = "Klassiek hollandse dumpert humor";
            this.dumpertMemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // forniteMemeRadioButton
            // 
            this.forniteMemeRadioButton.AutoSize = true;
            this.forniteMemeRadioButton.Location = new System.Drawing.Point(12, 125);
            this.forniteMemeRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.forniteMemeRadioButton.Name = "forniteMemeRadioButton";
            this.forniteMemeRadioButton.Size = new System.Drawing.Size(255, 29);
            this.forniteMemeRadioButton.TabIndex = 2;
            this.forniteMemeRadioButton.TabStop = true;
            this.forniteMemeRadioButton.Text = "Whatever met Fortnite";
            this.forniteMemeRadioButton.UseVisualStyleBackColor = true;
            this.forniteMemeRadioButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forniteMemeRadioButton_MouseDown);
            // 
            // sonMemeRadioButton
            // 
            this.sonMemeRadioButton.AutoSize = true;
            this.sonMemeRadioButton.Location = new System.Drawing.Point(12, 81);
            this.sonMemeRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.sonMemeRadioButton.Name = "sonMemeRadioButton";
            this.sonMemeRadioButton.Size = new System.Drawing.Size(223, 29);
            this.sonMemeRadioButton.TabIndex = 1;
            this.sonMemeRadioButton.TabStop = true;
            this.sonMemeRadioButton.Text = "Son, I\'m dissapoint";
            this.sonMemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // shootingMemeRadioButton
            // 
            this.shootingMemeRadioButton.AutoSize = true;
            this.shootingMemeRadioButton.Location = new System.Drawing.Point(12, 37);
            this.shootingMemeRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.shootingMemeRadioButton.Name = "shootingMemeRadioButton";
            this.shootingMemeRadioButton.Size = new System.Drawing.Size(184, 29);
            this.shootingMemeRadioButton.TabIndex = 0;
            this.shootingMemeRadioButton.TabStop = true;
            this.shootingMemeRadioButton.Text = "Shooting Stars";
            this.shootingMemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // breakComboBox
            // 
            this.breakComboBox.FormattingEnabled = true;
            this.breakComboBox.Items.AddRange(new object[] {
            "09.30",
            "10.00",
            "10.15",
            "10.30",
            "10.45",
            "kwart over 0"});
            this.breakComboBox.Location = new System.Drawing.Point(30, 442);
            this.breakComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.breakComboBox.Name = "breakComboBox";
            this.breakComboBox.Size = new System.Drawing.Size(676, 33);
            this.breakComboBox.TabIndex = 3;
            // 
            // memeLabel
            // 
            this.memeLabel.AutoSize = true;
            this.memeLabel.Location = new System.Drawing.Point(24, 127);
            this.memeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.memeLabel.Name = "memeLabel";
            this.memeLabel.Size = new System.Drawing.Size(398, 25);
            this.memeLabel.TabIndex = 4;
            this.memeLabel.Text = "2. Welke van deze memes is het leukst?";
            // 
            // breakLabel
            // 
            this.breakLabel.AutoSize = true;
            this.breakLabel.Location = new System.Drawing.Point(24, 412);
            this.breakLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.breakLabel.Name = "breakLabel";
            this.breakLabel.Size = new System.Drawing.Size(252, 25);
            this.breakLabel.TabIndex = 5;
            this.breakLabel.Text = "3. Wanneer is de pauze?";
            // 
            // checkAnswersButton
            // 
            this.checkAnswersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkAnswersButton.Location = new System.Drawing.Point(30, 598);
            this.checkAnswersButton.Margin = new System.Windows.Forms.Padding(6);
            this.checkAnswersButton.Name = "checkAnswersButton";
            this.checkAnswersButton.Size = new System.Drawing.Size(686, 63);
            this.checkAnswersButton.TabIndex = 6;
            this.checkAnswersButton.Text = "Controleer de antwoorden";
            this.checkAnswersButton.UseVisualStyleBackColor = true;
            this.checkAnswersButton.Click += new System.EventHandler(this.checkAnswersButton_Click);
            // 
            // calculateLabel
            // 
            this.calculateLabel.AutoSize = true;
            this.calculateLabel.Location = new System.Drawing.Point(25, 495);
            this.calculateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.calculateLabel.Name = "calculateLabel";
            this.calculateLabel.Size = new System.Drawing.Size(276, 25);
            this.calculateLabel.TabIndex = 7;
            this.calculateLabel.Text = "4. Wat is 5 gedeeld door 2?";
            // 
            // calculateTextBox
            // 
            this.calculateTextBox.Location = new System.Drawing.Point(29, 539);
            this.calculateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.calculateTextBox.Name = "calculateTextBox";
            this.calculateTextBox.Size = new System.Drawing.Size(676, 31);
            this.calculateTextBox.TabIndex = 8;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 684);
            this.Controls.Add(this.calculateTextBox);
            this.Controls.Add(this.calculateLabel);
            this.Controls.Add(this.checkAnswersButton);
            this.Controls.Add(this.breakLabel);
            this.Controls.Add(this.memeLabel);
            this.Controls.Add(this.breakComboBox);
            this.Controls.Add(this.memeGroupBox);
            this.Controls.Add(this.songAnswerTextBox);
            this.Controls.Add(this.songLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuizForm";
            this.Text = "Form1";
            this.memeGroupBox.ResumeLayout(false);
            this.memeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.TextBox songAnswerTextBox;
        private System.Windows.Forms.GroupBox memeGroupBox;
        private System.Windows.Forms.RadioButton dumpertMemeRadioButton;
        private System.Windows.Forms.RadioButton forniteMemeRadioButton;
        private System.Windows.Forms.RadioButton sonMemeRadioButton;
        private System.Windows.Forms.RadioButton shootingMemeRadioButton;
        private System.Windows.Forms.ComboBox breakComboBox;
        private System.Windows.Forms.Label memeLabel;
        private System.Windows.Forms.Label breakLabel;
        private System.Windows.Forms.Button checkAnswersButton;
        private System.Windows.Forms.Label calculateLabel;
        private System.Windows.Forms.TextBox calculateTextBox;
    }
}

