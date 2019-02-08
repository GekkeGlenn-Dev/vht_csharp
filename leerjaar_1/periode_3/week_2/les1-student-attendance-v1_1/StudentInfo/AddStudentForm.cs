using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class AddStudentForm : Form
    {
        static int studentAmount = 124;
        public string[] arrayStudentName = new string[studentAmount];
        public string[] arrayStudentClassName = new string[studentAmount];
        public string[] arrayStudentnumber = new string[studentAmount];

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void studentAddButton_Click(object sender, EventArgs e)
        {
            studentAmount++;
            arrayStudentName.Length;
            this.Close();
        }
    }
}
