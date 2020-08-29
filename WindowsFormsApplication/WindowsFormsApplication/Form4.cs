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
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApplication
{
    public partial class teacher : Form
    {
        Int32 teanum = app.value;
        String courname;
        String cournum;
        String str = null;
        string tteanum = null;

        public teacher()
        {
            InitializeComponent();
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tea_infor where 工号 = " + teanum + ";", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            txtteanum01.Text = dt1.Rows[0][0].ToString();
            txtteaname01.Text = dt1.Rows[0][1].ToString();
            txtemail01.Text = dt1.Rows[0][2].ToString();
            txtpswd01.Text = dt1.Rows[0][3].ToString();
            txt评估01.Text = dt1.Rows[0][4].ToString();
            conn.Close();
        }

        private void btnsub02_Click(object sender, EventArgs e)
        {
            tteanum = Convert.ToString(teanum);
            cournum = txtcournum02.Text;
            courname = txtcourname02.Text;
            str = "select * from (select cour_infor.课程名 as 课程名,stu_infor.姓名 as 姓名,register.* from register left join cour_infor on cour_infor.课程号 = register.课程号 left join stu_infor on stu_infor.学号 = register.学号)as register ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "工号", tteanum);
            Fuzzy_query(dt1, "课程号", cournum);
            Fuzzy_query(dt1, "课程名", courname);
            dt1.Columns.Remove("课程名");
            dt1.Columns.Remove("课程号");
            dt1.Columns.Remove("工号");
            dt1.Columns["姓名"].SetOrdinal(1);
            this.dataGridView2.DataSource = dt1;

        }

        private void btncan02_Click(object sender, EventArgs e)
        {
            txtcourname02.Text = null;
            txtcournum02.Text = null;
        }

        private void btncan03_Click(object sender, EventArgs e)
        {
            txtcourname03.Text = null;
            txtcournum03.Text = null;
        }

        private void btnsub03_Click(object sender, EventArgs e)
        {
            tteanum = Convert.ToString(teanum);
            cournum = txtcournum03.Text;
            courname = txtcourname03.Text;
            str = "select * from (select cour_infor.课程名 as 课程名,stu_infor.姓名 as 学生姓名,homework.* from homework left join cour_infor on cour_infor.课程号 = homework.课程号 left join stu_infor on stu_infor.学号 = homework.学号)as homework ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "工号", tteanum);
            Fuzzy_query(dt1, "课程号", cournum);
            Fuzzy_query(dt1, "课程名", courname);
            dt1.Columns.Remove("课程名");
            dt1.Columns.Remove("课程号");
            dt1.Columns.Remove("工号");
            dt1.Columns["学生姓名"].SetOrdinal(1);
            this.dataGridView3.DataSource = dt1;
        }

        private void btnsub04_Click(object sender, EventArgs e)
        {
            tteanum = Convert.ToString(teanum);
            cournum = txtcournum04.Text;
            courname = txtcourname04.Text;
            str = "select * from (select cour_infor.课程名 as 课程名,stu_infor.姓名 as 学生姓名,record.* from record left join cour_infor on cour_infor.课程号 = record.课程号 left join stu_infor on stu_infor.学号 = record.学号)as record ";
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            conn.Close();
            Fuzzy_query(dt1, "工号", tteanum);
            Fuzzy_query(dt1, "课程号", cournum);
            Fuzzy_query(dt1, "课程名", courname);
            dt1.Columns.Remove("课程名");
            dt1.Columns.Remove("课程号");
            dt1.Columns.Remove("工号");
            dt1.Columns["学生姓名"].SetOrdinal(1);
            this.dataGridView4.DataSource = dt1;
        }

        private void btncan04_Click(object sender, EventArgs e)
        {
            txtcourname04.Text = null;
            txtcournum04.Text = null;
        }

        private void btnclr05_Click(object sender, EventArgs e)
        {
            rtxt主题 = null;
            rtxt正文 = null;
            rtxt附件 = null;
            txtcourname05 = null;
        }

        private void btnsend05_Click(object sender, EventArgs e)
        {
            courname = txtcourname05.Text;
            string teaemail = null;
            string teaepawd = null;
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select 邮箱,密码 from tea_infor where 工号 =" + teanum, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            teaemail = dt1.Rows[0][0].ToString();
            teaepawd = dt1.Rows[0][1].ToString();
            str = "(select homework.工号 as 工号,cour_infor.课程名 as 课程名,stu_infor.邮箱 as 学生邮箱 from homework left join stu_infor on stu_infor.学号 = homework.学号 left join cour_infor on cour_infor.课程号 = homework.课程号) as homework";
            SqlCommand cmd = new SqlCommand("select 学生邮箱 from " + str + " where 学生邮箱 like '%.com%' and 工号 = " + teanum + " and 课程名 = '" + courname + "';", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int Num = dt.Rows.Count;
            //邮件发送
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.163.com";
            client.Port = 25;
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = teaemail;//mail.163.com上的帐号
            nc.Password = teaepawd;//密码
            client.Credentials = nc;
            MailMessage msg = new MailMessage();//创建一个对象
            msg.Subject = rtxt主题.Text;//主题
            msg.Body = rtxt正文.Text;//正文
            msg.From = new MailAddress(teaemail);//发送人地址
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

        private void 导出考勤表_Click(object sender, EventArgs e)
        {
            ExportDataGridview(dataGridView2);
        }
        public bool ExportDataGridview(DataGridView gridView)
        {
            if (gridView.Rows.Count == 0)
                return false;
            //建立Excel对象
            Excel.Application excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = true;
            //生成字段名称
            for (int i = 0; i < gridView.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = gridView.Columns[i].HeaderText;
            }
            //填充数据
            for (int i = 0; i < gridView.RowCount - 1; i++)
            {
                for (int j = 0; j < gridView.ColumnCount; j++)
                {
                    if (gridView[j, i].ValueType == typeof(string))
                    {
                        excel.Cells[i + 2, j + 1] = "'" + gridView[j, i].Value.ToString();
                    }
                    else
                    {
                        excel.Cells[i + 2, j + 1] = gridView[j, i].Value.ToString();
                    }
                }
            }
            return true;
        }       
    }
}
