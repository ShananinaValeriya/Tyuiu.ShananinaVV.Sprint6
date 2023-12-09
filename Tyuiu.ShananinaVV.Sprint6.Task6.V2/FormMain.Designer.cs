
namespace Tyuiu.ShananinaVV.Sprint6.Task6.V2
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
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_SVV = new System.Windows.Forms.Button();
            this.panelTwo_SVV = new System.Windows.Forms.Panel();
            this.groupBoxDano_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_SVV = new System.Windows.Forms.TextBox();
            this.panelThree_SVV = new System.Windows.Forms.Panel();
            this.groupBoxVvod_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxVvod_SVV = new System.Windows.Forms.TextBox();
            this.panelFour_SVV = new System.Windows.Forms.Panel();
            this.groupBoxResult_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SVV = new System.Windows.Forms.TextBox();
            this.splitterSplit_SVV = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_SVV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_SVV = new System.Windows.Forms.ToolTip(this.components);
            this.panelOne_SVV.SuspendLayout();
            this.panelTwo_SVV.SuspendLayout();
            this.groupBoxDano_SVV.SuspendLayout();
            this.panelThree_SVV.SuspendLayout();
            this.groupBoxVvod_SVV.SuspendLayout();
            this.panelFour_SVV.SuspendLayout();
            this.groupBoxResult_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOne_SVV
            // 
            this.panelOne_SVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOne_SVV.Controls.Add(this.buttonHelp_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonDone_SVV);
            this.panelOne_SVV.Controls.Add(this.buttonOpenFile_SVV);
            this.panelOne_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOne_SVV.Location = new System.Drawing.Point(0, 0);
            this.panelOne_SVV.Name = "panelOne_SVV";
            this.panelOne_SVV.Size = new System.Drawing.Size(800, 88);
            this.panelOne_SVV.TabIndex = 0;
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SVV.Image")));
            this.buttonHelp_SVV.Location = new System.Drawing.Point(684, 6);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(103, 72);
            this.buttonHelp_SVV.TabIndex = 2;
            this.toolTipTask_SVV.SetToolTip(this.buttonHelp_SVV, "Сведение о программе\r\n");
            this.buttonHelp_SVV.UseVisualStyleBackColor = false;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDone_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SVV.Image")));
            this.buttonDone_SVV.Location = new System.Drawing.Point(118, 6);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(105, 69);
            this.buttonDone_SVV.TabIndex = 1;
            this.toolTipTask_SVV.SetToolTip(this.buttonDone_SVV, "Подсчитывает количество слов в строке, и если их больше 2, \r\nто выводит каждое вт" +
        "орое слово из строки в результатирующую строку\r\n\r\n");
            this.buttonDone_SVV.UseVisualStyleBackColor = false;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            // 
            // buttonOpenFile_SVV
            // 
            this.buttonOpenFile_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenFile_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_SVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SVV.Image")));
            this.buttonOpenFile_SVV.Location = new System.Drawing.Point(9, 6);
            this.buttonOpenFile_SVV.Name = "buttonOpenFile_SVV";
            this.buttonOpenFile_SVV.Size = new System.Drawing.Size(103, 69);
            this.buttonOpenFile_SVV.TabIndex = 0;
            this.toolTipTask_SVV.SetToolTip(this.buttonOpenFile_SVV, "Открыть файл \r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SVV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SVV.Click += new System.EventHandler(this.buttonOpenFile_SVV_Click);
            // 
            // panelTwo_SVV
            // 
            this.panelTwo_SVV.Controls.Add(this.groupBoxDano_SVV);
            this.panelTwo_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_SVV.Location = new System.Drawing.Point(0, 88);
            this.panelTwo_SVV.Name = "panelTwo_SVV";
            this.panelTwo_SVV.Size = new System.Drawing.Size(800, 100);
            this.panelTwo_SVV.TabIndex = 0;
            // 
            // groupBoxDano_SVV
            // 
            this.groupBoxDano_SVV.Controls.Add(this.textBoxUslovie_SVV);
            this.groupBoxDano_SVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDano_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDano_SVV.Name = "groupBoxDano_SVV";
            this.groupBoxDano_SVV.Size = new System.Drawing.Size(800, 94);
            this.groupBoxDano_SVV.TabIndex = 0;
            this.groupBoxDano_SVV.TabStop = false;
            this.groupBoxDano_SVV.Text = "Условие:";
            // 
            // textBoxUslovie_SVV
            // 
            this.textBoxUslovie_SVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie_SVV.Location = new System.Drawing.Point(3, 18);
            this.textBoxUslovie_SVV.Multiline = true;
            this.textBoxUslovie_SVV.Name = "textBoxUslovie_SVV";
            this.textBoxUslovie_SVV.ReadOnly = true;
            this.textBoxUslovie_SVV.Size = new System.Drawing.Size(794, 73);
            this.textBoxUslovie_SVV.TabIndex = 0;
            this.textBoxUslovie_SVV.Text = resources.GetString("textBoxUslovie_SVV.Text");
            // 
            // panelThree_SVV
            // 
            this.panelThree_SVV.Controls.Add(this.groupBoxVvod_SVV);
            this.panelThree_SVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThree_SVV.Location = new System.Drawing.Point(0, 188);
            this.panelThree_SVV.Name = "panelThree_SVV";
            this.panelThree_SVV.Size = new System.Drawing.Size(386, 262);
            this.panelThree_SVV.TabIndex = 0;
            // 
            // groupBoxVvod_SVV
            // 
            this.groupBoxVvod_SVV.Controls.Add(this.textBoxVvod_SVV);
            this.groupBoxVvod_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVvod_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxVvod_SVV.Name = "groupBoxVvod_SVV";
            this.groupBoxVvod_SVV.Size = new System.Drawing.Size(386, 262);
            this.groupBoxVvod_SVV.TabIndex = 0;
            this.groupBoxVvod_SVV.TabStop = false;
            this.groupBoxVvod_SVV.Text = "Ввод:";
            // 
            // textBoxVvod_SVV
            // 
            this.textBoxVvod_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVvod_SVV.Location = new System.Drawing.Point(3, 18);
            this.textBoxVvod_SVV.Multiline = true;
            this.textBoxVvod_SVV.Name = "textBoxVvod_SVV";
            this.textBoxVvod_SVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxVvod_SVV.Size = new System.Drawing.Size(380, 241);
            this.textBoxVvod_SVV.TabIndex = 0;
            // 
            // panelFour_SVV
            // 
            this.panelFour_SVV.Controls.Add(this.groupBoxResult_SVV);
            this.panelFour_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFour_SVV.Location = new System.Drawing.Point(386, 188);
            this.panelFour_SVV.Name = "panelFour_SVV";
            this.panelFour_SVV.Size = new System.Drawing.Size(414, 262);
            this.panelFour_SVV.TabIndex = 0;
            // 
            // groupBoxResult_SVV
            // 
            this.groupBoxResult_SVV.Controls.Add(this.textBoxResult_SVV);
            this.groupBoxResult_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SVV.Name = "groupBoxResult_SVV";
            this.groupBoxResult_SVV.Size = new System.Drawing.Size(414, 262);
            this.groupBoxResult_SVV.TabIndex = 0;
            this.groupBoxResult_SVV.TabStop = false;
            this.groupBoxResult_SVV.Text = "Вывод:";
            // 
            // textBoxResult_SVV
            // 
            this.textBoxResult_SVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SVV.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_SVV.Multiline = true;
            this.textBoxResult_SVV.Name = "textBoxResult_SVV";
            this.textBoxResult_SVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SVV.Size = new System.Drawing.Size(408, 241);
            this.textBoxResult_SVV.TabIndex = 0;
            // 
            // splitterSplit_SVV
            // 
            this.splitterSplit_SVV.Location = new System.Drawing.Point(386, 188);
            this.splitterSplit_SVV.Name = "splitterSplit_SVV";
            this.splitterSplit_SVV.Size = new System.Drawing.Size(3, 262);
            this.splitterSplit_SVV.TabIndex = 1;
            this.splitterSplit_SVV.TabStop = false;
            // 
            // openFileDialogTask_SVV
            // 
            this.openFileDialogTask_SVV.FileName = "InPutFileTask6V2.txt";
            // 
            // toolTipTask_SVV
            // 
            this.toolTipTask_SVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_SVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitterSplit_SVV);
            this.Controls.Add(this.panelFour_SVV);
            this.Controls.Add(this.panelThree_SVV);
            this.Controls.Add(this.panelTwo_SVV);
            this.Controls.Add(this.panelOne_SVV);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 2 | Шананина В.В.";
            this.panelOne_SVV.ResumeLayout(false);
            this.panelTwo_SVV.ResumeLayout(false);
            this.groupBoxDano_SVV.ResumeLayout(false);
            this.groupBoxDano_SVV.PerformLayout();
            this.panelThree_SVV.ResumeLayout(false);
            this.groupBoxVvod_SVV.ResumeLayout(false);
            this.groupBoxVvod_SVV.PerformLayout();
            this.panelFour_SVV.ResumeLayout(false);
            this.groupBoxResult_SVV.ResumeLayout(false);
            this.groupBoxResult_SVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Panel panelTwo_SVV;
        private System.Windows.Forms.GroupBox groupBoxDano_SVV;
        private System.Windows.Forms.TextBox textBoxUslovie_SVV;
        private System.Windows.Forms.Panel panelThree_SVV;
        private System.Windows.Forms.GroupBox groupBoxVvod_SVV;
        private System.Windows.Forms.TextBox textBoxVvod_SVV;
        private System.Windows.Forms.Panel panelFour_SVV;
        private System.Windows.Forms.GroupBox groupBoxResult_SVV;
        private System.Windows.Forms.TextBox textBoxResult_SVV;
        private System.Windows.Forms.Splitter splitterSplit_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.ToolTip toolTipTask_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.Button buttonOpenFile_SVV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SVV;
    }
}

