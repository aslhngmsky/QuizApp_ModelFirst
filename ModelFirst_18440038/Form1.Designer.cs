namespace ModelFirst_18440038
{
    partial class Form1
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
            this.btnogr = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnogr
            // 
            this.btnogr.Location = new System.Drawing.Point(517, 191);
            this.btnogr.Name = "btnogr";
            this.btnogr.Size = new System.Drawing.Size(75, 23);
            this.btnogr.TabIndex = 3;
            this.btnogr.Text = "ÖĞRENCİ";
            this.btnogr.UseVisualStyleBackColor = true;
            this.btnogr.Click += new System.EventHandler(this.btnogr_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(116, 191);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(75, 23);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "ADMİN";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 405);
            this.Controls.Add(this.btnogr);
            this.Controls.Add(this.btnadmin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SINAV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnogr;
        private System.Windows.Forms.Button btnadmin;
    }
}

