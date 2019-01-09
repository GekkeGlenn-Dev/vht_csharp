using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CraftingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void greenBookPictureBox_Click(object sender, EventArgs e)
        {
            if(leftItemPictureBox.Image == null)
            {
                leftItemPictureBox.Image = Properties.Resources.GreenBook;
                leftItemPictureBox.Tag = "Green Book";
            }
            else
            {
                rightItemPictureBox.Image = Properties.Resources.GreenBook;
                rightItemPictureBox.Tag = "Green Book";
            }
        }

        private void blueBarryPictureBox_Click(object sender, EventArgs e)
        {
            if (leftItemPictureBox.Image == null)
            {
                leftItemPictureBox.Image = Properties.Resources.BlueBerry;
                leftItemPictureBox.Tag = "Blue Berry";
            }
            else
            {
                rightItemPictureBox.Image = Properties.Resources.BlueBerry;
                rightItemPictureBox.Tag = "Blue Berry";
            }
        }

        private void clearPotionPictureBox_Click(object sender, EventArgs e)
        {

            if (leftItemPictureBox.Image == null)
            {
                leftItemPictureBox.Image = Properties.Resources.ClearPotion;
                leftItemPictureBox.Tag = "Clear Potion";
            }
            else
            {
                rightItemPictureBox.Image = Properties.Resources.ClearPotion;
                rightItemPictureBox.Tag = "Clear Potion";
            }
        }

        private void redGemPictureBox_Click(object sender, EventArgs e)
        {

            if (leftItemPictureBox.Image == null)
            {
                leftItemPictureBox.Image = Properties.Resources.RedGem;
                leftItemPictureBox.Tag = "Red Gem";
            }
            else
            {
                rightItemPictureBox.Image = Properties.Resources.RedGem;
                rightItemPictureBox.Tag = "Red Gem";
            }
        }

        private void plainShirtPictureBox_Click(object sender, EventArgs e)
        {

            if (leftItemPictureBox.Image == null)
            {
                leftItemPictureBox.Image = Properties.Resources.PlainShirt;
                leftItemPictureBox.Tag = "Plain Shirt";
            }
            else
            {
                rightItemPictureBox.Image = Properties.Resources.PlainShirt;
                rightItemPictureBox.Tag = "Plain Shirt";
            }

        }

        private void craftButton_Click(object sender, EventArgs e)
        {
            string leftItem = (string)leftItemPictureBox.Tag;
            string rightItem = (string)rightItemPictureBox.Tag;

            if (leftItem == "Blue Berry" && rightItem == "Green Book"
                || rightItem == "Blue Berry" && leftItem == "Green Book")
            {
                resultItemPictureBox.Image = Properties.Resources.BlueBook;
                leftItemPictureBox.Image = null;
                rightItemPictureBox.Image = null;

            }
            else if (leftItem == "Clear Potion" && rightItem == "Red Gem"
                || leftItem == "Red Gem" && rightItem == "Clear Potion")
            {
                resultItemPictureBox.Image = Properties.Resources.RedPotion;
                leftItemPictureBox.Image = null;
                rightItemPictureBox.Image = null;
            }
            else if (leftItem == "Blue Berry" && rightItem == "Plain Shirt"
                || leftItem == "Plain Shirt" && rightItem == "Blue Berry")
            {
                resultItemPictureBox.Image = Properties.Resources.PurpleShirt;
                leftItemPictureBox.Image = null;
                rightItemPictureBox.Image = null;
            }
        }
    }
}
