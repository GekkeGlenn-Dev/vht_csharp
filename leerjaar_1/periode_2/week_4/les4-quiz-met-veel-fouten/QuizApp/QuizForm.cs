using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        string correctSongAnswer;

        public QuizForm()
        {
            InitializeComponent();

            // Stomme memes:
            // correctSongAnswer = "Bag Raiders";
            // TODO: ff een goed antwoord hier inzetten ipv Bag Raiders
        }

        private void checkAnswersButton_Click(object sender, EventArgs e)
        {
            int numGoodAnswers = 0;

            // Door zowel de invoer als het antwoord UpperCase te 
            // maken (volledig hoofdletters) maakt het niet uit
            // hoe de gebruik hoofdletters gebruikt in zijn of
            // haar antwoord.
            try
            { 
                if(songAnswerTextBox.Text.ToUpper() == correctSongAnswer.ToUpper())
                {
                    numGoodAnswers++;
                    MessageBox.Show("Je antwoord op vraag 1 is goed!");
                }
                else
                {
                    MessageBox.Show("Je antwoord op vraag 1 is fout :(");
                }
            } catch (NullReferenceException)
            {
                MessageBox.Show("Je antwoord op vraag 1 is niet ingevuld! En wordt dus fout gerekent :(");

            }
            // goeie antwoord is:
            //sonMemeRadioButton
            if (sonMemeRadioButton.Checked)
            {
                numGoodAnswers++;
                MessageBox.Show("Antwoord 2 is goed!");
            }
            else
            {
                MessageBox.Show("Antwoord 2 is helaas niet goed");
            }

            // Goeie antwoord is 10.15
            if((string)breakComboBox.SelectedItem == "10.15")
            {
                numGoodAnswers++;
                MessageBox.Show("Antwoord 3 is goed!");
            }
            else
            {
                MessageBox.Show("Antwoord 3 is niet goed ;(");
            }


            //try to check antwoord 4
            try
            {
                double calculateAnswer = double.Parse(calculateTextBox.Text);

                // Goeie antwoord is 2.5
                if (calculateAnswer == 2.5)
                {
                    numGoodAnswers++;
                    MessageBox.Show("Antwoord 4 is goed, netjes gedaan!");
                }
                else if (calculateAnswer > 2 && calculateAnswer < 3)
                {
                    MessageBox.Show("Antwoord 4 is niet goed, maar je zit in de goeie richting!");
                }
                else
                {
                    MessageBox.Show("Antwoord 4 is niet goed...");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Je antwoord op vraag 4 is niet ingevuld! En wordt dus fout gerekent :(");
            }

            // Deze methode staat onderaan dit bestand
            WriteCorrectAnswersToFile(numGoodAnswers);
        }

        private void forniteMemeRadioButton_MouseDown(object sender, MouseEventArgs e)
        {
            // Cheat-code: wanneer met de rechter muisknop op
            // het fortnite antwoord wordt geklikt moet dat
            // ingesteld worden als goede antwoord voor vraag
            // 1. Dan is "Fortnite" dus goed ipv "Bag Raiders"
            if (e.Button == MouseButtons.Right)
            {
                throw new NotImplementedException("Sorry ik was lui en had nog geen zin deze code te schrijven.");
            }
        }

        private void WriteCorrectAnswersToFile(int numGoodAnswers)
        {
            // WAWAHWAHWHAWHAWHAWHWA WAAAROM WERKT DIT NIET!?!?!?!
            // HET IS VEEL TE LAAT EN IK KAN NEIT UITVINDEN WAAROM DIT
            // BIJ MIJ WEL WERKT, MAAR BIJ MIJN MAAT OP ZIJN LAPTOP NIET!?!?!?
            // AAHAHHAHAHAHAHAHAHAHAH AHS DIHASF ASJFALSKGJ ASLKGASLGKHASG
            System.IO.File.WriteAllText(@"E:\test.txt", "Aantal goeie antwoorden: " + numGoodAnswers.ToString());
        }
    }
}
