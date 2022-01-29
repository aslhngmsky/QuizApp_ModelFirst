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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsinav_Click(object sender, EventArgs e)
        {
            SoruEkle s = new SoruEkle();
            s.Show();
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            ogrenciEkle o = new ogrenciEkle();
            o.Show();
        }
    }
}
