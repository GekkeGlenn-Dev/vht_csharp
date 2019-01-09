using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EindOpdracht
{
    public partial class MainForm : Form
    {
        public int balance;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openShopBtn_Click(object sender, EventArgs e)
        {
            Shop popup = new Shop();
            popup.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            balance = 100000;
            balanceLabel.Text = "Balance \n" + balance;
        }
    }
}
