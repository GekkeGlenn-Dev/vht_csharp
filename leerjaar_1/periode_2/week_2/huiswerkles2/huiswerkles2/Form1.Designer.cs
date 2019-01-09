namespace huiswerkles2
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
            this.personInfoGroep = new System.Windows.Forms.GroupBox();
            this.leeftijdOutputLabel = new System.Windows.Forms.Label();
            this.nameOutputLabel = new System.Windows.Forms.Label();
            this.leeftijdBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.leeftijdLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.finanGroup = new System.Windows.Forms.GroupBox();
            this.bankAmountOutputLabel = new System.Windows.Forms.Label();
            this.walletAmountOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.walletAmountBox = new System.Windows.Forms.TextBox();
            this.bankAmoutbox = new System.Windows.Forms.TextBox();
            this.walletAmountLabel = new System.Windows.Forms.Label();
            this.bankAmoutLabel = new System.Windows.Forms.Label();
            this.personInfoGroep.SuspendLayout();
            this.finanGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInfoGroep
            // 
            this.personInfoGroep.Controls.Add(this.leeftijdOutputLabel);
            this.personInfoGroep.Controls.Add(this.nameOutputLabel);
            this.personInfoGroep.Controls.Add(this.leeftijdBox);
            this.personInfoGroep.Controls.Add(this.nameBox);
            this.personInfoGroep.Controls.Add(this.leeftijdLabel);
            this.personInfoGroep.Controls.Add(this.nameLabel);
            this.personInfoGroep.Location = new System.Drawing.Point(12, 12);
            this.personInfoGroep.Name = "personInfoGroep";
            this.personInfoGroep.Size = new System.Drawing.Size(754, 86);
            this.personInfoGroep.TabIndex = 0;
            this.personInfoGroep.TabStop = false;
            this.personInfoGroep.Text = "Persoonlijke Informatie";
            // 
            // leeftijdOutputLabel
            // 
            this.leeftijdOutputLabel.AutoSize = true;
            this.leeftijdOutputLabel.Location = new System.Drawing.Point(151, 54);
            this.leeftijdOutputLabel.Name = "leeftijdOutputLabel";
            this.leeftijdOutputLabel.Size = new System.Drawing.Size(32, 13);
            this.leeftijdOutputLabel.TabIndex = 6;
            this.leeftijdOutputLabel.Text = "vul in";
            // 
            // nameOutputLabel
            // 
            this.nameOutputLabel.AutoSize = true;
            this.nameOutputLabel.Location = new System.Drawing.Point(394, 28);
            this.nameOutputLabel.Name = "nameOutputLabel";
            this.nameOutputLabel.Size = new System.Drawing.Size(32, 13);
            this.nameOutputLabel.TabIndex = 4;
            this.nameOutputLabel.Text = "vul in";
            // 
            // leeftijdBox
            // 
            this.leeftijdBox.Location = new System.Drawing.Point(81, 51);
            this.leeftijdBox.Name = "leeftijdBox";
            this.leeftijdBox.Size = new System.Drawing.Size(64, 20);
            this.leeftijdBox.TabIndex = 2;
            this.leeftijdBox.TextChanged += new System.EventHandler(this.leeftijdBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(81, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(307, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // leeftijdLabel
            // 
            this.leeftijdLabel.AutoSize = true;
            this.leeftijdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leeftijdLabel.Location = new System.Drawing.Point(6, 52);
            this.leeftijdLabel.Name = "leeftijdLabel";
            this.leeftijdLabel.Size = new System.Drawing.Size(67, 17);
            this.leeftijdLabel.TabIndex = 1;
            this.leeftijdLabel.Text = "Leeftijd:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(6, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // finanGroup
            // 
            this.finanGroup.Controls.Add(this.bankAmountOutputLabel);
            this.finanGroup.Controls.Add(this.walletAmountOutputLabel);
            this.finanGroup.Controls.Add(this.label1);
            this.finanGroup.Controls.Add(this.label2);
            this.finanGroup.Controls.Add(this.walletAmountBox);
            this.finanGroup.Controls.Add(this.bankAmoutbox);
            this.finanGroup.Controls.Add(this.walletAmountLabel);
            this.finanGroup.Controls.Add(this.bankAmoutLabel);
            this.finanGroup.Location = new System.Drawing.Point(12, 113);
            this.finanGroup.Name = "finanGroup";
            this.finanGroup.Size = new System.Drawing.Size(754, 86);
            this.finanGroup.TabIndex = 3;
            this.finanGroup.TabStop = false;
            this.finanGroup.Text = "Financiëel";
            // 
            // bankAmountOutputLabel
            // 
            this.bankAmountOutputLabel.AutoSize = true;
            this.bankAmountOutputLabel.Location = new System.Drawing.Point(353, 28);
            this.bankAmountOutputLabel.Name = "bankAmountOutputLabel";
            this.bankAmountOutputLabel.Size = new System.Drawing.Size(32, 13);
            this.bankAmountOutputLabel.TabIndex = 7;
            this.bankAmountOutputLabel.Text = "vul in";
            // 
            // walletAmountOutputLabel
            // 
            this.walletAmountOutputLabel.AutoSize = true;
            this.walletAmountOutputLabel.Location = new System.Drawing.Point(353, 54);
            this.walletAmountOutputLabel.Name = "walletAmountOutputLabel";
            this.walletAmountOutputLabel.Size = new System.Drawing.Size(32, 13);
            this.walletAmountOutputLabel.TabIndex = 5;
            this.walletAmountOutputLabel.Text = "vul in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "€";
            // 
            // walletAmountBox
            // 
            this.walletAmountBox.Location = new System.Drawing.Point(241, 51);
            this.walletAmountBox.Name = "walletAmountBox";
            this.walletAmountBox.Size = new System.Drawing.Size(106, 20);
            this.walletAmountBox.TabIndex = 2;
            this.walletAmountBox.TextChanged += new System.EventHandler(this.walletAmountBox_TextChanged);
            // 
            // bankAmoutbox
            // 
            this.bankAmoutbox.Location = new System.Drawing.Point(241, 25);
            this.bankAmoutbox.Name = "bankAmoutbox";
            this.bankAmoutbox.Size = new System.Drawing.Size(106, 20);
            this.bankAmoutbox.TabIndex = 1;
            this.bankAmoutbox.TextChanged += new System.EventHandler(this.bankAmoutbox_TextChanged);
            // 
            // walletAmountLabel
            // 
            this.walletAmountLabel.AutoSize = true;
            this.walletAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletAmountLabel.Location = new System.Drawing.Point(6, 52);
            this.walletAmountLabel.Name = "walletAmountLabel";
            this.walletAmountLabel.Size = new System.Drawing.Size(199, 17);
            this.walletAmountLabel.TabIndex = 1;
            this.walletAmountLabel.Text = "Geldbedrag Portomonnee:";
            // 
            // bankAmoutLabel
            // 
            this.bankAmoutLabel.AutoSize = true;
            this.bankAmoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankAmoutLabel.Location = new System.Drawing.Point(6, 26);
            this.bankAmoutLabel.Name = "bankAmoutLabel";
            this.bankAmoutLabel.Size = new System.Drawing.Size(139, 17);
            this.bankAmoutLabel.TabIndex = 0;
            this.bankAmoutLabel.Text = "Geldbedrag Bank:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 206);
            this.Controls.Add(this.finanGroup);
            this.Controls.Add(this.personInfoGroep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.personInfoGroep.ResumeLayout(false);
            this.personInfoGroep.PerformLayout();
            this.finanGroup.ResumeLayout(false);
            this.finanGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personInfoGroep;
        private System.Windows.Forms.TextBox leeftijdBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label leeftijdLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox finanGroup;
        private System.Windows.Forms.TextBox walletAmountBox;
        private System.Windows.Forms.TextBox bankAmoutbox;
        private System.Windows.Forms.Label walletAmountLabel;
        private System.Windows.Forms.Label bankAmoutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label leeftijdOutputLabel;
        private System.Windows.Forms.Label nameOutputLabel;
        private System.Windows.Forms.Label bankAmountOutputLabel;
        private System.Windows.Forms.Label walletAmountOutputLabel;
    }
}

