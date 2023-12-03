using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShananinaVV.Sprint6.Task3.V7.Lib;


namespace Tyuiu.ShananinaVV.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        int[,] matrix = new int[5, 5] {{ 31,  25,  -18,  12,   9 },
                                       {  6,  34,   -2,   2,  -18},
                                       { -5,   4,   27,   4,  -1 },
                                       {  4,  15,   34,  -6,  -10},
                                       {  0,   8,    5,  14,  -17} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SVV.ColumnCount = columns;
            dataGridViewMatrix_SVV.RowCount = rows;

            //задаем ширину столбцов
            for (int i = 0; i < columns; i++)
            {

                dataGridViewMatrix_SVV.Columns[i].Width = 30;
            }

            // заполняем сетку данными из массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SVV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonResult_SVV_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int rows = res.GetUpperBound(0) + 1;
            int coll = res.Length / rows;
            dataGridViewResult_SVV.ColumnCount = coll;
            dataGridViewResult_SVV.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridViewResult_SVV.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridViewResult_SVV.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСТНб-23-1 Шананина Валерия Викторовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


   

