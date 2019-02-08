using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClickerVersionTwo
{
    public partial class MainForm : Form
    {
        public ulong cookiePoints;

        public MainForm()
        {
            InitializeComponent();
        }

        private void increaseCookiesButton_Click(object sender, EventArgs e)
        {
            cookiePoints++;
            totalPoints.Text = cookiePoints.ToString();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.ShowDialog();
        }
    }
}
