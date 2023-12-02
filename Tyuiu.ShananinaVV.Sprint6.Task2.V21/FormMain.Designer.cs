
namespace Tyuiu.ShananinaVV.Sprint6.Task2.V21
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask2_SVV = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SVV = new System.Windows.Forms.PictureBox();
            this.textBoxUslovie_SVV = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SVV = new System.Windows.Forms.GroupBox();
            this.chartFunction_SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_SVV = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_SVV = new System.Windows.Forms.Label();
            this.groupBoxDone_SVV = new System.Windows.Forms.GroupBox();
            this.labelVarStop_SVV = new System.Windows.Forms.Label();
            this.labelVarStart_SVV = new System.Windows.Forms.Label();
            this.textBoxStop_SVV = new System.Windows.Forms.TextBox();
            this.textBoxStart_SVV = new System.Windows.Forms.TextBox();
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.groupBoxTask2_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SVV)).BeginInit();
            this.groupBoxResult_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SVV)).BeginInit();
            this.groupBoxDone_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask2_SVV
            // 
            this.groupBoxTask2_SVV.Controls.Add(this.pictureBoxFormula_SVV);
            this.groupBoxTask2_SVV.Controls.Add(this.textBoxUslovie_SVV);
            this.groupBoxTask2_SVV.Location = new System.Drawing.Point(9, 12);
            this.groupBoxTask2_SVV.Name = "groupBoxTask2_SVV";
            this.groupBoxTask2_SVV.Size = new System.Drawing.Size(578, 264);
            this.groupBoxTask2_SVV.TabIndex = 0;
            this.groupBoxTask2_SVV.TabStop = false;
            this.groupBoxTask2_SVV.Text = "Условие";
            // 
            // pictureBoxFormula_SVV
            // 
            this.pictureBoxFormula_SVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SVV.Image")));
            this.pictureBoxFormula_SVV.Location = new System.Drawing.Point(15, 130);
            this.pictureBoxFormula_SVV.Name = "pictureBoxFormula_SVV";
            this.pictureBoxFormula_SVV.Size = new System.Drawing.Size(313, 39);
            this.pictureBoxFormula_SVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_SVV.TabIndex = 1;
            this.pictureBoxFormula_SVV.TabStop = false;
            // 
            // textBoxUslovie_SVV
            // 
            this.textBoxUslovie_SVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_SVV.Location = new System.Drawing.Point(15, 23);
            this.textBoxUslovie_SVV.Multiline = true;
            this.textBoxUslovie_SVV.Name = "textBoxUslovie_SVV";
            this.textBoxUslovie_SVV.ReadOnly = true;
            this.textBoxUslovie_SVV.Size = new System.Drawing.Size(551, 238);
            this.textBoxUslovie_SVV.TabIndex = 0;
            this.textBoxUslovie_SVV.Text = resources.GetString("textBoxUslovie_SVV.Text");
            // 
            // groupBoxResult_SVV
            // 
            this.groupBoxResult_SVV.Controls.Add(this.chartFunction_SVV);
            this.groupBoxResult_SVV.Controls.Add(this.dataGridViewFunction_SVV);
            this.groupBoxResult_SVV.Controls.Add(this.labelResult_SVV);
            this.groupBoxResult_SVV.Location = new System.Drawing.Point(593, 12);
            this.groupBoxResult_SVV.Name = "groupBoxResult_SVV";
            this.groupBoxResult_SVV.Size = new System.Drawing.Size(691, 355);
            this.groupBoxResult_SVV.TabIndex = 1;
            this.groupBoxResult_SVV.TabStop = false;
            this.groupBoxResult_SVV.Text = "Вывод данных";
            // 
            // chartFunction_SVV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SVV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SVV.Legends.Add(legend1);
            this.chartFunction_SVV.Location = new System.Drawing.Point(199, 48);
            this.chartFunction_SVV.Name = "chartFunction_SVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SVV.Series.Add(series1);
            this.chartFunction_SVV.Size = new System.Drawing.Size(480, 296);
            this.chartFunction_SVV.TabIndex = 3;
            this.chartFunction_SVV.Text = "chart1";
            // 
            // dataGridViewFunction_SVV
            // 
            this.dataGridViewFunction_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SVV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_SVV.Location = new System.Drawing.Point(15, 48);
            this.dataGridViewFunction_SVV.Name = "dataGridViewFunction_SVV";
            this.dataGridViewFunction_SVV.RowHeadersVisible = false;
            this.dataGridViewFunction_SVV.RowHeadersWidth = 51;
            this.dataGridViewFunction_SVV.RowTemplate.Height = 24;
            this.dataGridViewFunction_SVV.Size = new System.Drawing.Size(162, 296);
            this.dataGridViewFunction_SVV.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 70;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 70;
            // 
            // labelResult_SVV
            // 
            this.labelResult_SVV.AutoSize = true;
            this.labelResult_SVV.Location = new System.Drawing.Point(12, 23);
            this.labelResult_SVV.Name = "labelResult_SVV";
            this.labelResult_SVV.Size = new System.Drawing.Size(84, 18);
            this.labelResult_SVV.TabIndex = 1;
            this.labelResult_SVV.Text = "Результат:";
            // 
            // groupBoxDone_SVV
            // 
            this.groupBoxDone_SVV.Controls.Add(this.labelVarStop_SVV);
            this.groupBoxDone_SVV.Controls.Add(this.labelVarStart_SVV);
            this.groupBoxDone_SVV.Controls.Add(this.textBoxStop_SVV);
            this.groupBoxDone_SVV.Controls.Add(this.textBoxStart_SVV);
            this.groupBoxDone_SVV.Location = new System.Drawing.Point(9, 282);
            this.groupBoxDone_SVV.Name = "groupBoxDone_SVV";
            this.groupBoxDone_SVV.Size = new System.Drawing.Size(289, 93);
            this.groupBoxDone_SVV.TabIndex = 2;
            this.groupBoxDone_SVV.TabStop = false;
            this.groupBoxDone_SVV.Text = "Ввод данных";
            // 
            // labelVarStop_SVV
            // 
            this.labelVarStop_SVV.AutoSize = true;
            this.labelVarStop_SVV.Location = new System.Drawing.Point(147, 29);
            this.labelVarStop_SVV.Name = "labelVarStop_SVV";
            this.labelVarStop_SVV.Size = new System.Drawing.Size(92, 18);
            this.labelVarStop_SVV.TabIndex = 3;
            this.labelVarStop_SVV.Text = "Конец шага:";
            // 
            // labelVarStart_SVV
            // 
            this.labelVarStart_SVV.AutoSize = true;
            this.labelVarStart_SVV.Location = new System.Drawing.Point(12, 29);
            this.labelVarStart_SVV.Name = "labelVarStart_SVV";
            this.labelVarStart_SVV.Size = new System.Drawing.Size(90, 18);
            this.labelVarStart_SVV.TabIndex = 2;
            this.labelVarStart_SVV.Text = "Старт шага:";
            // 
            // textBoxStop_SVV
            // 
            this.textBoxStop_SVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStop_SVV.Location = new System.Drawing.Point(150, 50);
            this.textBoxStop_SVV.Name = "textBoxStop_SVV";
            this.textBoxStop_SVV.Size = new System.Drawing.Size(112, 24);
            this.textBoxStop_SVV.TabIndex = 1;
            this.textBoxStop_SVV.Text = "5";
            // 
            // textBoxStart_SVV
            // 
            this.textBoxStart_SVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStart_SVV.Location = new System.Drawing.Point(15, 50);
            this.textBoxStart_SVV.Name = "textBoxStart_SVV";
            this.textBoxStart_SVV.Size = new System.Drawing.Size(116, 24);
            this.textBoxStart_SVV.TabIndex = 0;
            this.textBoxStart_SVV.Text = "-5";
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SVV.Location = new System.Drawing.Point(304, 295);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(101, 72);
            this.buttonHelp_SVV.TabIndex = 3;
            this.buttonHelp_SVV.Text = "Справка";
            this.buttonHelp_SVV.UseVisualStyleBackColor = false;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SVV.Location = new System.Drawing.Point(411, 295);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(173, 72);
            this.buttonDone_SVV.TabIndex = 4;
            this.buttonDone_SVV.Text = "Выполнить";
            this.buttonDone_SVV.UseVisualStyleBackColor = false;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            this.buttonDone_SVV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SVV_MouseDown);
            this.buttonDone_SVV.MouseEnter += new System.EventHandler(this.buttonDone_SVV_MouseEnter);
            this.buttonDone_SVV.MouseLeave += new System.EventHandler(this.buttonDone_SVV_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 387);
            this.Controls.Add(this.buttonDone_SVV);
            this.Controls.Add(this.buttonHelp_SVV);
            this.Controls.Add(this.groupBoxDone_SVV);
            this.Controls.Add(this.groupBoxResult_SVV);
            this.Controls.Add(this.groupBoxTask2_SVV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 21 | Шананина В.В.";
            this.groupBoxTask2_SVV.ResumeLayout(false);
            this.groupBoxTask2_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SVV)).EndInit();
            this.groupBoxResult_SVV.ResumeLayout(false);
            this.groupBoxResult_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SVV)).EndInit();
            this.groupBoxDone_SVV.ResumeLayout(false);
            this.groupBoxDone_SVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask2_SVV;
        private System.Windows.Forms.TextBox textBoxUslovie_SVV;
        private System.Windows.Forms.GroupBox groupBoxResult_SVV;
        private System.Windows.Forms.Label labelResult_SVV;
        private System.Windows.Forms.GroupBox groupBoxDone_SVV;
        private System.Windows.Forms.Label labelVarStop_SVV;
        private System.Windows.Forms.Label labelVarStart_SVV;
        private System.Windows.Forms.TextBox textBoxStop_SVV;
        private System.Windows.Forms.TextBox textBoxStart_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVV;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SVV;
    }
}

