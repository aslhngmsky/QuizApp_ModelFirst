using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ModelFirst_18440038
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        string b, selectedvalue;
        string dogrucvp;
        int i;
         int skor=0;
         
        sinavDBModelContainer db = new sinavDBModelContainer();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-37V5P3S;Initial Catalog=sinavMDB;Integrated Security=True");

 

        private void test_Load(object sender, EventArgs e)
        {
            sorular s = new sorular();
           
            label4.Text = skor.ToString();
            SqlCommand komut = new SqlCommand("select * from sorularSet", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
           dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            DataGridViewRow r = dataGridView1.CurrentRow;
            rba.Text = r.Cells[2].Value.ToString();
            rbb.Text = r.Cells[3].Value.ToString();
            rbc.Text = r.Cells[4].Value.ToString();
            dogrucvp = s.dogrucvp;
            Admin.fk_admin = s.adminID;
          
        }

        private void btnsonra_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var sonraki = db.sorularSet.Where(y => y.ID == id).FirstOrDefault();
            rba.Text = sonraki.cvpa;
            rba.Text = sonraki.cvpb;
            rbc.Text = sonraki.cvpc;
            db.SaveChanges();
          

            if(rba.Checked==true)
            {
               
                selectedvalue=rba.Text;           
            }
            else if(rbb.Checked==true)
            {
               
                selectedvalue = rbb.Text;
            }
            else if (rbc.Checked == true)
            {
               
                selectedvalue = rbc.Text;
            }      
            else
            {
             
                MessageBox.Show("şık işaretlemedin");
            }
           

            if(selectedvalue.Equals(dogrucvp))
            {
                skor++;
                label4.Text = skor.ToString();
            }

            sorular s = new sorular(); 
            if(s.ID.Equals(""))
            {
                MessageBox.Show("SINAV BİTTİ");
                btnsonra.Enabled = false;
            }
            else
            {
                int rowIndex = 0;
                if (rowIndex < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex + 1].Selected = true;
                }  

                SqlCommand komut1 = new SqlCommand("select * from sorularSet", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;    
            }           
            radiobtn();
        }

        public void radiobtn()
        {
            rba.Checked = false;
            rbb.Checked = false;
            rbc.Checked = false;
        }
    
    }
}
