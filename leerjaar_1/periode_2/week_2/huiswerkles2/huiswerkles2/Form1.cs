using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace huiswerkles2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            //name check
            if (name == (string)"Glenn")
            {
                name = "CRAZY";
            }
            else if (name == "Bart")
            {
                name = "een <br> user O_O";
            }
            else if (name == "Tim")
            {
                name = "Waar is je baard gebleven?!";
            }
            else
            {
                nameOutputLabel.Text = "uw naam is " + name;
            }
        }

        private void leeftijdBox_TextChanged(object sender, EventArgs e)
        {
            int leeftijdOut = int.Parse(leeftijdBox.Text);

            //if statmunt voor leeftijd check

            if (leeftijdBox.Text == "")
            {

            }
            else
            {
                if (leeftijdOut >= 100)
                {
                    leeftijdOutputLabel.Text = "als jij ouder bent dan " + leeftijdOut.ToString() + " is dat heel knap !!";
                }
                else if (leeftijdOut >= 18)
                {
                    leeftijdOutputLabel.Text = "Je mag drank drinken en auto rijden (" + leeftijdOut.ToString() + ")";
                }
                else if (leeftijdOut <= 0)
                {
                    leeftijdOutputLabel.Text = "Error";
                }
                else
                {
                    leeftijdOutputLabel.Text = "Je bent " + leeftijdOut.ToString() + " jaar oud";
                }
            }
            
        }

        private void bankAmoutbox_TextChanged(object sender, EventArgs e)
        {
            double bankOut = double.Parse(bankAmoutbox.Text);

            //if statmunt voor bank amount check
            if (bankAmoutbox.Text == "")
            {

            }
            else
            {
                if (bankOut >= 100)
                {
                    bankAmountOutputLabel.Text = "Waw je hebt meer dan € " + bankOut.ToString() + " op je bank";
                }
                else if (bankOut >= 10000)
                {
                    bankAmountOutputLabel.Text = "Waw je hebt meer dan € " + bankOut.ToString() + " op je bank";
                }
                else if (bankOut >= 1000000)
                {
                    bankAmountOutputLabel.Text = "Super gaaf je bent Miljoenair !";
                }
                else if (bankOut >= 1000000000)
                {
                    bankAmountOutputLabel.Text = "Wou doe ik echt niet NAAR!";
                }
                else if (bankOut >= 10000000000)
                {
                    bankAmountOutputLabel.Text = "Je liegt niemand heeft dat op dit moment!";
                }
                else
                {
                    bankAmountOutputLabel.Text = "Je hebt " + bankOut.ToString() + " euro op je bankrekening";
                }
            }
        }

        private void walletAmountBox_TextChanged(object sender, EventArgs e)
        {
            double WalletOut = double.Parse(walletAmountBox.Text);


            //if statmunt voor wallet amount check
            if (walletAmountBox.Text == "")
            {

            }
            else
            {
                if (WalletOut >= 100)
                {
                    walletAmountOutputLabel.Text = "Waarom heb je € " + WalletOut.ToString() + " bij?";
                }
                else if (WalletOut >= 10000)
                {
                    walletAmountOutputLabel.Text = "Ik hoop dat je niet wordt overvallen!";
                }
                else if (WalletOut >= 1000000)
                {
                    walletAmountOutputLabel.Text = "Is niet erg slim";
                    }
                    else if (WalletOut >= 1000000000)
                    {
                        walletAmountOutputLabel.Text = "Waar laat je dat in je broek?";
                    }
                    else if (WalletOut >= 10000000000)
                    {
                        walletAmountOutputLabel.Text = "Je liegt niemand heeft dat op dit moment!";
                    }
                    else
                    {
                        leeftijdOutputLabel.Text = "Je bent " + walletAmountOutputLabel.ToString() + " jaar oud";
                    }
                }
            }
    }
}
