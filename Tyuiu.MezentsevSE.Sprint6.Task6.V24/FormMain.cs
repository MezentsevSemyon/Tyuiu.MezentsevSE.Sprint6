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
using Tyuiu.MezentsevSE.Sprint6.Task6.V24.Lib;

namespace Tyuiu.MezentsevSE.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_MSE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MSE.ShowDialog();
            openFilePath = openFileDialogTask_MSE.FileName;
            textBoxEnter_MSE.Text = File.ReadAllText(openFilePath);
            groupBoxEnter_MSE.Text = groupBoxEnter_MSE.Text + " " + openFileDialogTask_MSE.FileName;
            buttonDone_MSE.Enabled = true;
        }

        private void buttonDone_MSE_Click(object sender, EventArgs e)
        {
            string str = " ";
            textBoxResult_MSE.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_MSE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        
    }
}
