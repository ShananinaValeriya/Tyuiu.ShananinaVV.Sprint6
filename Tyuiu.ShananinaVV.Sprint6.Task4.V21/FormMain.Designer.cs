
namespace Tyuiu.ShananinaVV.Sprint6.Task4.V21
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelOne_SVV = new System.Windows.Forms.Panel();
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.buttonSave_SVV = new System.Windows.Forms.Button();
            this.groupBoxDano_SVV = new System.Windows.Forms.GroupBox();
            this.labelStop_SVV = new System.Windows.Forms.Label();
            this.labelStart_SVV = new System.Windows.Forms.Label();
            this.textBoxStop_SVV = new System.Windows.Forms.TextBox();
            this.textBoxStart_SVV = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_SVV = new System.Windows.Forms.GroupBox();
            this.pictureBoxForm_SVV = new System.Windows.Forms.PictureBox();
            this.textBoxDone_SVV = new System.Windows.Forms.TextBox();
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.panelTwo_SVV = new System.Windows.Forms.Panel();
            this.groupBoxOne_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SVV = new System.Windows.Forms.TextBox();
            this.panelThree_SVV = new System.Windows.Forms.Panel();
            this.chartFunction_SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOne_SVV = new System.Windows.Forms.Splitter();
            this.panelOne_SVV.SuspendLayout();
            this.groupBoxDano_SVV.SuspendLayout();
            this.groupBoxUslovie_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SVV)).BeginInit();
            this.panelTwo_SVV.SuspendLayout();
            this.groupBoxOne_SVV.SuspendLayout();
            this.panelThree_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_SVV
            // 
            this.panelOne_SVV.Controls.Add(this.buttonDone_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonSave_SVV);
            this.panelOne_SVV.Controls.Add(this.groupBoxDano_SVV);
            this.panelOne_SVV.Controls.Add(this.groupBoxUslovie_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonHelp_SVV);
            this.panelOne_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOne_SVV.Name = "panelOne_SVV";
            this.panelOne_SVV.Size = new System.Drawing.Size(1197, 183);
            this.panelOne_SVV.TabIndex = 0;
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SVV.Location = new System.Drawing.Point(869, 17);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(101, 69);
            this.buttonDone_SVV.TabIndex = 1;
            this.buttonDone_SVV.Text = "Выполнить";
            this.buttonDone_SVV.UseVisualStyleBackColor = false;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            // 
            // buttonSave_SVV
            // 
            this.buttonSave_SVV.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave_SVV.Location = new System.Drawing.Point(976, 17);
            this.buttonSave_SVV.Name = "buttonSave_SVV";
            this.buttonSave_SVV.Size = new System.Drawing.Size(100, 69);
            this.buttonSave_SVV.TabIndex = 1;
            this.buttonSave_SVV.Text = "Сохранить";
            this.buttonSave_SVV.UseVisualStyleBackColor = false;
            this.buttonSave_SVV.Click += new System.EventHandler(this.buttonSave_SVV_Click);
            // 
            // groupBoxDano_SVV
            // 
            this.groupBoxDano_SVV.Controls.Add(this.labelStop_SVV);
            this.groupBoxDano_SVV.Controls.Add(this.labelStart_SVV);
            this.groupBoxDano_SVV.Controls.Add(this.textBoxStop_SVV);
            this.groupBoxDano_SVV.Controls.Add(this.textBoxStart_SVV);
            this.groupBoxDano_SVV.Location = new System.Drawing.Point(575, 10);
            this.groupBoxDano_SVV.Name = "groupBoxDano_SVV";
            this.groupBoxDano_SVV.Size = new System.Drawing.Size(288, 163);
            this.groupBoxDano_SVV.TabIndex = 2;
            this.groupBoxDano_SVV.TabStop = false;
            this.groupBoxDano_SVV.Text = "Ввод данных";
            // 
            // labelStop_SVV
            // 
            this.labelStop_SVV.AutoSize = true;
            this.labelStop_SVV.Location = new System.Drawing.Point(148, 18);
            this.labelStop_SVV.Name = "labelStop_SVV";
            this.labelStop_SVV.Size = new System.Drawing.Size(89, 17);
            this.labelStop_SVV.TabIndex = 3;
            this.labelStop_SVV.Text = "Конец шага:";
            // 
            // labelStart_SVV
            // 
            this.labelStart_SVV.AutoSize = true;
            this.labelStart_SVV.Location = new System.Drawing.Point(6, 18);
            this.labelStart_SVV.Name = "labelStart_SVV";
            this.labelStart_SVV.Size = new System.Drawing.Size(87, 17);
            this.labelStart_SVV.TabIndex = 2;
            this.labelStart_SVV.Text = "Старт шага:";
            // 
            // textBoxStop_SVV
            // 
            this.textBoxStop_SVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStop_SVV.Location = new System.Drawing.Point(151, 38);
            this.textBoxStop_SVV.Name = "textBoxStop_SVV";
            this.textBoxStop_SVV.Size = new System.Drawing.Size(126, 22);
            this.textBoxStop_SVV.TabIndex = 1;
            this.textBoxStop_SVV.Text = "5";
            // 
            // textBoxStart_SVV
            // 
            this.textBoxStart_SVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStart_SVV.Location = new System.Drawing.Point(9, 38);
            this.textBoxStart_SVV.Name = "textBoxStart_SVV";
            this.textBoxStart_SVV.Size = new System.Drawing.Size(136, 22);
            this.textBoxStart_SVV.TabIndex = 0;
            this.textBoxStart_SVV.Text = "-5";
            // 
            // groupBoxUslovie_SVV
            // 
            this.groupBoxUslovie_SVV.Controls.Add(this.pictureBoxForm_SVV);
            this.groupBoxUslovie_SVV.Controls.Add(this.textBoxDone_SVV);
            this.groupBoxUslovie_SVV.Location = new System.Drawing.Point(7, 10);
            this.groupBoxUslovie_SVV.Name = "groupBoxUslovie_SVV";
            this.groupBoxUslovie_SVV.Size = new System.Drawing.Size(562, 163);
            this.groupBoxUslovie_SVV.TabIndex = 1;
            this.groupBoxUslovie_SVV.TabStop = false;
            this.groupBoxUslovie_SVV.Text = "Условие:";
            // 
            // pictureBoxForm_SVV
            // 
            this.pictureBoxForm_SVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm_SVV.Image")));
            this.pictureBoxForm_SVV.Location = new System.Drawing.Point(5, 104);
            this.pictureBoxForm_SVV.Name = "pictureBoxForm_SVV";
            this.pictureBoxForm_SVV.Size = new System.Drawing.Size(347, 40);
            this.pictureBoxForm_SVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxForm_SVV.TabIndex = 3;
            this.pictureBoxForm_SVV.TabStop = false;
            // 
            // textBoxDone_SVV
            // 
            this.textBoxDone_SVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDone_SVV.Location = new System.Drawing.Point(5, 21);
            this.textBoxDone_SVV.Multiline = true;
            this.textBoxDone_SVV.Name = "textBoxDone_SVV";
            this.textBoxDone_SVV.ReadOnly = true;
            this.textBoxDone_SVV.Size = new System.Drawing.Size(551, 77);
            this.textBoxDone_SVV.TabIndex = 0;
            this.textBoxDone_SVV.Text = resources.GetString("textBoxDone_SVV.Text");
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SVV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SVV.Location = new System.Drawing.Point(1086, 17);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(99, 69);
            this.buttonHelp_SVV.TabIndex = 0;
            this.buttonHelp_SVV.Text = "Справка";
            this.buttonHelp_SVV.UseVisualStyleBackColor = false;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // panelTwo_SVV
            // 
            this.panelTwo_SVV.Controls.Add(this.groupBoxOne_SVV);
            this.panelTwo_SVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTwo_SVV.Location = new System.Drawing.Point(0, 183);
            this.panelTwo_SVV.Name = "panelTwo_SVV";
            this.panelTwo_SVV.Size = new System.Drawing.Size(200, 437);
            this.panelTwo_SVV.TabIndex = 0;
            // 
            // groupBoxOne_SVV
            // 
            this.groupBoxOne_SVV.Controls.Add(this.textBoxResult_SVV);
            this.groupBoxOne_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOne_SVV.Name = "groupBoxOne_SVV";
            this.groupBoxOne_SVV.Size = new System.Drawing.Size(200, 437);
            this.groupBoxOne_SVV.TabIndex = 0;
            this.groupBoxOne_SVV.TabStop = false;
            this.groupBoxOne_SVV.Text = "Вывод:";
            // 
            // textBoxResult_SVV
            // 
            this.textBoxResult_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SVV.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_SVV.Multiline = true;
            this.textBoxResult_SVV.Name = "textBoxResult_SVV";
            this.textBoxResult_SVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SVV.Size = new System.Drawing.Size(194, 416);
            this.textBoxResult_SVV.TabIndex = 0;
            // 
            // panelThree_SVV
            // 
            this.panelThree_SVV.Controls.Add(this.chartFunction_SVV);
            this.panelThree_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThree_SVV.Location = new System.Drawing.Point(200, 183);
            this.panelThree_SVV.Name = "panelThree_SVV";
            this.panelThree_SVV.Size = new System.Drawing.Size(997, 437);
            this.panelThree_SVV.TabIndex = 0;
            // 
            // chartFunction_SVV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SVV.ChartAreas.Add(chartArea1);
            this.chartFunction_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_SVV.Legends.Add(legend1);
            this.chartFunction_SVV.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_SVV.Name = "chartFunction_SVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SVV.Series.Add(series1);
            this.chartFunction_SVV.Size = new System.Drawing.Size(997, 437);
            this.chartFunction_SVV.TabIndex = 0;
            this.chartFunction_SVV.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title1.Name = "TitleCos";
            title1.Text = "График функции (2cos(x) + 2) / (2x - 1) + cos(x) - 5x + 3 ";
            this.chartFunction_SVV.Titles.Add(title1);
            // 
            // splitterOne_SVV
            // 
            this.splitterOne_SVV.Location = new System.Drawing.Point(200, 183);
            this.splitterOne_SVV.Name = "splitterOne_SVV";
            this.splitterOne_SVV.Size = new System.Drawing.Size(3, 437);
            this.splitterOne_SVV.TabIndex = 1;
            this.splitterOne_SVV.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 620);
            this.Controls.Add(this.splitterOne_SVV);
            this.Controls.Add(this.panelThree_SVV);
            this.Controls.Add(this.panelTwo_SVV);
            this.Controls.Add(this.panelOne_SVV);
            this.MinimumSize = new System.Drawing.Size(1210, 590);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 21 | Шананина В.В.";
            this.panelOne_SVV.ResumeLayout(false);
            this.groupBoxDano_SVV.ResumeLayout(false);
            this.groupBoxDano_SVV.PerformLayout();
            this.groupBoxUslovie_SVV.ResumeLayout(false);
            this.groupBoxUslovie_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SVV)).EndInit();
            this.panelTwo_SVV.ResumeLayout(false);
            this.groupBoxOne_SVV.ResumeLayout(false);
            this.groupBoxOne_SVV.PerformLayout();
            this.panelThree_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Panel panelTwo_SVV;
        private System.Windows.Forms.Panel panelThree_SVV;
        private System.Windows.Forms.Splitter splitterOne_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.GroupBox groupBoxOne_SVV;
        private System.Windows.Forms.TextBox textBoxResult_SVV;
        private System.Windows.Forms.GroupBox groupBoxDano_SVV;
        private System.Windows.Forms.GroupBox groupBoxUslovie_SVV;
        private System.Windows.Forms.Label labelStop_SVV;
        private System.Windows.Forms.Label labelStart_SVV;
        private System.Windows.Forms.TextBox textBoxStop_SVV;
        private System.Windows.Forms.TextBox textBoxStart_SVV;
        private System.Windows.Forms.TextBox textBoxDone_SVV;
        private System.Windows.Forms.Button buttonSave_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVV;
        private System.Windows.Forms.PictureBox pictureBoxForm_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
    }
}

