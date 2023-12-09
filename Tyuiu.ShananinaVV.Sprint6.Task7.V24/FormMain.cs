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

using Tyuiu.ShananinaVV.Sprint6.Task7.V24.Lib;

namespace Tyuiu.ShananinaVV.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SVV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SVV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|(*.*)";
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

        private void buttonOpenFile_SVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SVV.ShowDialog();
            openFilePath = openFileDialogTask_SVV.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_SVV.ColumnCount = columns;
            dataGridViewIn_SVV.RowCount = rows;
            dataGridViewOut_SVV.ColumnCount = columns;
            dataGridViewOut_SVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_SVV.Columns[i].Width = 25;
                dataGridViewOut_SVV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_SVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SVV.Enabled = true;
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_SVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_SVV.Enabled = true;
        }

        private void buttonSave_SVV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SVV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SVV.ShowDialog();

            string path = saveFileDialogMatrix_SVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_SVV.RowCount;
            int columns = dataGridViewOut_SVV.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_SVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_SVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpenFile_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVV.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVV.ToolTipTitle = "Сохранить";
        }

        private void buttonHelp_SVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SVV.ToolTipTitle = "Справка";
        }
    }
}
