using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShananinaVV.Sprint6.Task0.V29.Lib;

namespace Tyuiu.ShananinaVV.Sprint6.Task0.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SVV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SVV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_SVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;

            }
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСТНб-23-1 Шананина Валерия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
