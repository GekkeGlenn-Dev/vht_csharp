using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class CookieForm : Form
    {
        int count = 0;

        public CookieForm()
        {
            InitializeComponent();
        }

        //
        // Alle event-handlers zijn al gemaakt,
        // je hoeft er alleen nog maar code in te zetten!
        //

        private void incrementButton_Click(object sender, EventArgs e)
        {

            increase();
        }

        private void plusKey_Press(object sender, KeyPressEventArgs e)
        {
            // + toets
            increase();
        }

        private void pKey_Press(object sender, KeyPressEventArgs e)
        {
            // p toets
            increase();
            
        }

        private void iKey_Press(object sender, KeyPressEventArgs e)
        {
            // i toets
            increase();
        }

        private void qKey_Press(object sender, KeyPressEventArgs e)
        {
            // q toets
            increase();
        }

        private void greaterThanKey_Press(object sender, KeyPressEventArgs e)
        {
            // > toets
            increase();
        }

        private void increase()
        {
            if (bonusCheckBox.Checked)
            {
                count += 2;
                countLabel.Text = count.ToString();
            }
            else
            {
                count++;
                countLabel.Text = count.ToString();
            }

        }
    }
}
