using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.ShananinaVV.Sprint6.Task6.V2.Lib;

namespace Tyuiu.ShananinaVV.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //buttonDone_SVV.Enabled = false;
        }
        string openFilePath;
        DataService ds = new DataService();
      
        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            
            textBoxResult_SVV.Text = ds.CollectTextFromFile(openFilePath);
            
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SVV_Click(object sender, EventArgs e)
        {
            
            openFileDialogTask_SVV.ShowDialog();
            openFilePath = openFileDialogTask_SVV.FileName;
            textBoxVvod_SVV.Text = File.ReadAllText(openFilePath);
            groupBoxVvod_SVV.Text = groupBoxVvod_SVV.Text + " " + openFileDialogTask_SVV.FileName;
            buttonDone_SVV.Enabled = true;
        }
    }
}