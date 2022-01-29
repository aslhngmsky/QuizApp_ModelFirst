namespace ModelFirst_18440038
{
    partial class Form2
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
            this.btnsinav = new System.Windows.Forms.Button();
            this.btnogrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsinav
            // 
            this.btnsinav.Location = new System.Drawing.Point(409, 117);
            this.btnsinav.Name = "btnsinav";
            this.btnsinav.Size = new System.Drawing.Size(149, 23);
            this.btnsinav.TabIndex = 5;
            this.btnsinav.Text = "SINAV EKLE";
            this.btnsinav.UseVisualStyleBackColor = true;
            this.btnsinav.Click += new System.EventHandler(this.btnsinav_Click);
            // 
            // btnogrenci
            // 
            this.btnogrenci.Location = new System.Drawing.Point(93, 117);
            this.btnogrenci.Name = "btnogrenci";
            this.btnogrenci.Size = new System.Drawing.Size(159, 23);
            this.btnogrenci.TabIndex = 4;
            this.btnogrenci.Text = "ÖĞRENCİ EKLE";
            this.btnogrenci.UseVisualStyleBackColor = true;
            this.btnogrenci.Click += new System.EventHandler(this.btnogrenci_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 256);
            this.Controls.Add(this.btnsinav);
            this.Controls.Add(this.btnogrenci);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN PANEL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsinav;
        private System.Windows.Forms.Button btnogrenci;
    }
}