namespace ModelFirst_18440038
{
    partial class SoruEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbdersadi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sinavSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinavMDBDataSet = new ModelFirst_18440038.sinavMDBDataSet();
            this.btnekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbdogrucvp = new System.Windows.Forms.TextBox();
            this.tbcvpc = new System.Windows.Forms.TextBox();
            this.tbcvpb = new System.Windows.Forms.TextBox();
            this.tbcvpa = new System.Windows.Forms.TextBox();
            this.tbsoru = new System.Windows.Forms.TextBox();
            this.sinavSetTableAdapter = new ModelFirst_18440038.sinavMDBDataSetTableAdapters.sinavSetTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavMDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbdersadi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbdogrucvp);
            this.groupBox1.Controls.Add(this.tbcvpc);
            this.groupBox1.Controls.Add(this.tbcvpb);
            this.groupBox1.Controls.Add(this.tbcvpa);
            this.groupBox1.Controls.Add(this.tbsoru);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SORULAR";
            // 
            // lbdersadi
            // 
            this.lbdersadi.AutoSize = true;
            this.lbdersadi.Location = new System.Drawing.Point(21, 40);
            this.lbdersadi.Name = "lbdersadi";
            this.lbdersadi.Size = new System.Drawing.Size(61, 13);
            this.lbdersadi.TabIndex = 12;
            this.lbdersadi.Text = "DERS ADI:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sinavSetBindingSource;
            this.comboBox1.DisplayMember = "sinavadi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(375, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID";
            // 
            // sinavSetBindingSource
            // 
            this.sinavSetBindingSource.DataMember = "sinavSet";
            this.sinavSetBindingSource.DataSource = this.sinavMDBDataSet;
            // 
            // sinavMDBDataSet
            // 
            this.sinavMDBDataSet.DataSetName = "sinavMDBDataSet";
            this.sinavMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(403, 359);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(136, 46);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DOĞRU CEVAP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "C)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "B)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SORU :";
            // 
            // tbdogrucvp
            // 
            this.tbdogrucvp.Location = new System.Drawing.Point(144, 306);
            this.tbdogrucvp.Name = "tbdogrucvp";
            this.tbdogrucvp.Size = new System.Drawing.Size(176, 20);
            this.tbdogrucvp.TabIndex = 4;
            // 
            // tbcvpc
            // 
            this.tbcvpc.Location = new System.Drawing.Point(144, 254);
            this.tbcvpc.Name = "tbcvpc";
            this.tbcvpc.Size = new System.Drawing.Size(176, 20);
            this.tbcvpc.TabIndex = 3;
            // 
            // tbcvpb
            // 
            this.tbcvpb.Location = new System.Drawing.Point(144, 190);
            this.tbcvpb.Name = "tbcvpb";
            this.tbcvpb.Size = new System.Drawing.Size(176, 20);
            this.tbcvpb.TabIndex = 2;
            // 
            // tbcvpa
            // 
            this.tbcvpa.Location = new System.Drawing.Point(144, 138);
            this.tbcvpa.Name = "tbcvpa";
            this.tbcvpa.Size = new System.Drawing.Size(176, 20);
            this.tbcvpa.TabIndex = 1;
            // 
            // tbsoru
            // 
            this.tbsoru.Location = new System.Drawing.Point(77, 82);
            this.tbsoru.Name = "tbsoru";
            this.tbsoru.Size = new System.Drawing.Size(423, 20);
            this.tbsoru.TabIndex = 0;
            // 
            // sinavSetTableAdapter
            // 
            this.sinavSetTableAdapter.ClearBeforeFill = true;
            // 
            // SoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 465);
            this.Controls.Add(this.groupBox1);
            this.Name = "SoruEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soru Ekle";
            this.Load += new System.EventHandler(this.SoruEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavMDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbdogrucvp;
        private System.Windows.Forms.TextBox tbcvpc;
        private System.Windows.Forms.TextBox tbcvpb;
        private System.Windows.Forms.TextBox tbcvpa;
        private System.Windows.Forms.TextBox tbsoru;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnekle;
        private sinavMDBDataSet sinavMDBDataSet;
        private System.Windows.Forms.BindingSource sinavSetBindingSource;
        private sinavMDBDataSetTableAdapters.sinavSetTableAdapter sinavSetTableAdapter;
        private System.Windows.Forms.Label lbdersadi;
    }
}