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



namespace WindowsFormsApplication
{
    public partial class courinfor : Form
    {
        String cournum; //课程号
        String courname;//课程名
        String teanum;//教师号   
        String teaname;//教师名
        String credit;//学分   
        String time;//时间
        string str1 = "(select cour_infor.课程号 as 课程号, cour_infor.课程名 as 课程名, teaching.教师号 as 教师号, tea_infor.姓名 as 教师名,cour_infor.学分 as 学分, teaching.时间 as 时间, teaching.教室 as 教室 FROM teaching left join tea_infor on tea_infor.工号 = teaching.工号 left join cour_infor on cour_infor.课程号 = teaching.课程号)";
        string str = null;
        class db
        {
            public static SqlConnection Systemcon()
            {
                return new SqlConnection("Data Source = VAIO;Initial Catalog = one;Integrated Security=SSPI");
            }
        }  
        public courinfor()
        {
            InitializeComponent();
        }
        private void btnsubmit01_Click(object sender, EventArgs e)
        {
            cournum = txtcournum01.Text;
            teanum = txtteanum01.Text;

            if (cournum == "" || teanum == "")
            {
                MessageBox.Show("请输入课程号与教师号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from " + str1 + "as teaching where 课程号 ='" + cournum + "'and 教师号 = '" + teanum + "'", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                this.dataGridView1.DataSource = dt1;
            }

        }
        private void btncancel01_Click(object sender, EventArgs e)
        {
            txtcournum01.Text = null;
            txtteanum01.Text = null;
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller form = new controller();
            form.Show();
        }
        private void btnsubmit02_Click(object sender, EventArgs e)
        {
            cournum = txtcournum02.Text;
            courname = txtcourname.Text;
            teanum = txtteanum02.Text;
            teaname = txtteaname.Text;
            credit = txtcredit.Text;
            time = txttime.Text;
            str = null;
            str = "select * from " + str1 + "as teaching where 课程号 like'%" + cournum + "%' and 课程名 like'%" + courname + "%' and 教师号 like'%" + teanum + "%' and 教师名 like'%" + teaname + "%' and 时间 like'%" + time + "%' and 学分 like'%" + credit + "%'" ;
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(str,conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            this.dataGridView2.DataSource = dt2;
        }
        private void btncancel02_Click(object sender, EventArgs e)
        {
            txtcournum02.Text = null;
            txtcourname.Text = null; 
            txtteanum02.Text = null;
            txtteaname.Text = null;
            txtcredit.Text = null;
            txttime.Text = null;
        }

    }
}
