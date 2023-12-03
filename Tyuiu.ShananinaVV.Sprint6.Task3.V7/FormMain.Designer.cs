
namespace Tyuiu.ShananinaVV.Sprint6.Task3.V7
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
            this.groupBoxDone_SVV = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SVV = new System.Windows.Forms.DataGridView();
            this.textBoxDone_SVV = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SVV = new System.Windows.Forms.GroupBox();
            this.labelResult_SVV = new System.Windows.Forms.Label();
            this.buttonResult_SVV = new System.Windows.Forms.Button();
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.dataGridViewResult_SVV = new System.Windows.Forms.DataGridView();
            this.groupBoxDone_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SVV)).BeginInit();
            this.groupBoxResult_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDone_SVV
            // 
            this.groupBoxDone_SVV.Controls.Add(this.dataGridViewMatrix_SVV);
            this.groupBoxDone_SVV.Controls.Add(this.textBoxDone_SVV);
            this.groupBoxDone_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDone_SVV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDone_SVV.Name = "groupBoxDone_SVV";
            this.groupBoxDone_SVV.Size = new System.Drawing.Size(632, 353);
            this.groupBoxDone_SVV.TabIndex = 0;
            this.groupBoxDone_SVV.TabStop = false;
            this.groupBoxDone_SVV.Text = "Условие";
            this.groupBoxDone_SVV.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewMatrix_SVV
            // 
            this.dataGridViewMatrix_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SVV.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SVV.Location = new System.Drawing.Point(301, 31);
            this.dataGridViewMatrix_SVV.Name = "dataGridViewMatrix_SVV";
            this.dataGridViewMatrix_SVV.RowHeadersVisible = false;
            this.dataGridViewMatrix_SVV.RowHeadersWidth = 51;
            this.dataGridViewMatrix_SVV.RowTemplate.Height = 24;
            this.dataGridViewMatrix_SVV.Size = new System.Drawing.Size(315, 311);
            this.dataGridViewMatrix_SVV.TabIndex = 4;
            // 
            // textBoxDone_SVV
            // 
            this.textBoxDone_SVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDone_SVV.Location = new System.Drawing.Point(16, 31);
            this.textBoxDone_SVV.Multiline = true;
            this.textBoxDone_SVV.Name = "textBoxDone_SVV";
            this.textBoxDone_SVV.ReadOnly = true;
            this.textBoxDone_SVV.Size = new System.Drawing.Size(279, 311);
            this.textBoxDone_SVV.TabIndex = 0;
            this.textBoxDone_SVV.Text = resources.GetString("textBoxDone_SVV.Text");
            // 
            // groupBoxResult_SVV
            // 
            this.groupBoxResult_SVV.Controls.Add(this.dataGridViewResult_SVV);
            this.groupBoxResult_SVV.Controls.Add(this.labelResult_SVV);
            this.groupBoxResult_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SVV.Location = new System.Drawing.Point(665, 12);
            this.groupBoxResult_SVV.Name = "groupBoxResult_SVV";
            this.groupBoxResult_SVV.Size = new System.Drawing.Size(271, 313);
            this.groupBoxResult_SVV.TabIndex = 1;
            this.groupBoxResult_SVV.TabStop = false;
            this.groupBoxResult_SVV.Text = "Вывод данных";
            this.groupBoxResult_SVV.Enter += new System.EventHandler(this.groupBoxResult_SVV_Enter);
            // 
            // labelResult_SVV
            // 
            this.labelResult_SVV.AutoSize = true;
            this.labelResult_SVV.Location = new System.Drawing.Point(15, 34);
            this.labelResult_SVV.Name = "labelResult_SVV";
            this.labelResult_SVV.Size = new System.Drawing.Size(84, 18);
            this.labelResult_SVV.TabIndex = 1;
            this.labelResult_SVV.Text = "Результат:";
            // 
            // buttonResult_SVV
            // 
            this.buttonResult_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult_SVV.Location = new System.Drawing.Point(782, 331);
            this.buttonResult_SVV.Name = "buttonResult_SVV";
            this.buttonResult_SVV.Size = new System.Drawing.Size(154, 37);
            this.buttonResult_SVV.TabIndex = 2;
            this.buttonResult_SVV.Text = "Выполнить";
            this.buttonResult_SVV.UseVisualStyleBackColor = true;
            this.buttonResult_SVV.Click += new System.EventHandler(this.buttonResult_SVV_Click);
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SVV.Location = new System.Drawing.Point(739, 332);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(37, 36);
            this.buttonHelp_SVV.TabIndex = 3;
            this.buttonHelp_SVV.Text = "?";
            this.buttonHelp_SVV.UseVisualStyleBackColor = true;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // dataGridViewResult_SVV
            // 
            this.dataGridViewResult_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SVV.ColumnHeadersVisible = false;
            this.dataGridViewResult_SVV.Location = new System.Drawing.Point(18, 55);
            this.dataGridViewResult_SVV.Name = "dataGridViewResult_SVV";
            this.dataGridViewResult_SVV.RowHeadersVisible = false;
            this.dataGridViewResult_SVV.RowHeadersWidth = 51;
            this.dataGridViewResult_SVV.RowTemplate.Height = 24;
            this.dataGridViewResult_SVV.Size = new System.Drawing.Size(234, 233);
            this.dataGridViewResult_SVV.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 384);
            this.Controls.Add(this.buttonHelp_SVV);
            this.Controls.Add(this.buttonResult_SVV);
            this.Controls.Add(this.groupBoxResult_SVV);
            this.Controls.Add(this.groupBoxDone_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 7 | Шананина В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxDone_SVV.ResumeLayout(false);
            this.groupBoxDone_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SVV)).EndInit();
            this.groupBoxResult_SVV.ResumeLayout(false);
            this.groupBoxResult_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDone_SVV;
        private System.Windows.Forms.GroupBox groupBoxResult_SVV;
        private System.Windows.Forms.Label labelResult_SVV;
        private System.Windows.Forms.Button buttonResult_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.TextBox textBoxDone_SVV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SVV;
        private System.Windows.Forms.DataGridView dataGridViewResult_SVV;
    }
}

