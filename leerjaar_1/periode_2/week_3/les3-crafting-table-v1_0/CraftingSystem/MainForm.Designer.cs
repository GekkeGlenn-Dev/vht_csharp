namespace CraftingSystem
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
            this.leftItemGroupBox = new System.Windows.Forms.GroupBox();
            this.leftItemPictureBox = new System.Windows.Forms.PictureBox();
            this.rightItemGroupBox = new System.Windows.Forms.GroupBox();
            this.rightItemPictureBox = new System.Windows.Forms.PictureBox();
            this.inventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.redGemPictureBox = new System.Windows.Forms.PictureBox();
            this.clearPotionPictureBox = new System.Windows.Forms.PictureBox();
            this.blueBarryPictureBox = new System.Windows.Forms.PictureBox();
            this.greenBookPictureBox = new System.Windows.Forms.PictureBox();
            this.craftButton = new System.Windows.Forms.Button();
            this.combineIndicatorLabel = new System.Windows.Forms.Label();
            this.resultItemGroupBox = new System.Windows.Forms.GroupBox();
            this.resultItemPictureBox = new System.Windows.Forms.PictureBox();
            this.resultItemDescriptionLabel = new System.Windows.Forms.Label();
            this.resultItemTitleLabel = new System.Windows.Forms.Label();
            this.plainShirtPictureBox = new System.Windows.Forms.PictureBox();
            this.leftItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftItemPictureBox)).BeginInit();
            this.rightItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightItemPictureBox)).BeginInit();
            this.inventoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redGemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPotionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBarryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBookPictureBox)).BeginInit();
            this.resultItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainShirtPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftItemGroupBox
            // 
            this.leftItemGroupBox.Controls.Add(this.leftItemPictureBox);
            this.leftItemGroupBox.Location = new System.Drawing.Point(12, 12);
            this.leftItemGroupBox.Name = "leftItemGroupBox";
            this.leftItemGroupBox.Size = new System.Drawing.Size(112, 125);
            this.leftItemGroupBox.TabIndex = 0;
            this.leftItemGroupBox.TabStop = false;
            this.leftItemGroupBox.Text = "Item 1";
            // 
            // leftItemPictureBox
            // 
            this.leftItemPictureBox.Location = new System.Drawing.Point(6, 19);
            this.leftItemPictureBox.Name = "leftItemPictureBox";
            this.leftItemPictureBox.Size = new System.Drawing.Size(100, 100);
            this.leftItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftItemPictureBox.TabIndex = 5;
            this.leftItemPictureBox.TabStop = false;
            // 
            // rightItemGroupBox
            // 
            this.rightItemGroupBox.Controls.Add(this.rightItemPictureBox);
            this.rightItemGroupBox.Location = new System.Drawing.Point(178, 12);
            this.rightItemGroupBox.Name = "rightItemGroupBox";
            this.rightItemGroupBox.Size = new System.Drawing.Size(112, 125);
            this.rightItemGroupBox.TabIndex = 1;
            this.rightItemGroupBox.TabStop = false;
            this.rightItemGroupBox.Text = "Item 2";
            // 
            // rightItemPictureBox
            // 
            this.rightItemPictureBox.Location = new System.Drawing.Point(6, 19);
            this.rightItemPictureBox.Name = "rightItemPictureBox";
            this.rightItemPictureBox.Size = new System.Drawing.Size(100, 100);
            this.rightItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightItemPictureBox.TabIndex = 6;
            this.rightItemPictureBox.TabStop = false;
            // 
            // inventoryGroupBox
            // 
            this.inventoryGroupBox.Controls.Add(this.plainShirtPictureBox);
            this.inventoryGroupBox.Controls.Add(this.redGemPictureBox);
            this.inventoryGroupBox.Controls.Add(this.clearPotionPictureBox);
            this.inventoryGroupBox.Controls.Add(this.blueBarryPictureBox);
            this.inventoryGroupBox.Controls.Add(this.greenBookPictureBox);
            this.inventoryGroupBox.Location = new System.Drawing.Point(12, 143);
            this.inventoryGroupBox.Name = "inventoryGroupBox";
            this.inventoryGroupBox.Size = new System.Drawing.Size(545, 235);
            this.inventoryGroupBox.TabIndex = 2;
            this.inventoryGroupBox.TabStop = false;
            this.inventoryGroupBox.Text = "Inventory";
            // 
            // redGemPictureBox
            // 
            this.redGemPictureBox.Image = global::CraftingSystem.Properties.Resources.RedGem;
            this.redGemPictureBox.Location = new System.Drawing.Point(324, 19);
            this.redGemPictureBox.Name = "redGemPictureBox";
            this.redGemPictureBox.Size = new System.Drawing.Size(100, 100);
            this.redGemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGemPictureBox.TabIndex = 5;
            this.redGemPictureBox.TabStop = false;
            this.redGemPictureBox.Click += new System.EventHandler(this.redGemPictureBox_Click);
            // 
            // clearPotionPictureBox
            // 
            this.clearPotionPictureBox.Image = global::CraftingSystem.Properties.Resources.ClearPotion;
            this.clearPotionPictureBox.Location = new System.Drawing.Point(218, 19);
            this.clearPotionPictureBox.Name = "clearPotionPictureBox";
            this.clearPotionPictureBox.Size = new System.Drawing.Size(100, 100);
            this.clearPotionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearPotionPictureBox.TabIndex = 4;
            this.clearPotionPictureBox.TabStop = false;
            this.clearPotionPictureBox.Click += new System.EventHandler(this.clearPotionPictureBox_Click);
            // 
            // blueBarryPictureBox
            // 
            this.blueBarryPictureBox.Image = global::CraftingSystem.Properties.Resources.BlueBerry;
            this.blueBarryPictureBox.Location = new System.Drawing.Point(112, 19);
            this.blueBarryPictureBox.Name = "blueBarryPictureBox";
            this.blueBarryPictureBox.Size = new System.Drawing.Size(100, 100);
            this.blueBarryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueBarryPictureBox.TabIndex = 1;
            this.blueBarryPictureBox.TabStop = false;
            this.blueBarryPictureBox.Click += new System.EventHandler(this.blueBarryPictureBox_Click);
            // 
            // greenBookPictureBox
            // 
            this.greenBookPictureBox.Image = global::CraftingSystem.Properties.Resources.GreenBook;
            this.greenBookPictureBox.Location = new System.Drawing.Point(6, 19);
            this.greenBookPictureBox.Name = "greenBookPictureBox";
            this.greenBookPictureBox.Size = new System.Drawing.Size(100, 100);
            this.greenBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenBookPictureBox.TabIndex = 0;
            this.greenBookPictureBox.TabStop = false;
            this.greenBookPictureBox.Click += new System.EventHandler(this.greenBookPictureBox_Click);
            // 
            // craftButton
            // 
            this.craftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.craftButton.Location = new System.Drawing.Point(296, 56);
            this.craftButton.Name = "craftButton";
            this.craftButton.Size = new System.Drawing.Size(40, 53);
            this.craftButton.TabIndex = 3;
            this.craftButton.Text = "=";
            this.craftButton.UseVisualStyleBackColor = true;
            this.craftButton.Click += new System.EventHandler(this.craftButton_Click);
            // 
            // combineIndicatorLabel
            // 
            this.combineIndicatorLabel.AutoSize = true;
            this.combineIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.combineIndicatorLabel.Location = new System.Drawing.Point(135, 62);
            this.combineIndicatorLabel.Name = "combineIndicatorLabel";
            this.combineIndicatorLabel.Size = new System.Drawing.Size(37, 39);
            this.combineIndicatorLabel.TabIndex = 4;
            this.combineIndicatorLabel.Text = "+";
            // 
            // resultItemGroupBox
            // 
            this.resultItemGroupBox.Controls.Add(this.resultItemPictureBox);
            this.resultItemGroupBox.Controls.Add(this.resultItemDescriptionLabel);
            this.resultItemGroupBox.Controls.Add(this.resultItemTitleLabel);
            this.resultItemGroupBox.Location = new System.Drawing.Point(342, 12);
            this.resultItemGroupBox.Name = "resultItemGroupBox";
            this.resultItemGroupBox.Size = new System.Drawing.Size(215, 125);
            this.resultItemGroupBox.TabIndex = 2;
            this.resultItemGroupBox.TabStop = false;
            this.resultItemGroupBox.Text = "Result";
            // 
            // resultItemPictureBox
            // 
            this.resultItemPictureBox.Location = new System.Drawing.Point(6, 19);
            this.resultItemPictureBox.Name = "resultItemPictureBox";
            this.resultItemPictureBox.Size = new System.Drawing.Size(100, 100);
            this.resultItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultItemPictureBox.TabIndex = 4;
            this.resultItemPictureBox.TabStop = false;
            // 
            // resultItemDescriptionLabel
            // 
            this.resultItemDescriptionLabel.AutoEllipsis = true;
            this.resultItemDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultItemDescriptionLabel.Location = new System.Drawing.Point(118, 40);
            this.resultItemDescriptionLabel.Name = "resultItemDescriptionLabel";
            this.resultItemDescriptionLabel.Size = new System.Drawing.Size(88, 79);
            this.resultItemDescriptionLabel.TabIndex = 3;
            this.resultItemDescriptionLabel.Text = "Description of the item will go here.";
            // 
            // resultItemTitleLabel
            // 
            this.resultItemTitleLabel.AutoSize = true;
            this.resultItemTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultItemTitleLabel.Location = new System.Drawing.Point(118, 19);
            this.resultItemTitleLabel.Name = "resultItemTitleLabel";
            this.resultItemTitleLabel.Size = new System.Drawing.Size(67, 13);
            this.resultItemTitleLabel.TabIndex = 2;
            this.resultItemTitleLabel.Text = "Item Name";
            // 
            // plainShirtPictureBox
            // 
            this.plainShirtPictureBox.Image = global::CraftingSystem.Properties.Resources.PlainShirt;
            this.plainShirtPictureBox.Location = new System.Drawing.Point(430, 19);
            this.plainShirtPictureBox.Name = "plainShirtPictureBox";
            this.plainShirtPictureBox.Size = new System.Drawing.Size(100, 100);
            this.plainShirtPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plainShirtPictureBox.TabIndex = 6;
            this.plainShirtPictureBox.TabStop = false;
            this.plainShirtPictureBox.Click += new System.EventHandler(this.plainShirtPictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 389);
            this.Controls.Add(this.resultItemGroupBox);
            this.Controls.Add(this.combineIndicatorLabel);
            this.Controls.Add(this.craftButton);
            this.Controls.Add(this.inventoryGroupBox);
            this.Controls.Add(this.rightItemGroupBox);
            this.Controls.Add(this.leftItemGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Crafting Table";
            this.leftItemGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftItemPictureBox)).EndInit();
            this.rightItemGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightItemPictureBox)).EndInit();
            this.inventoryGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redGemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPotionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBarryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBookPictureBox)).EndInit();
            this.resultItemGroupBox.ResumeLayout(false);
            this.resultItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainShirtPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox leftItemGroupBox;
        private System.Windows.Forms.GroupBox rightItemGroupBox;
        private System.Windows.Forms.GroupBox inventoryGroupBox;
        private System.Windows.Forms.Button craftButton;
        private System.Windows.Forms.Label combineIndicatorLabel;
        private System.Windows.Forms.GroupBox resultItemGroupBox;
        private System.Windows.Forms.Label resultItemTitleLabel;
        private System.Windows.Forms.Label resultItemDescriptionLabel;
        private System.Windows.Forms.PictureBox leftItemPictureBox;
        private System.Windows.Forms.PictureBox rightItemPictureBox;
        private System.Windows.Forms.PictureBox blueBarryPictureBox;
        private System.Windows.Forms.PictureBox greenBookPictureBox;
        private System.Windows.Forms.PictureBox resultItemPictureBox;
        private System.Windows.Forms.PictureBox redGemPictureBox;
        private System.Windows.Forms.PictureBox clearPotionPictureBox;
        private System.Windows.Forms.PictureBox plainShirtPictureBox;
    }
}

