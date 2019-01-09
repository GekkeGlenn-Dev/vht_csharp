using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtThree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oddOrEven;
            try { 
                oddOrEven = int.Parse(textBox1.Text);
            } catch
            {
                oddOrEven = 0;
            }
            int sum = oddOrEven % 2;
            if (sum == 0)
            {
                MessageBox.Show("u are safe");
            }
            else
            {
                MessageBox.Show("Input is True. Start the world destruction in 3.");
                MessageBox.Show("2.");
                MessageBox.Show("1.");
                MessageBox.Show("0.");
                Resources.Picture Form2 = new Resources.Picture();
                Form2.Show();
            }
        }
    }
}
