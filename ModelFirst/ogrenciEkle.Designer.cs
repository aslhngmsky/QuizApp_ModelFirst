namespace ModelFirst_18440038
{
    partial class ogrenciEkle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btbekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.tbisim = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sinavMDBDataSet = new ModelFirst_18440038.sinavMDBDataSet();
            this.sinavMDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinavSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinavSetTableAdapter = new ModelFirst_18440038.sinavMDBDataSetTableAdapters.sinavSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavMDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavMDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btbekle
            // 
            this.btbekle.Location = new System.Drawing.Point(298, 163);
            this.btbekle.Name = "btbekle";
            this.btbekle.Size = new System.Drawing.Size(75, 23);
            this.btbekle.TabIndex = 1;
            this.btbekle.Text = "EKLE";
            this.btbekle.UseVisualStyleBackColor = true;
            this.btbekle.Click += new System.EventHandler(this.btbekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(298, 214);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(298, 269);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // tbsifre
            // 
            this.tbsifre.Location = new System.Drawing.Point(79, 279);
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.Size = new System.Drawing.Size(121, 20);
            this.tbsifre.TabIndex = 4;
            // 
            // tbisim
            // 
            this.tbisim.Location = new System.Drawing.Point(79, 227);
            this.tbisim.Name = "tbisim";
            this.tbisim.Size = new System.Drawing.Size(121, 20);
            this.tbisim.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sinavSetBindingSource;
            this.comboBox1.DisplayMember = "sinavadi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aldığı Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // sinavMDBDataSet
            // 
            this.sinavMDBDataSet.DataSetName = "sinavMDBDataSet";
            this.sinavMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinavMDBDataSetBindingSource
            // 
            this.sinavMDBDataSetBindingSource.DataSource = this.sinavMDBDataSet;
            this.sinavMDBDataSetBindingSource.Position = 0;
            // 
            // sinavSetBindingSource
            // 
            this.sinavSetBindingSource.DataMember = "sinavSet";
            this.sinavSetBindingSource.DataSource = this.sinavMDBDataSetBindingSource;
            // 
            // sinavSetTableAdapter
            // 
            this.sinavSetTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbisim);
            this.Controls.Add(this.tbsifre);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btbekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrenciEkle";
            this.Text = "ogrenciEkle";
            this.Load += new System.EventHandler(this.ogrenciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavMDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavMDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btbekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.TextBox tbisim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sinavMDBDataSetBindingSource;
        private sinavMDBDataSet sinavMDBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sinavSetBindingSource;
        private sinavMDBDataSetTableAdapters.sinavSetTableAdapter sinavSetTableAdapter;
    }
}