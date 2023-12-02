using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShananinaVV.Sprint6.Task2.V21.Lib;

namespace Tyuiu.ShananinaVV.Sprint6.Task2.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SVV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SVV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SVV.Titles.Add(" y = cos(x) + cos(x) / (x + 2) - 3x ");

                this.chartFunction_SVV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_SVV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SVV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_SVV.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonDone_SVV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SVV.BackColor = Color.Red;
        }

        private void buttonDone_SVV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SVV.BackColor = Color.Green;
        }

        private void buttonDone_SVV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SVV.BackColor = Color.Blue;
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСТНб-23-1 Шананина Валерия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
