using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekenMachiene
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void multiplayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                resultLabel.Text = multiplay(int.Parse(numberOneTextBox.Text), int.Parse(numberTwoTextBox.Text)).ToString();
                numberOneTextBox.Text = "";
                numberTwoTextBox.Text = "";
            }
            catch
            {
                resultLabel.Text = "Error";
            }
            
        }

        private int multiplay(int number1, int number2)
        {
            return  number1 * number2;
        }

        private void machtsVerheffingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                resultLabel.Text = multiplay(int.Parse(numberOneTextBox.Text),int.Parse(numberOneTextBox.Text)).ToString();
                numberOneTextBox.Text = "";
                numberTwoTextBox.Text = "";
            }
            catch
            {
                resultLabel.Text = "Error";
            }

        }
    }
}
