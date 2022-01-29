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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
       

        }

        private void btnogr_Click(object sender, EventArgs e)
        {
            test t = new test();
            t.Show();
            this.Close();
        }
    }
}
