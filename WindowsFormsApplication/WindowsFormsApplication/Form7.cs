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
    public partial class teainfor : Form
    {   
        String courname;//课程名
        String teaname;//教师名
        String teanum;//教师号
        String cournum;//课程号
        string str = null;
        class db
        {
            public static SqlConnection Systemcon()
            {
                return new SqlConnection("Data Source = VAIO;Initial Catalog = one;Integrated Security=SSPI");
            }
        }  
        public teainfor()
        {
            InitializeComponent();
        }
        private void btnsub01_Click(object sender, EventArgs e)
        {
            teanum = txtteanum01.Text;
            teaname = txtteaname01.Text;
            str = "select * from tea_infor";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "工号", teanum);
            Fuzzy_query(dt1, "姓名", teaname);
            this.dataGridView1.DataSource = dt1;
        }
        public static DataTable Order_up(DataTable dt, string str)
        {
            string mid;
            int index;
            int i, j, k;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                index = i;
                for (j = i + 1; j < dt.Rows.Count; j++)
                {
                    if (Convert.ToDouble(dt.Rows[index][str]) > Convert.ToDouble(dt.Rows[j][str]))
                    {
                        index = j;
                    }
                }
                for (k = 0; k < dt.Columns.Count; k++)
                {
                    mid = dt.Rows[index][k].ToString();
                    dt.Rows[index][k] = dt.Rows[i][k];
                    dt.Rows[i][k] = mid;
                }
            }
            return dt;
        }
        public static DataTable Order_down(DataTable dt, string str)
        {
            string mid;
            int index;
            int i, j, k;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                index = i;
                for (j = i + 1; j < dt.Rows.Count; j++)
                {
                    if (Convert.ToDouble(dt.Rows[index][str]) < Convert.ToDouble(dt.Rows[j][str]))
                    {
                        index = j;
                    }
                }
                for (k = 0; k < dt.Columns.Count; k++)
                {
                    mid = dt.Rows[index][k].ToString();
                    dt.Rows[index][k] = dt.Rows[i][k];
                    dt.Rows[i][k] = mid;
                }
            }
            return dt;
        }
        public static DataTable Exact_query(DataTable dt, string column, string key)
        {
            int num = dt.Rows.Count;
            int i;
            for (i = 0; i < num; i++)
            {
                if (dt.Rows[i][column].ToString() != key)
                {
                    dt.Rows[i].Delete();
                }
            }
            dt.AcceptChanges();
            return dt;
        }
        public static DataTable Fuzzy_query(DataTable dt, string column, string key)
        {
            int num = dt.Rows.Count;
            int n1 = key.Length;
            int i, k, n2;
            string content;
            for (i = 0; i < num; i++)
            {
                content = dt.Rows[i][column].ToString();
                n2 = content.Length;
                k = 0;
                while (n2 >= n1)
                {
                    if (content.Substring(0, n1) == key)
                    {
                        k = 1;
                        break;
                    }
                    else
                    {
                        content = content.Remove(0, 1);
                        n2--;
                    }
                }
                if (k == 0)
                {
                    dt.Rows[i].Delete();
                }
            }
            dt.AcceptChanges();
            return dt;
        }

        private void btncan01_Click(object sender, EventArgs e)
        {
            txtteanum01.Text = null;
            txtteaname01.Text = null;
        }

        private void btnsub02_Click(object sender, EventArgs e)
        {
            teanum = txtteanum02.Text;
            teaname = txtteaname02.Text;
            cournum = txtcournum02.Text;
            courname = txtcourname02.Text;
            str = "select * from (select tea_infor.姓名 as 教师名,teaching.教师号 as 教师号,cour_infor.课程号 as 课程号,cour_infor.课程名 as 课程名,stu_infor.学号 as 学号, stu_infor.姓名 as 学生姓名 from tea_eval left join stu_infor on stu_infor.学号 = tea_eval.学号 left join cour_infor on cour_infor.课程号 = tea_eval.课程号 left join teaching on teaching.工号 = tea_eval.工号 left join tea_infor on tea_infor.工号 = tea_eval.工号)as tea_eval ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "教师号", teanum);
            Fuzzy_query(dt1, "教师名", teaname);
            Fuzzy_query(dt1, "课程号", cournum);
            Fuzzy_query(dt1, "课程名", courname);
            dt1.Columns.Remove("教师号");
            dt1.Columns.Remove("学号");
            dt1.Columns.Remove("课程号");
            this.dataGridView2.DataSource = dt1;
        }

        private void btncan02_Click(object sender, EventArgs e)
        {
            txtteanum02.Text = null;
            txtteaname02.Text = null;
            txtcournum02.Text = null;
            txtcourname02.Text = null;
        }

        private void btnsub03_Click(object sender, EventArgs e)
        {
            teanum = txtteanum03.Text;
            teaname = txtteaname03.Text;
            cournum = txtcournum03.Text;
            courname = txtcourname03.Text;
            str = "select * from (select tea_infor.姓名 as 教师名,teaching.教师号 as 教师号,cour_infor.课程名 as 课程名,tea_eval.* from tea_eval left join cour_infor on cour_infor.课程号 = tea_eval.课程号 left join teaching on teaching.工号 = tea_eval.工号 left join tea_infor on tea_infor.工号 = tea_eval.工号)as tea_eval ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "教师号", teanum);
            Fuzzy_query(dt1, "教师名", teaname);
            Fuzzy_query(dt1, "课程号", cournum);
            Fuzzy_query(dt1, "课程名", courname);
            dt1.Columns.Remove("教师号");
            dt1.Columns.Remove("学号");
            dt1.Columns.Remove("课程号");
            dt1.Columns.Remove("工号");
            this.dataGridView3.DataSource = dt1;
        }

        private void btncan03_Click(object sender, EventArgs e)
        {
            txtteanum03.Text = null;
            txtteaname03.Text = null;
            txtcournum03.Text = null;
            txtcourname03.Text = null;
        }

        private void btn排序01_Click(object sender, EventArgs e)
        {
            string column = "";
            teanum = txtteanum01.Text;
            teaname = txtteaname01.Text;
            str = "select * from tea_infor ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "工号", teanum);
            Fuzzy_query(dt1, "姓名", teaname);
            if (CB教学评估.CheckState == CheckState.Checked)
            {
                column = "评估";
            }
            else if (CB工号01.CheckState == CheckState.Checked)
            {
                column = "工号";
            }
            else
            {
                MessageBox.Show("请选择排序条件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtn降序01.Checked)
            {
                Order_down(dt1, column);
            }
            else if (rbtn升序01.Checked)
            {
                Order_up(dt1, column);
            }
            else
            {
                MessageBox.Show("请选择排序方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.dataGridView1.DataSource = dt1;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller form = new controller();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teainfor_Load(object sender, EventArgs e)
        {

        }
    }
}
