using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuiswerkP2L3
{
    public partial class QuizeForm : Form
    {
        public QuizeForm()
        {
            InitializeComponent();
        }

        private void answersCheckBox_Click(object sender, EventArgs e)
        {
            if(questionOneAnswerBox.Text.ToLower() == "glenn")
            {
                MessageBox.Show("Antwoordt 1 is goed");
            }
            else
            {
                MessageBox.Show("ÄNtwoord 1 is fout");
            }

            if (timBtn.Checked || bartBtn.Checked)
            {
                MessageBox.Show("jou 2de antwoord was goed");
            }
            else
            {
                MessageBox.Show("2 IS FOUT");
            }
            if(questionThreeComboBox.Text == "super leuk" || questionThreeComboBox.Text == "Antwoord staat er niet bij")
            {
                MessageBox.Show("Je hebt helemaal gelijk bij vraag 3 ;)");
            }
            else
            {
                MessageBox.Show("3 is fout, Wat jammer ");
            }
        }
    }
}
