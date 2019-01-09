using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenen
{
    public partial class MainForm : Form
    {
        int left;
        int right;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            left = int.Parse(InputLeftBox.Text);
            right = int.Parse(InputRightBox.Text);
            int sum = left + right;

            // De tekst \r\n geeft een nieuwe regel aan op Windows.
            // Voer het programma een keer uit met en een keer zonder \r\n hieronder
            ResultBox.Text += "De optelsom van " + left + " en " + right + " is " + sum + "\r\n";
        }
    }
}
