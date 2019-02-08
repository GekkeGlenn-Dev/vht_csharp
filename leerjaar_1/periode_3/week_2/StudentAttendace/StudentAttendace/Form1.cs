using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendace
{
    public partial class Form1 : Form
    {
        const int arrayLength = 100;
        int count;
        Student students = new Student();//[arrayLength];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count = 1;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                students.Id = int.Parse(idTextBox.Text);
            }
            catch (NullReferenceException)
            {

            }
            students.FirstName = firstNameTextBox.Text;
            students.SurName = lastNameTextBox.Text;
            if (trueRadioButton.Checked) { students.AttendingClass = true; }
            else if (falseRadioButton.Checked) { students.AttendingClass = false; }
            students.ShirtColor = shirtColorTextBox.Text;
            students.PantsColor = pantsColorTextBox.Text;

            studentListBox.Items.Add(students.Greet());
            firstNameTextBox.Text = "";
            idTextBox.Text = "";
            lastNameTextBox.Text = "";
            trueRadioButton.Checked = false;
            falseRadioButton.Checked = false;
            shirtColorTextBox.Text = "";
            pantsColorTextBox.Text = "";
            count++;

        }
    }
}
