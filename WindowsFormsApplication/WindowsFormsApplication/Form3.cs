using System;
using System.Collections.Generic;
using System.Collections; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.IO;
using System.Net;
using System.Data.SqlClient;

namespace WindowsFormsApplication
{
    public partial class student : Form
    {
        Int32 stunum = app.value;    
        String courname = null;
        String cournum = null;
        String teanum = null;
        String teaname = null;
        String sstunum = null; 
        String str = null; 
        string str1 = null;
        public student()
        {
            InitializeComponent();
        }

        private void btnclr05_Click(object sender, EventArgs e)
        {
            rtxt主题 = null;
            rtxt正文 = null;
            rtxt附件 = null;
        }

        private void btnsend05_Click(object sender, EventArgs e)
        {
            courname = txtcourname05.Text;
            string stuemail = null;
            string stuepawd = null;
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select 邮箱,密码 from stu_infor where 学号 =" + stunum, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            stuemail = dt1.Rows[0][0].ToString();
            stuepawd = dt1.Rows[0][1].ToString();
            str = "(select homework.学号 as 学号,cour_infor.课程名 as 课程名,tea_infor.邮箱 as 教师邮箱 from homework left join tea_infor on tea_infor.工号 = homework.工号 left join cour_infor on cour_infor.课程号 = homework.课程号) as homework";
            SqlCommand cmd = new SqlCommand("select 教师邮箱 from " +str +" where 教师邮箱 like '%.com%' and 学号 = "+ stunum +" and 课程名 = '"+ courname +"';", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int Num = dt.Rows.Count;
            
            //邮件发送
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.163.com";
            client.Port = 25;
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = stuemail;//mail.163.com上的帐号
            nc.Password = stuepawd;//密码
            client.Credentials = nc;
            MailMessage msg = new MailMessage();//创建一个对象
            msg.Subject = rtxt主题.Text;//主题
            msg.Body = rtxt正文.Text;//正文
            msg.From = new MailAddress(stuemail);//发送人地址
            //从email中遍历地址
            for (int i = 0; i < Num; i++)
            {
                string dz = dt.Rows[i][0].ToString();
                string emailAddress = dz;

                msg.To.Add(new MailAddress(emailAddress)); //收件人地址
            }

            if (rtxt附件.Text != "")
            {
                Attachment mailAttach_1 = new Attachment(@rtxt附件.Text);//附件
                msg.Attachments.Add(mailAttach_1);
            }

            try
            {
                client.Send(msg);
                MessageBox.Show("发送成功", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("发送失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void btncan04_Click(object sender, EventArgs e)
        {
            txtcournum04.Text = null;
            txtcourname04.Text = null;
        }

        private void btnsub04_Click(object sender, EventArgs e)
        {
            sstunum = Convert.ToString(stunum);
            cournum = txtcournum04.Text;
            courname = txtcourname04.Text;
            int a = 0;
            if (CB作业情况.CheckState == CheckState.Checked && CB成绩查询.CheckState == CheckState.Unchecked)
            {
                a = 1;
                str = "select * from (select cour_infor.课程名 as 课程名,homework.* From homework left join cour_infor on cour_infor.课程号 = homework.课程号) as homework ";
            }
            else if (CB作业情况.CheckState == CheckState.Unchecked && CB成绩查询.CheckState == CheckState.Checked)
            {
                a = 1;
                str = "select * from (select cour_infor.课程名 as 课程名,record.* From record left join cour_infor on cour_infor.课程号 = record.课程号) as record ";
            }
            else if (CB作业情况.CheckState == CheckState.Checked && CB成绩查询.CheckState == CheckState.Checked)
            {
                MessageBox.Show("仅可选择作业情况或成绩查询！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                str = null;
            }
            else
            {
                MessageBox.Show("请选择作业情况或成绩查询！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Fuzzy_query(dt1, "学号", sstunum);
                Fuzzy_query(dt1, "课程号", cournum);
                Fuzzy_query(dt1, "课程名", courname);
                dt1.Columns.Remove("学号");
                dt1.Columns.Remove("课程号");
                dt1.Columns.Remove("工号");
                this.dataGridView4.DataSource = dt1;
            }
        }

        private void btncancel02_Click(object sender, EventArgs e)
        {
            txtcournum02.Text = null;
            txtcourname02.Text = null;
            txtteanum02.Text = null;
            txtteaname02.Text = null;
            txtcredit.Text = null;
            txttime.Text = null;
        }

        private void btnsubmit02_Click(object sender, EventArgs e)
        {
            cournum = txtcournum02.Text;
            courname = txtcourname02.Text;
            teanum = txtteanum02.Text;
            teaname = txtteaname02.Text;
            string credit = txtcredit.Text;
            string time = txttime.Text;
            str1 = "(select cour_infor.课程号 as 课程号, cour_infor.课程名 as 课程名, teaching.教师号 as 教师号, tea_infor.姓名 as 教师名,cour_infor.学分 as 学分, teaching.时间 as 时间, teaching.教室 as 教室 FROM teaching left join tea_infor on tea_infor.工号 = teaching.工号 left join cour_infor on cour_infor.课程号 = teaching.课程号)";
            str = "select * from " + str1 + "as teaching where 课程号 like'%" + cournum + "%' and 课程名 like'%" + courname + "%' and 教师号 like'%" + teanum + "%' and 教师名 like'%" + teaname + "%' and 时间 like'%" + time + "%' and 学分 like'%" + credit + "%'";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(str, conn);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd1);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            this.dataGridView2.DataSource = dt2;
        }

        private void btncan03_Click(object sender, EventArgs e)
        {
            txtteaname03.Text = null;
            txtcourname03.Text = null;
        }

        private void btnsub03_Click(object sender, EventArgs e)
        {
            sstunum = Convert.ToString(stunum);
            teaname = txtteaname03.Text;
            courname = txtcourname03.Text;
            str = "select * from (select cour_infor.课程名 as 课程名,tea_infor.姓名 as 教师名,tea_eval.* from tea_eval left join cour_infor on cour_infor.课程号 = tea_eval.课程号 left join tea_infor on tea_infor.工号 = tea_eval.工号)as tea_eval ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "学号", sstunum);
            Fuzzy_query(dt1, "教师名", teaname);
            Fuzzy_query(dt1, "课程名", courname);
            dt1.Columns.Remove("学号");
            dt1.Columns.Remove("课程号");
            dt1.Columns.Remove("工号");
            this.dataGridView3.DataSource = dt1;
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

        private void student_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from stu_infor where 学号 = " + stunum + ";", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            txtstunum01.Text = dt1.Rows[0][0].ToString();
            txtstuname01.Text = dt1.Rows[0][1].ToString();
            txtemail01.Text = dt1.Rows[0][2].ToString();
            txtpswd01.Text = dt1.Rows[0][3].ToString();
            txt绩点01.Text = dt1.Rows[0][4].ToString();
            conn.Close();
        }


    }
}
