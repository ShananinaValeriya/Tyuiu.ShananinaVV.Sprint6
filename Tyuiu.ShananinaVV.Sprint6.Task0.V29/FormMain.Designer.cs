
namespace Tyuiu.ShananinaVV.Sprint6.Task0.V29
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
            this.groupBoxTask_SVV = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SVV = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SVV = new System.Windows.Forms.TextBox();
            this.groupBoxDano_SVV = new System.Windows.Forms.GroupBox();
            this.labelX_SVV = new System.Windows.Forms.Label();
            this.textBoxVarX_SVV = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SVV = new System.Windows.Forms.GroupBox();
            this.labelResult_SVV = new System.Windows.Forms.Label();
            this.textBoxResult_SVV = new System.Windows.Forms.TextBox();
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.groupBoxTask_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SVV)).BeginInit();
            this.groupBoxDano_SVV.SuspendLayout();
            this.groupBoxResult_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SVV
            // 
            this.groupBoxTask_SVV.Controls.Add(this.pictureBoxFormula_SVV);
            this.groupBoxTask_SVV.Controls.Add(this.textBoxTask_SVV);
            this.groupBoxTask_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SVV.Location = new System.Drawing.Point(12, 30);
            this.groupBoxTask_SVV.Name = "groupBoxTask_SVV";
            this.groupBoxTask_SVV.Size = new System.Drawing.Size(560, 201);
            this.groupBoxTask_SVV.TabIndex = 0;
            this.groupBoxTask_SVV.TabStop = false;
            this.groupBoxTask_SVV.Text = "Условие";
            // 
            // pictureBoxFormula_SVV
            // 
            this.pictureBoxFormula_SVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SVV.Image")));
            this.pictureBoxFormula_SVV.Location = new System.Drawing.Point(417, 23);
            this.pictureBoxFormula_SVV.Name = "pictureBoxFormula_SVV";
            this.pictureBoxFormula_SVV.Size = new System.Drawing.Size(112, 59);
            this.pictureBoxFormula_SVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_SVV.TabIndex = 1;
            this.pictureBoxFormula_SVV.TabStop = false;
            // 
            // textBoxTask_SVV
            // 
            this.textBoxTask_SVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SVV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_SVV.Location = new System.Drawing.Point(11, 23);
            this.textBoxTask_SVV.Multiline = true;
            this.textBoxTask_SVV.Name = "textBoxTask_SVV";
            this.textBoxTask_SVV.ReadOnly = true;
            this.textBoxTask_SVV.Size = new System.Drawing.Size(381, 163);
            this.textBoxTask_SVV.TabIndex = 0;
            this.textBoxTask_SVV.Text = "Дано выражение. Вычислить его значение при x = 3,\r\nрезультат вывести в TextBox.\r\n" +
    "Округлить до 3 знаков после запятой.";
            // 
            // groupBoxDano_SVV
            // 
            this.groupBoxDano_SVV.Controls.Add(this.labelX_SVV);
            this.groupBoxDano_SVV.Controls.Add(this.textBoxVarX_SVV);
            this.groupBoxDano_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDano_SVV.Location = new System.Drawing.Point(12, 237);
            this.groupBoxDano_SVV.Name = "groupBoxDano_SVV";
            this.groupBoxDano_SVV.Size = new System.Drawing.Size(333, 118);
            this.groupBoxDano_SVV.TabIndex = 1;
            this.groupBoxDano_SVV.TabStop = false;
            this.groupBoxDano_SVV.Text = "Ввод данных";
            // 
            // labelX_SVV
            // 
            this.labelX_SVV.AutoSize = true;
            this.labelX_SVV.Location = new System.Drawing.Point(21, 30);
            this.labelX_SVV.Name = "labelX_SVV";
            this.labelX_SVV.Size = new System.Drawing.Size(112, 18);
            this.labelX_SVV.TabIndex = 1;
            this.labelX_SVV.Text = "Переменная X:";
            // 
            // textBoxVarX_SVV
            // 
            this.textBoxVarX_SVV.Location = new System.Drawing.Point(19, 55);
            this.textBoxVarX_SVV.Name = "textBoxVarX_SVV";
            this.textBoxVarX_SVV.Size = new System.Drawing.Size(247, 24);
            this.textBoxVarX_SVV.TabIndex = 0;
            this.textBoxVarX_SVV.Text = "3";
            this.textBoxVarX_SVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SVV_KeyPress);
            // 
            // groupBoxResult_SVV
            // 
            this.groupBoxResult_SVV.Controls.Add(this.labelResult_SVV);
            this.groupBoxResult_SVV.Controls.Add(this.textBoxResult_SVV);
            this.groupBoxResult_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SVV.Location = new System.Drawing.Point(351, 238);
            this.groupBoxResult_SVV.Name = "groupBoxResult_SVV";
            this.groupBoxResult_SVV.Size = new System.Drawing.Size(221, 117);
            this.groupBoxResult_SVV.TabIndex = 2;
            this.groupBoxResult_SVV.TabStop = false;
            this.groupBoxResult_SVV.Text = "Вывод данных ";
            // 
            // labelResult_SVV
            // 
            this.labelResult_SVV.AutoSize = true;
            this.labelResult_SVV.Location = new System.Drawing.Point(6, 29);
            this.labelResult_SVV.Name = "labelResult_SVV";
            this.labelResult_SVV.Size = new System.Drawing.Size(84, 18);
            this.labelResult_SVV.TabIndex = 1;
            this.labelResult_SVV.Text = "Результат:";
            // 
            // textBoxResult_SVV
            // 
            this.textBoxResult_SVV.Location = new System.Drawing.Point(6, 55);
            this.textBoxResult_SVV.Name = "textBoxResult_SVV";
            this.textBoxResult_SVV.ReadOnly = true;
            this.textBoxResult_SVV.Size = new System.Drawing.Size(203, 24);
            this.textBoxResult_SVV.TabIndex = 0;
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SVV.Location = new System.Drawing.Point(398, 360);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(175, 38);
            this.buttonDone_SVV.TabIndex = 3;
            this.buttonDone_SVV.Text = "Выполнить";
            this.buttonDone_SVV.UseVisualStyleBackColor = true;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SVV.Location = new System.Drawing.Point(351, 361);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(41, 37);
            this.buttonHelp_SVV.TabIndex = 4;
            this.buttonHelp_SVV.Text = "?";
            this.buttonHelp_SVV.UseVisualStyleBackColor = true;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 412);
            this.Controls.Add(this.buttonHelp_SVV);
            this.Controls.Add(this.buttonDone_SVV);
            this.Controls.Add(this.groupBoxResult_SVV);
            this.Controls.Add(this.groupBoxDano_SVV);
            this.Controls.Add(this.groupBoxTask_SVV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 29 | Шананина В.В.";
            this.groupBoxTask_SVV.ResumeLayout(false);
            this.groupBoxTask_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SVV)).EndInit();
            this.groupBoxDano_SVV.ResumeLayout(false);
            this.groupBoxDano_SVV.PerformLayout();
            this.groupBoxResult_SVV.ResumeLayout(false);
            this.groupBoxResult_SVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SVV;
        private System.Windows.Forms.GroupBox groupBoxDano_SVV;
        private System.Windows.Forms.Label labelX_SVV;
        private System.Windows.Forms.TextBox textBoxVarX_SVV;
        private System.Windows.Forms.GroupBox groupBoxResult_SVV;
        private System.Windows.Forms.Label labelResult_SVV;
        private System.Windows.Forms.TextBox textBoxResult_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.TextBox textBoxTask_SVV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SVV;
    }
}

