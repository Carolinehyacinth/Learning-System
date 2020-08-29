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

    public partial class stuinfor : Form
    {
        String stunum;//学号   
        String stuname;//姓名
        String cournum; //课程号
        String courname;//课程名
        String teanum;//工号
        String teaname;//教师名
        string str1 = null;
        string str = null;
        int a = 0;
        class db
        {
            public static SqlConnection Systemcon()
            {
                return new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            }
        }  
        public stuinfor()
        {
            InitializeComponent();
        }

        private void btnsub01_Click(object sender, EventArgs e)
        {
            stunum = txtstunum01.Text;
            stuname = txtstuname01.Text;
            cournum = txtcournum01.Text;
            courname = txtcourname01.Text;
            str1 = "(select stu_infor.学号 as 学号, stu_infor.姓名 as 姓名,cour_infor.课程号 as 课程号,cour_infor.课程名 as 课程名,record.平时成绩 as 平时成绩,record.考试成绩 as 考试成绩,record.总评 as 总评,record.绩点 as 绩点 From record left join stu_infor on stu_infor.学号 = record.学号 left join cour_infor on cour_infor.课程号 = record.课程号)";
            str = "select * from " + str1 + "as record where 学号 like'%" + stunum + "%' and 姓名 like'%" + stuname + "%' and 课程号 like'%" + cournum + "%' and 课程名 like'%" + courname + "%'";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            this.dataGridView1.DataSource = dt1;
       
        }
        private void btncan01_Click(object sender, EventArgs e)
        {
            txtstunum01.Text = null;
            txtstuname01.Text = null;
            txtcournum01.Text = null;
            txtcourname01.Text = null;
        }
        private void btn排序01_Click(object sender, EventArgs e)
        {
            string column = "";
            stunum = txtstunum01.Text;
            stuname = txtstuname01.Text;
            cournum = txtcournum01.Text;
            courname = txtcourname01.Text;
            str1 = "(select stu_infor.学号 as 学号, stu_infor.姓名 as 姓名,cour_infor.课程号 as 课程号,cour_infor.课程名 as 课程名,record.平时成绩 as 平时成绩,record.考试成绩 as 考试成绩,record.总评 as 总评,record.绩点 as 绩点 From record left join stu_infor on stu_infor.学号 = record.学号 left join cour_infor on cour_infor.课程号 = record.课程号)";
            str = "select * from " + str1 + "as record where 学号 like'%" + stunum + "%' and 姓名 like'%" + stuname + "%' and 课程号 like'%" + cournum + "%' and 课程名 like'%" + courname + "%'";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            if (CB学号.CheckState == CheckState.Checked)
            {
                column = "学号";
            }
            else if (CB单科绩点.CheckState == CheckState.Checked)
            {
                column = "绩点";
            }
            else if (CB考试成绩.CheckState == CheckState.Checked)
            {
                column = "考试成绩";
            }
            else if (CB平时成绩.CheckState == CheckState.Checked)
            {
                column = "平时成绩";
            }
            else
            {
                MessageBox.Show("请选择排序条件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtn降序.Checked)
            {
                Order_down(dt1, column);
            }
            else if (rbtn升序.Checked)
            {
                Order_up(dt1, column);
            }
            else
            {
                MessageBox.Show("请选择排序方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.dataGridView1.DataSource = dt1;

        }
        private void btnsub02_Click(object sender, EventArgs e)
        {
            stunum = txtstunum02.Text;
            stuname = txtstuname02.Text;
            if (CB竞赛.CheckState == CheckState.Checked && CB获奖.CheckState == CheckState.Unchecked)
            {
                a = 1;
                str = "select * from (select stu_infor.学号 as 学号, stu_infor.姓名 as 姓名,competition.竞赛名称 as 竞赛名称 From competition left join stu_infor on stu_infor.学号 = competition.学号) as competition ";
            }
            else if (CB竞赛.CheckState == CheckState.Unchecked && CB获奖.CheckState == CheckState.Checked)
            {
                a = 1;
                str = "select * from (select stu_infor.学号 as 学号, stu_infor.姓名 as 姓名,award.获奖名称 as 获奖名称 From award left join stu_infor on stu_infor.学号 = award.学号) as award ";
            }
            else if (CB竞赛.CheckState == CheckState.Checked && CB获奖.CheckState == CheckState.Checked)
            {
                MessageBox.Show("仅可选择竞赛或获奖！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                str = null;
            }
            else
            { 
                MessageBox.Show("请选择竞赛或获奖！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                str = null; 
            }
            if (a == 1)
            {
                SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn.Open();
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                adapter.Fill(dt1);
                conn.Close();
                Fuzzy_query(dt1, "学号", stunum);
                Fuzzy_query(dt1, "姓名", stuname);
                this.dataGridView2.DataSource = dt1;
            }
        }
        private void btncan02_Click(object sender, EventArgs e)
        {
            txtstunum02.Text = null;
            txtstuname02.Text = null;
        }
        private void btnsub03_Click(object sender, EventArgs e)
        {
            stunum = txtstunum03.Text;
            stuname = txtstuname03.Text;
            string name = txt学术交流03.Text;
            str = "select * from (select stu_infor.学号 as 学号, stu_infor.姓名 as 姓名,aca_ex.学术交流名称 as 学术交流 From aca_ex left join stu_infor on stu_infor.学号 = aca_ex.学号) as aca_ex ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", stunum);
            Fuzzy_query(dt1, "姓名", stuname);
            Fuzzy_query(dt1, "学术交流", name);
            this.dataGridView3.DataSource = dt1;
        }
        private void btncan03_Click(object sender, EventArgs e)
        {
            txtstunum03.Text = null;
            txtstuname03.Text = null;
            txt学术交流03.Text= null;
        }
        private void btnsub04_Click(object sender, EventArgs e)
        {
            stunum = txtstunum04.Text;
            stuname = txtstuname04.Text;
            cournum = txtcournum04.Text;
            courname = txtcourname04.Text;
            teanum = txtteanum04.Text;
            teaname = txtteaname04.Text;
            str1 = "stu_infor.姓名 as 学生姓名,cour_infor.课程名 as 课程名,tea_infor.姓名 as 教师姓名,homework.*";
            str = "select * from (select " + str1 + " From homework left join stu_infor on stu_infor.学号 = homework.学号 left join cour_infor on cour_infor.课程号 = homework.课程号 left join tea_infor on tea_infor.工号 = homework.工号) as homework ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", stunum);
            Fuzzy_query(dt1, "学生姓名", stuname);
            Fuzzy_query(dt1, "课程号", cournum);
            Fuzzy_query(dt1, "课程名", courname);
            Fuzzy_query(dt1, "工号", teanum);
            Fuzzy_query(dt1, "教师姓名", teaname);
            dt1.Columns["教师姓名"].SetOrdinal(5);
            dt1.Columns["课程名"].SetOrdinal(3);
            dt1.Columns["学生姓名"].SetOrdinal(1);
            dt1.Columns.Remove("工号");
            dt1.Columns.Remove("课程号");
            this.dataGridView4.DataSource = dt1;
        }
        private void btncan04_Click(object sender, EventArgs e)
        {
            txtstunum04.Text = null;
            txtstuname04.Text = null;
            txtcournum04.Text = null;
            txtcourname04.Text = null;
            txtteanum04.Text = null;
            txtteaname04.Text = null;
        }
        private void btnsub05_Click(object sender, EventArgs e)
        {
            stunum = txtstunum05.Text;
            stuname = txtstuname05.Text;
            string problem = txt事件05.Text;
            str = "select * from (select stu_infor.学号 as 学号, stu_infor.姓名 as 姓名,punish.事件,punish.严重程度 From punish left join stu_infor on stu_infor.学号 = punish.学号) as punish ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", stunum);
            Fuzzy_query(dt1, "姓名", stuname);
            Fuzzy_query(dt1, "事件", problem);
            this.dataGridView5.DataSource = dt1;
        }
        private void btncan05_Click(object sender, EventArgs e)
        {
            txtstunum05.Text = null;
            txtstuname05.Text = null;
            txt事件05.Text = null;
        }
        private void btn排序05_Click(object sender, EventArgs e)
        {
            string column = "";
            stunum = txtstunum01.Text;
            stuname = txtstuname01.Text;
            string problem = txt事件05.Text;
            str = "select * from (select stu_infor.学号 as 学号, stu_infor.姓名 as 姓名,punish.事件,punish.严重程度 From punish left join stu_infor on stu_infor.学号 = punish.学号) as punish ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", stunum);
            Fuzzy_query(dt1, "姓名", stuname);
            Fuzzy_query(dt1, "事件", problem);
            if (CB严重程度.CheckState == CheckState.Checked)
            {
                column = "严重程度";
            }
            else if (CB学号05.CheckState == CheckState.Checked)
            {
                column = "学号";
            }
            else
            {
                MessageBox.Show("请选择排序条件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtn降序05.Checked)
            {
                Order_down(dt1, column);
            }
            else if (rbtn升序05.Checked)
            {
                Order_up(dt1, column);
            }
            else
            {
                MessageBox.Show("请选择排序方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.dataGridView5.DataSource = dt1;

        }
        private void btnsub06_Click(object sender, EventArgs e)
        {
            stunum = txtstunum06.Text;
            stuname = txtstuname06.Text;
            str = "select * from stu_infor";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", stunum);
            Fuzzy_query(dt1, "姓名", stuname);
            this.dataGridView6.DataSource = dt1;
        }
        private void btncan06_Click(object sender, EventArgs e)
        {
            txtstunum06.Text = null;
            txtstuname06.Text = null;
        }
        private void btnsub07_Click(object sender, EventArgs e)
        {
            stunum = txtstunum07.Text;
            stuname = txtstuname07.Text;
            cournum = txtcournum07.Text;
            courname = txtcourname07.Text;
            teanum = txtteanum07.Text;
            teaname = txtteaname07.Text;

            str1 = "stu_infor.姓名 as 学生姓名,cour_infor.课程名 as 课程名,tea_infor.姓名 as 教师姓名,register.*";
            str = "select * from (select " + str1 + " From register left join stu_infor on stu_infor.学号 = register.学号 left join cour_infor on cour_infor.课程号 = register.课程号 left join tea_infor on tea_infor.工号 = register.工号) as register ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", stunum);
            Fuzzy_query(dt1, "学生姓名", stuname);
            Fuzzy_query(dt1, "课程号", cournum);
            Fuzzy_query(dt1, "课程名", courname);
            Fuzzy_query(dt1, "工号", teanum);
            Fuzzy_query(dt1, "教师姓名", teaname);
            dt1.Columns["教师姓名"].SetOrdinal(5);
            dt1.Columns["课程名"].SetOrdinal(3);
            dt1.Columns["学生姓名"].SetOrdinal(1);
            dt1.Columns.Remove("工号");
            dt1.Columns.Remove("课程号");
            this.dataGridView7.DataSource = dt1;
        }
        private void btncan07_Click(object sender, EventArgs e)
        {
            txtstunum07.Text = null;
            txtstuname07.Text = null;
            txtcournum07.Text = null;
            txtcourname07.Text = null;
            txtteanum07.Text = null;
            txtteaname07.Text = null;
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller form = new controller();
            form.Show();
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

        private void btn排序06_Click(object sender, EventArgs e)
        {
            string column = "";
            stunum = txtstunum06.Text;
            stuname = txtstuname06.Text;
            str = "select * from stu_infor";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", stunum);
            Fuzzy_query(dt1, "姓名", stuname);
            if (CB平均绩点.CheckState == CheckState.Checked)
            {
                column = "绩点";
            }
            else if (CB学号06.CheckState == CheckState.Checked)
            {
                column = "学号";
            }
            else
            {
                MessageBox.Show("请选择排序条件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbtn降序06.Checked)
            {
                Order_down(dt1, column);
            }
            else if (rbtn升序06.Checked)
            {
                Order_up(dt1, column);
            }
            else
            {
                MessageBox.Show("请选择排序方式", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.dataGridView6.DataSource = dt1;
        }
    }
}
