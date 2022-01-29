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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        sinavDBModelContainer db = new sinavDBModelContainer();
        public static int fk_admin=1;
        private void btngiris_Click(object sender, EventArgs e)
        {
            var data = db.admin1Set.Where(x => x.isim == tbad.Text && x.sifre == tbsifre.Text).ToList();
            if(data.Count==1)
            {                
                Form2 f = new Form2();
                f.Show();                          
            }
            else
            {
                MessageBox.Show("geçersiz şifre!");
            }

       }
       
    }
}
