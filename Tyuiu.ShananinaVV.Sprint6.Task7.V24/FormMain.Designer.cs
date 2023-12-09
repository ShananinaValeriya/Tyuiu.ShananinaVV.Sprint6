
namespace Tyuiu.ShananinaVV.Sprint6.Task7.V24
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelOne_SVV = new System.Windows.Forms.Panel();
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.buttonSave_SVV = new System.Windows.Forms.Button();
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_SVV = new System.Windows.Forms.Button();
            this.panelTwo_SVV = new System.Windows.Forms.Panel();
            this.groupBoxUslovie_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_SVV = new System.Windows.Forms.TextBox();
            this.panelThree_SVV = new System.Windows.Forms.Panel();
            this.groupBoxVvod_SVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_SVV = new System.Windows.Forms.DataGridView();
            this.panelFour_SVV = new System.Windows.Forms.Panel();
            this.groupBoxResult_SVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_SVV = new System.Windows.Forms.DataGridView();
            this.splitterOne_SVV = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_SVV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_SVV = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SVV = new System.Windows.Forms.SaveFileDialog();
            this.panelOne_SVV.SuspendLayout();
            this.panelTwo_SVV.SuspendLayout();
            this.groupBoxUslovie_SVV.SuspendLayout();
            this.panelThree_SVV.SuspendLayout();
            this.groupBoxVvod_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SVV)).BeginInit();
            this.panelFour_SVV.SuspendLayout();
            this.groupBoxResult_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOne_SVV
            // 
            this.panelOne_SVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOne_SVV.Controls.Add(this.buttonHelp_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonSave_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonDone_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonOpenFile_SVV);
            this.panelOne_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOne_SVV.Name = "panelOne_SVV";
            this.panelOne_SVV.Size = new System.Drawing.Size(832, 88);
            this.panelOne_SVV.TabIndex = 0;
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SVV.ForeColor = System.Drawing.Color.Silver;
            this.buttonHelp_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SVV.Image")));
            this.buttonHelp_SVV.Location = new System.Drawing.Point(722, 5);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(105, 76);
            this.buttonHelp_SVV.TabIndex = 0;
            this.toolTipButton_SVV.SetToolTip(this.buttonHelp_SVV, "Сведение о программе");
            this.buttonHelp_SVV.UseVisualStyleBackColor = false;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            this.buttonHelp_SVV.MouseEnter += new System.EventHandler(this.buttonHelp_SVV_MouseEnter);
            // 
            // buttonSave_SVV
            // 
            this.buttonSave_SVV.Enabled = false;
            this.buttonSave_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SVV.ForeColor = System.Drawing.Color.Silver;
            this.buttonSave_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SVV.Image")));
            this.buttonSave_SVV.Location = new System.Drawing.Point(235, 5);
            this.buttonSave_SVV.Name = "buttonSave_SVV";
            this.buttonSave_SVV.Size = new System.Drawing.Size(106, 76);
            this.buttonSave_SVV.TabIndex = 0;
            this.toolTipButton_SVV.SetToolTip(this.buttonSave_SVV, " Сохранить обработанные данных в файл в формате CSV");
            this.buttonSave_SVV.UseVisualStyleBackColor = false;
            this.buttonSave_SVV.Click += new System.EventHandler(this.buttonSave_SVV_Click);
            this.buttonSave_SVV.MouseEnter += new System.EventHandler(this.buttonSave_SVV_MouseEnter);
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.Enabled = false;
            this.buttonDone_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SVV.ForeColor = System.Drawing.Color.Silver;
            this.buttonDone_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SVV.Image")));
            this.buttonDone_SVV.Location = new System.Drawing.Point(120, 5);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(109, 76);
            this.buttonDone_SVV.TabIndex = 0;
            this.toolTipButton_SVV.SetToolTip(this.buttonDone_SVV, "Выполнить обработку данных");
            this.buttonDone_SVV.UseVisualStyleBackColor = false;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            this.buttonDone_SVV.MouseEnter += new System.EventHandler(this.buttonDone_SVV_MouseEnter);
            // 
            // buttonOpenFile_SVV
            // 
            this.buttonOpenFile_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_SVV.ForeColor = System.Drawing.Color.Silver;
            this.buttonOpenFile_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SVV.Image")));
            this.buttonOpenFile_SVV.Location = new System.Drawing.Point(3, 5);
            this.buttonOpenFile_SVV.Name = "buttonOpenFile_SVV";
            this.buttonOpenFile_SVV.Size = new System.Drawing.Size(111, 76);
            this.buttonOpenFile_SVV.TabIndex = 0;
            this.toolTipButton_SVV.SetToolTip(this.buttonOpenFile_SVV, "Открыть файл для обработки данных в формале CSV");
            this.buttonOpenFile_SVV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SVV.Click += new System.EventHandler(this.buttonOpenFile_SVV_Click);
            this.buttonOpenFile_SVV.MouseEnter += new System.EventHandler(this.buttonOpenFile_SVV_MouseEnter);
            // 
            // panelTwo_SVV
            // 
            this.panelTwo_SVV.Controls.Add(this.groupBoxUslovie_SVV);
            this.panelTwo_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_SVV.Location = new System.Drawing.Point(0, 88);
            this.panelTwo_SVV.Name = "panelTwo_SVV";
            this.panelTwo_SVV.Size = new System.Drawing.Size(832, 98);
            this.panelTwo_SVV.TabIndex = 1;
            // 
            // groupBoxUslovie_SVV
            // 
            this.groupBoxUslovie_SVV.Controls.Add(this.textBoxUslovie_SVV);
            this.groupBoxUslovie_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUslovie_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovie_SVV.Name = "groupBoxUslovie_SVV";
            this.groupBoxUslovie_SVV.Size = new System.Drawing.Size(832, 98);
            this.groupBoxUslovie_SVV.TabIndex = 0;
            this.groupBoxUslovie_SVV.TabStop = false;
            this.groupBoxUslovie_SVV.Text = "Условие:";
            // 
            // textBoxUslovie_SVV
            // 
            this.textBoxUslovie_SVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie_SVV.Location = new System.Drawing.Point(3, 18);
            this.textBoxUslovie_SVV.Multiline = true;
            this.textBoxUslovie_SVV.Name = "textBoxUslovie_SVV";
            this.textBoxUslovie_SVV.ReadOnly = true;
            this.textBoxUslovie_SVV.Size = new System.Drawing.Size(826, 77);
            this.textBoxUslovie_SVV.TabIndex = 0;
            this.textBoxUslovie_SVV.Text = resources.GetString("textBoxUslovie_SVV.Text");
            // 
            // panelThree_SVV
            // 
            this.panelThree_SVV.Controls.Add(this.groupBoxVvod_SVV);
            this.panelThree_SVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_SVV.Location = new System.Drawing.Point(0, 186);
            this.panelThree_SVV.Name = "panelThree_SVV";
            this.panelThree_SVV.Size = new System.Drawing.Size(398, 344);
            this.panelThree_SVV.TabIndex = 2;
            // 
            // groupBoxVvod_SVV
            // 
            this.groupBoxVvod_SVV.Controls.Add(this.dataGridViewIn_SVV);
            this.groupBoxVvod_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvod_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvod_SVV.Name = "groupBoxVvod_SVV";
            this.groupBoxVvod_SVV.Size = new System.Drawing.Size(398, 344);
            this.groupBoxVvod_SVV.TabIndex = 0;
            this.groupBoxVvod_SVV.TabStop = false;
            this.groupBoxVvod_SVV.Text = "Ввод:";
            // 
            // dataGridViewIn_SVV
            // 
            this.dataGridViewIn_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SVV.ColumnHeadersVisible = false;
            this.dataGridViewIn_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_SVV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_SVV.Name = "dataGridViewIn_SVV";
            this.dataGridViewIn_SVV.RowHeadersVisible = false;
            this.dataGridViewIn_SVV.RowHeadersWidth = 51;
            this.dataGridViewIn_SVV.RowTemplate.Height = 24;
            this.dataGridViewIn_SVV.Size = new System.Drawing.Size(392, 323);
            this.dataGridViewIn_SVV.TabIndex = 0;
            // 
            // panelFour_SVV
            // 
            this.panelFour_SVV.Controls.Add(this.groupBoxResult_SVV);
            this.panelFour_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_SVV.Location = new System.Drawing.Point(401, 186);
            this.panelFour_SVV.Name = "panelFour_SVV";
            this.panelFour_SVV.Size = new System.Drawing.Size(431, 344);
            this.panelFour_SVV.TabIndex = 3;
            // 
            // groupBoxResult_SVV
            // 
            this.groupBoxResult_SVV.Controls.Add(this.dataGridViewOut_SVV);
            this.groupBoxResult_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SVV.Name = "groupBoxResult_SVV";
            this.groupBoxResult_SVV.Size = new System.Drawing.Size(431, 344);
            this.groupBoxResult_SVV.TabIndex = 0;
            this.groupBoxResult_SVV.TabStop = false;
            this.groupBoxResult_SVV.Text = "Вывод:";
            // 
            // dataGridViewOut_SVV
            // 
            this.dataGridViewOut_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_SVV.ColumnHeadersVisible = false;
            this.dataGridViewOut_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_SVV.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_SVV.Name = "dataGridViewOut_SVV";
            this.dataGridViewOut_SVV.RowHeadersVisible = false;
            this.dataGridViewOut_SVV.RowHeadersWidth = 51;
            this.dataGridViewOut_SVV.RowTemplate.Height = 24;
            this.dataGridViewOut_SVV.Size = new System.Drawing.Size(425, 323);
            this.dataGridViewOut_SVV.TabIndex = 0;
            // 
            // splitterOne_SVV
            // 
            this.splitterOne_SVV.Location = new System.Drawing.Point(398, 186);
            this.splitterOne_SVV.Name = "splitterOne_SVV";
            this.splitterOne_SVV.Size = new System.Drawing.Size(3, 344);
            this.splitterOne_SVV.TabIndex = 4;
            this.splitterOne_SVV.TabStop = false;
            // 
            // openFileDialogTask_SVV
            // 
            this.openFileDialogTask_SVV.FileName = "InPutFileTask7V24";
            // 
            // toolTipButton_SVV
            // 
            this.toolTipButton_SVV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButton_SVV.IsBalloon = true;
            this.toolTipButton_SVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 530);
            this.Controls.Add(this.panelFour_SVV);
            this.Controls.Add(this.splitterOne_SVV);
            this.Controls.Add(this.panelThree_SVV);
            this.Controls.Add(this.panelTwo_SVV);
            this.Controls.Add(this.panelOne_SVV);
            this.MinimumSize = new System.Drawing.Size(850, 560);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 24 | Шананина В.В.";
            this.panelOne_SVV.ResumeLayout(false);
            this.panelTwo_SVV.ResumeLayout(false);
            this.groupBoxUslovie_SVV.ResumeLayout(false);
            this.groupBoxUslovie_SVV.PerformLayout();
            this.panelThree_SVV.ResumeLayout(false);
            this.groupBoxVvod_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SVV)).EndInit();
            this.panelFour_SVV.ResumeLayout(false);
            this.groupBoxResult_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.Button buttonSave_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.Button buttonOpenFile_SVV;
        private System.Windows.Forms.Panel panelTwo_SVV;
        private System.Windows.Forms.Panel panelThree_SVV;
        private System.Windows.Forms.Panel panelFour_SVV;
        private System.Windows.Forms.Splitter splitterOne_SVV;
        private System.Windows.Forms.GroupBox groupBoxUslovie_SVV;
        private System.Windows.Forms.GroupBox groupBoxVvod_SVV;
        private System.Windows.Forms.GroupBox groupBoxResult_SVV;
        private System.Windows.Forms.TextBox textBoxUslovie_SVV;
        private System.Windows.Forms.DataGridView dataGridViewIn_SVV;
        private System.Windows.Forms.DataGridView dataGridViewOut_SVV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SVV;
        private System.Windows.Forms.ToolTip toolTipButton_SVV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SVV;
    }
}

