using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MezentsevSE.Sprint6.Task1.V13.Lib;
namespace Tyuiu.MezentsevSE.Sprint6.Task1.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResult_MSE_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_MSE.Text);
                int stopValue = Convert.ToInt32(textBoxFinish_MSE.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_MSE.Text = "";
                textBoxResult_MSE.AppendText("+--------+--------------+" + Environment.NewLine);
                textBoxResult_MSE.AppendText("|    X   |    f(x)      |" + Environment.NewLine);
                textBoxResult_MSE.AppendText("+--------+--------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1,  6:f2}      |", startValue, valueArray[i]);
                    textBoxResult_MSE.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_MSE.AppendText("+--------+--------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_MSE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, Выполнил студент группы ИИПб-23-2 Мезенцев Семён Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

