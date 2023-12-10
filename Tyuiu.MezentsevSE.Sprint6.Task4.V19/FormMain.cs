using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MezentsevSE.Sprint6.Task4.V19.Lib;
using System.IO;

namespace Tyuiu.MezentsevSE.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            buttonDone_MSE.BackColor = Color.AliceBlue;
            try
            {
                int start = Convert.ToInt32(textBoxStart_MSE.Text);
                int stop = Convert.ToInt32(textBoxStop_MSE.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chartFunc_MSE.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunc_MSE.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxDone_MSE.Text = "";

                chartFunc_MSE.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunc_MSE.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxDone_MSE.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonSave_MSE.BackColor = Color.AliceBlue;
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V19.txt";
                File.WriteAllText(path, textBoxDone_MSE.Text);
                DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogres == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            buttonInfo_MSE.BackColor = Color.AliceBlue;
            {
                MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-2 Мезенцев Семён Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
