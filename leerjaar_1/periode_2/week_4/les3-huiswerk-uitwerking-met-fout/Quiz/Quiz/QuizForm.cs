using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class QuizForm : Form
    {
        public QuizForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Vraag 1
            if(songTextBox.Text.ToLower() == "bag raiders")
            {
                MessageBox.Show("Vraag 1 had je goed!");
            }
            else
            {
                MessageBox.Show("Vraag 1 is fout! Shooting stars is van: Bag Raiders");
            }

            // Vraag 2
            if (fortniteRadioButton.Checked)
            {
                MessageBox.Show("Vraag 2 had je goed!");
            }
            else
            {
                MessageBox.Show("Vraag 2 is fout! De leukste meme's hebben met Fortnite te maken");
            }

            // Vraag 3 (als je niks unvult geeft de volgende regel een NullReferenceException)
            // Omdat 'teacherAnswerComboBox.SelectedItem' null is, kan dit niet .ToString() gedaan worden
            // het is namelijk NIETS: null.
            try
            {
                if (teacherAnswerComboBox.SelectedItem.ToString() == "Tim Lutt")
                {
                    MessageBox.Show("Vraag 3 had je goed!");
                }
                else
                {
                    MessageBox.Show("Vraag 3 is fout! De leukste docent is natuurlijk Tim :D");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("je hebt niks gekozen bij vraag 3");
            }

            // Vraag 4
            try
            {
                if (int.Parse(sumAnswerTextBox.Text) == 101)
                {
                    MessageBox.Show("Vraag 4 had je goed!");
                }
                else
                {
                    MessageBox.Show("Vraag 4 is fout! 3 + 98 = 101, ga voor eventuele bijles naar Ine ;)");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Sorry, je hebt bij vraag 4 geen geldig antwoord gegeven. Zorg dat het een getal is !");
            }
        }
    }
}