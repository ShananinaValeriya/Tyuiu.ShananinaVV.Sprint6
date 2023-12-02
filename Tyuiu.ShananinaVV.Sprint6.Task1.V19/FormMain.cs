using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShananinaVV.Sprint6.Task1.V19.Lib;


namespace Tyuiu.ShananinaVV.Sprint6.Task1.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonGet_SVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SVV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SVV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_SVV.Text = "";
                textBoxResult_SVV.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_SVV.AppendText("|    X     |    F(x)    |" + Environment.NewLine);
                textBoxResult_SVV.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}    | ", startStep, valueArray[i]);
                    textBoxResult_SVV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_SVV.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИСТНб-23-1 Шананина Валерия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
