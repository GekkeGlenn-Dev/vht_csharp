using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpdrachtFive
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nameCheckerBtn_Click(object sender, EventArgs e)
        {
            string name;
            do
            {
                InputForm popup = new InputForm();
                popup.ShowDialog();
                name = popup.input;
            } while (name != "Glenn");
        }
    }
}
