namespace ModelFirst_18440038
{
    partial class test
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
            this.rba = new System.Windows.Forms.RadioButton();
            this.rbb = new System.Windows.Forms.RadioButton();
            this.rbc = new System.Windows.Forms.RadioButton();
            this.btnsonra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rba
            // 
            this.rba.AutoSize = true;
            this.rba.Location = new System.Drawing.Point(461, 173);
            this.rba.Name = "rba";
            this.rba.Size = new System.Drawing.Size(85, 17);
            this.rba.TabIndex = 5;
            this.rba.TabStop = true;
            this.rba.Text = "radioButton1";
            this.rba.UseVisualStyleBackColor = true;
            // 
            // rbb
            // 
            this.rbb.AutoSize = true;
            this.rbb.Location = new System.Drawing.Point(461, 225);
            this.rbb.Name = "rbb";
            this.rbb.Size = new System.Drawing.Size(85, 17);
            this.rbb.TabIndex = 6;
            this.rbb.TabStop = true;
            this.rbb.Text = "radioButton2";
            this.rbb.UseVisualStyleBackColor = true;
            // 
            // rbc
            // 
            this.rbc.AutoSize = true;
            this.rbc.Location = new System.Drawing.Point(461, 288);
            this.rbc.Name = "rbc";
            this.rbc.Size = new System.Drawing.Size(85, 17);
            this.rbc.TabIndex = 7;
            this.rbc.TabStop = true;
            this.rbc.Text = "radioButton3";
            this.rbc.UseVisualStyleBackColor = true;
            // 
            // btnsonra
            // 
            this.btnsonra.BackColor = System.Drawing.Color.Transparent;
            this.btnsonra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsonra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsonra.Location = new System.Drawing.Point(51, 81);
            this.btnsonra.Name = "btnsonra";
            this.btnsonra.Size = new System.Drawing.Size(135, 30);
            this.btnsonra.TabIndex = 9;
            this.btnsonra.Text = "SONRAKİ";
            this.btnsonra.UseVisualStyleBackColor = false;
            this.btnsonra.Click += new System.EventHandler(this.btnsonra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "SKOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 255);
            this.dataGridView1.TabIndex = 14;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ModelFirst_18440038.Properties.Resources.newquiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsonra);
            this.Controls.Add(this.rbc);
            this.Controls.Add(this.rbb);
            this.Controls.Add(this.rba);
            this.Name = "test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rba;
        private System.Windows.Forms.RadioButton rbb;
        private System.Windows.Forms.RadioButton rbc;
        private System.Windows.Forms.Button btnsonra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}