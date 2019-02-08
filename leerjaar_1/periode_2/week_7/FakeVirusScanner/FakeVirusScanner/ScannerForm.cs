using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeVirusScanner
{
    public partial class ScannerForm : Form
    {
        public ScannerForm()
        {
            InitializeComponent();
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            scanFolder(folderTextBox.Text);
        }

        private void scanFolder(string folderToScan)
        {
            try
            {
                string[] filesInFolder = Directory.GetFiles(folderToScan);
                foreach (string fileName in filesInFolder)
                {
                    scanFile(fileName);
                }

                string[] foldersInFolder = Directory.GetDirectories(folderToScan);
                foreach (string subFolder in foldersInFolder)
                {
                    scanFolder(subFolder);
                }
            }
            catch (Exception)
            {
                scannedFolderListBox.Items.Add(folderToScan + " could not be scanned! Try running this application as administrator.");
            }
        }

        private void scanFile(string fileName)
        {
            if (isFileVirus(fileName))
            {
                scannedFolderListBox.Items.Add(fileName + " is infected");
            }
            else
            {
                scannedFolderListBox.Items.Add(fileName + " is not infected");
            }
        }

        private bool isFileVirus(string fileName)
        {
            // TODO: Actually scan for virus
            return false;
        }
    }
}
