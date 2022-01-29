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
    public partial class SoruEkle : Form
    {
        public SoruEkle()
        {
            InitializeComponent();
        }
       
        private void SoruEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinavMDBDataSet.sinavSet' table. You can move, or remove it, as needed.
            this.sinavSetTableAdapter.Fill(this.sinavMDBDataSet.sinavSet);

        }

        private void btnekle_Click(object sender, EventArgs e)
        { 
            sinavDBModelContainer db = new sinavDBModelContainer();
            sorular s = new sorular();
            s.baslik = tbsoru.Text;
            s.cvpa = tbcvpa.Text;
            s.cvpb = tbcvpb.Text;
            s.cvpc = tbcvpc.Text;
            s.dogrucvp = tbdogrucvp.Text;

            s.adminID = Admin.fk_admin;
            s.sinavID = comboBox1.SelectedIndex;

            db.sorularSet.Add(s);
            try
            {
                db.SaveChanges();
                MessageBox.Show("Soru Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("KAYDETMEDİ ");
            }

        }
      
    }
}
