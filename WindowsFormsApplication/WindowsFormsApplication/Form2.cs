using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class controller : Form
    {
        public controller()
        {
            InitializeComponent();
        }

        private void btncour_Click(object sender, EventArgs e)
        {
            this.Hide();
            courinfor form = new courinfor();
            form.Show();
        }

        private void btnstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            stuinfor form = new stuinfor();
            form.Show();
        }

        private void btntea_Click(object sender, EventArgs e)
        {
            this.Hide();
            teainfor form = new teainfor();
            form.Show();
        }

        private void btnnews_Click(object sender, EventArgs e)
        {
            this.Hide();
            sendemail form = new sendemail();
            form.Show();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            inforadd form = new inforadd();
            form.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

      
    }
}
