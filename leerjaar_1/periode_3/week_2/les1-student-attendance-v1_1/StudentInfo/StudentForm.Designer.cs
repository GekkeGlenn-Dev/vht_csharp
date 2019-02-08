namespace StudentInfo
{
    partial class StudentForm
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
            this.searchEditBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentInfoPanel = new System.Windows.Forms.Panel();
            this.studentCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentClassnameLabel = new System.Windows.Forms.Label();
            this.studentAbsentLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openAddStudentFormButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studentInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchEditBox
            // 
            this.searchEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchEditBox.Location = new System.Drawing.Point(85, 405);
            this.searchEditBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchEditBox.Name = "searchEditBox";
            this.searchEditBox.Size = new System.Drawing.Size(242, 20);
            this.searchEditBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.Location = new System.Drawing.Point(337, 405);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 19);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Studentname";
            // 
            // studentInfoPanel
            // 
            this.studentInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studentInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentInfoPanel.Controls.Add(this.studentCheckBox);
            this.studentInfoPanel.Controls.Add(this.label3);
            this.studentInfoPanel.Controls.Add(this.label2);
            this.studentInfoPanel.Controls.Add(this.studentClassnameLabel);
            this.studentInfoPanel.Controls.Add(this.studentAbsentLabel);
            this.studentInfoPanel.Controls.Add(this.studentNameLabel);
            this.studentInfoPanel.Location = new System.Drawing.Point(457, 24);
            this.studentInfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.studentInfoPanel.Name = "studentInfoPanel";
            this.studentInfoPanel.Size = new System.Drawing.Size(205, 98);
            this.studentInfoPanel.TabIndex = 8;
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Location = new System.Drawing.Point(8, 71);
            this.studentCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.Size = new System.Drawing.Size(62, 17);
            this.studentCheckBox.TabIndex = 12;
            this.studentCheckBox.Text = "Present";
            this.studentCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Absent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Class";
            // 
            // studentClassnameLabel
            // 
            this.studentClassnameLabel.AutoSize = true;
            this.studentClassnameLabel.Location = new System.Drawing.Point(46, 54);
            this.studentClassnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentClassnameLabel.Name = "studentClassnameLabel";
            this.studentClassnameLabel.Size = new System.Drawing.Size(31, 13);
            this.studentClassnameLabel.TabIndex = 9;
            this.studentClassnameLabel.Text = "< ? >";
            // 
            // studentAbsentLabel
            // 
            this.studentAbsentLabel.AutoSize = true;
            this.studentAbsentLabel.Location = new System.Drawing.Point(46, 33);
            this.studentAbsentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentAbsentLabel.Name = "studentAbsentLabel";
            this.studentAbsentLabel.Size = new System.Drawing.Size(31, 13);
            this.studentAbsentLabel.TabIndex = 8;
            this.studentAbsentLabel.Text = "< ? >";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AllowDrop = true;
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(10, 13);
            this.studentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(45, 17);
            this.studentNameLabel.TabIndex = 7;
            this.studentNameLabel.Text = "< ? >";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5});
            this.dataGridView1.Location = new System.Drawing.Point(9, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 366);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // index
            // 
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.Visible = false;
            // 
            // column1
            // 
            this.column1.HeaderText = "Student Number";
            this.column1.Name = "column1";
            // 
            // column2
            // 
            this.column2.HeaderText = "Name";
            this.column2.Name = "column2";
            // 
            // column3
            // 
            this.column3.HeaderText = "Class Name";
            this.column3.Name = "column3";
            // 
            // column4
            // 
            this.column4.HeaderText = "Absent";
            this.column4.Name = "column4";
            // 
            // column5
            // 
            this.column5.HeaderText = "Column5";
            this.column5.Name = "column5";
            this.column5.Visible = false;
            // 
            // openAddStudentFormButton
            // 
            this.openAddStudentFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openAddStudentFormButton.Location = new System.Drawing.Point(484, 405);
            this.openAddStudentFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.openAddStudentFormButton.Name = "openAddStudentFormButton";
            this.openAddStudentFormButton.Size = new System.Drawing.Size(56, 19);
            this.openAddStudentFormButton.TabIndex = 11;
            this.openAddStudentFormButton.Text = "Add...";
            this.openAddStudentFormButton.UseVisualStyleBackColor = true;
            this.openAddStudentFormButton.Click += new System.EventHandler(this.openAddStudentFormButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(544, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 12;
            this.button2.Text = "Remove...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openAddStudentFormButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.studentInfoPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchEditBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.Text = "Search Student";
            this.studentInfoPanel.ResumeLayout(false);
            this.studentInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchEditBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel studentInfoPanel;
        private System.Windows.Forms.Label studentClassnameLabel;
        private System.Windows.Forms.Label studentAbsentLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
        private System.Windows.Forms.CheckBox studentCheckBox;
        private System.Windows.Forms.Button openAddStudentFormButton;
        private System.Windows.Forms.Button button2;
    }
}

