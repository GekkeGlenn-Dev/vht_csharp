using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstLetterApp
{
    public partial class FindFirstLetterForm : Form
    {
        public FindFirstLetterForm()
        {
            InitializeComponent();
        }

        private void findFirstLetterButton_Click(object sender, EventArgs e)
        {
            // TODO: Show only the first letter of the name in the textbox
            char firstLetterOfName = new char[1];
             try
            {
                MessageBox.Show(nameTextBox.Text[0].ToString());
                MessageBox.Show(nameTextBox.Text[1].ToString());
                MessageBox.Show(nameTextBox.Text[2].ToString());
                MessageBox.Show(nameTextBox.Text[3].ToString());
                MessageBox.Show(nameTextBox.Text[4].ToString());

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("te lange naam");
            }
        }
    }
}
