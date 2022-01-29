using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFirst_18440038
{
    public partial class ogrenciEkle : Form
    {
        public ogrenciEkle()
        {
            InitializeComponent();
        }


        sinavDBModelContainer x = new sinavDBModelContainer();
        private void ogrenciEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinavMDBDataSet.sinavSet' table. You can move, or remove it, as needed.
            this.sinavSetTableAdapter.Fill(this.sinavMDBDataSet.sinavSet);
            dataGridView1.DataSource = x.ogrenciSet.ToList();
        }

        private void btbekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var o = x.ogrenciSet.Where(y => y.ID == id).FirstOrDefault();         
            o.isim = tbisim.Text;
            o.dersno = comboBox1.SelectedIndex.ToString();      
            o.sifre = tbsifre.Text;          
            x.ogrenciSet.Add(o);
             o.adminID  = Admin.fk_admin  ;
             x.SaveChanges();

             MessageBox.Show("eklendi");
             foreach (Control item in Controls)
             {
                 if (item is TextBox) item.Text = "";
             }
             dataGridView1.DataSource = x.ogrenciSet.ToList();            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var o = x.ogrenciSet.Where(y => y.ID == id).FirstOrDefault();
            x.ogrenciSet.Remove(o);
            x.SaveChanges();
            MessageBox.Show("silindi");
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            dataGridView1.DataSource = x.ogrenciSet.ToList();  
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var g = x.ogrenciSet.Where(y => y.ID == id).FirstOrDefault();
            g.isim = tbisim.Text;
            g.dersno = comboBox1.SelectedIndex.ToString();
            g.sifre = tbsifre.Text;
            x.SaveChanges();
            MessageBox.Show("güncellendi");
            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }
            dataGridView1.DataSource = x.ogrenciSet.ToList();  
        }
    }
}
