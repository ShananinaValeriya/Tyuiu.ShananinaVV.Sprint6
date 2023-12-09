
namespace Tyuiu.ShananinaVV.Sprint6.Task6.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAva_SVV = new System.Windows.Forms.PictureBox();
            this.labelInfo_SVV = new System.Windows.Forms.Label();
            this.buttonOk_SVV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAva_SVV
            // 
            this.pictureBoxAva_SVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_SVV.Image")));
            this.pictureBoxAva_SVV.Location = new System.Drawing.Point(12, 8);
            this.pictureBoxAva_SVV.Name = "pictureBoxAva_SVV";
            this.pictureBoxAva_SVV.Size = new System.Drawing.Size(173, 203);
            this.pictureBoxAva_SVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAva_SVV.TabIndex = 0;
            this.pictureBoxAva_SVV.TabStop = false;
            // 
            // labelInfo_SVV
            // 
            this.labelInfo_SVV.AutoSize = true;
            this.labelInfo_SVV.Location = new System.Drawing.Point(191, 9);
            this.labelInfo_SVV.Name = "labelInfo_SVV";
            this.labelInfo_SVV.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_SVV.TabIndex = 1;
            this.labelInfo_SVV.Text = resources.GetString("labelInfo_SVV.Text");
            // 
            // buttonOk_SVV
            // 
            this.buttonOk_SVV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk_SVV.Location = new System.Drawing.Point(467, 181);
            this.buttonOk_SVV.Name = "buttonOk_SVV";
            this.buttonOk_SVV.Size = new System.Drawing.Size(87, 30);
            this.buttonOk_SVV.TabIndex = 2;
            this.buttonOk_SVV.Text = "Ок";
            this.buttonOk_SVV.UseVisualStyleBackColor = true;
            this.buttonOk_SVV.Click += new System.EventHandler(this.buttonOk_SVV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 223);
            this.Controls.Add(this.buttonOk_SVV);
            this.Controls.Add(this.labelInfo_SVV);
            this.Controls.Add(this.pictureBoxAva_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAva_SVV;
        private System.Windows.Forms.Label labelInfo_SVV;
        private System.Windows.Forms.Button buttonOk_SVV;
    }
}