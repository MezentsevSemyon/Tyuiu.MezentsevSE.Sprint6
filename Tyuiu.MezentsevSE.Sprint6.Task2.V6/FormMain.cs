using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MezentsevSE.Sprint6.Task2.V6.Lib;

namespace Tyuiu.MezentsevSE.Sprint6.Task2.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonRes_MSE_MouseEnter(object sender, EventArgs e)
        {
            buttonRes_MSE.BackColor = Color.Blue;
        }

        private void buttonRes_MSE_MouseLeave(object sender, EventArgs e)
        {
            buttonRes_MSE.BackColor = Color.Green;
        }

        private void buttonInfo_MSE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Мезенцев Семён Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataService ds = new DataService();
        private void buttonRes_MSE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_MSE.Text);
                int stopStep = Convert.ToInt32(textBoxStop_MSE.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MSE.Titles.Add("График функции");

                this.chartFunction_MSE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MSE.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MSE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_MSE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        

        
    }
}
    

