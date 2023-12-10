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
using Tyuiu.MezentsevSE.Sprint6.Task7.V23.Lib;

namespace Tyuiu.MezentsevSE.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MSE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_MSE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|(*.*)";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_MSE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MSE.ShowDialog();
            openFilePath = openFileDialogTask_MSE.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_MSE.ColumnCount = columns;
            dataGridViewIn_MSE.RowCount = rows;
            dataGridViewOut_MSE.ColumnCount = columns;
            dataGridViewOut_MSE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_MSE.Columns[i].Width = 25;
                dataGridViewOut_MSE.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_MSE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_MSE.Enabled = true;
        }

        private void buttonHelp_MSE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_MSE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_MSE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_MSE.Enabled = true;
        }

        private void buttonSave_MSE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MSE.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MSE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MSE.ShowDialog();

            string path = saveFileDialogMatrix_MSE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_MSE.RowCount;
            int columns = dataGridViewOut_MSE.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_MSE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_MSE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        

        
    }
}
