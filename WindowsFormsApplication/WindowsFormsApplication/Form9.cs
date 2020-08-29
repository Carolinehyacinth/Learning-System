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
    public partial class inforadd : Form
    {
        String name; //姓名
        String num;//号码
        String email;//邮箱
        String pswd;//密码
        String num2;//编号
        public inforadd()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller form = new controller();
            form.Show();
        }
        private void btnadd01_Click(object sender, EventArgs e)
        {
            name = txtname01.Text;
            num = txtnum01.Text;
            email = txtemail01.Text;
            pswd = txtpswd01.Text;
            string pswd2 = txtpswd012.Text;
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tea_infor where 工号 = " + num, conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n == 0 && (num != "" && name != "" && pswd != ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into login values (3,'" + name + "','" + pswd + "');", conn1);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("insert into tea_infor values (" + num + ",'" + name + "','" + email + "','" + pswd2 + "',0); ", conn1);
                cmd2.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == "" || name == "" || pswd == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该教师信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr01_Click(object sender, EventArgs e)
        {
            txtname01.Text = null;
            txtnum01.Text = null;
            txtemail01.Text = null;
            txtpswd012.Text = null;
        }

        private void btnadd02_Click(object sender, EventArgs e)
        {
            name = txtname02.Text;
            num = txtnum02.Text;
            email = txtemail02.Text;
            pswd = txtpswd02.Text;
            string pswd2 = txtpswd022.Text;
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from stu_infor where 学号 = " + num, conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n == 0 && (num != "" && name != "" && pswd != ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into login values (2,'" + name + "'," + pswd + ");", conn1);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("insert into stu_infor values (" + num + ",'" + name + "','" + email + "'," + pswd2 + ",0); ", conn1);
                cmd2.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == "" || name == "" || pswd == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该学生信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr02_Click(object sender, EventArgs e)
        {
            txtname02.Text = null;
            txtnum02.Text = null;
            txtemail02.Text = null;
            txtpswd022.Text = null;
        }

        private void btnadd03_Click(object sender, EventArgs e)
        {
            name = txtname03.Text;
            num = txtnum03.Text;
            string credit = txtcredit03.Text;
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from cour_infor where 课程号 = " + num, conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n == 0 && (num != "" && name != "" && credit != ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into cour_infor values (" + num + ",'" + name + "'," + credit +"); ", conn1);
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == "" || name == "" || credit == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该课程信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr03_Click(object sender, EventArgs e)
        {
            txtname03.Text = null;
            txtnum03.Text = null;
            txtcredit03.Text = null;
        }

        private void btnadd04_Click(object sender, EventArgs e)
        {
            string cournum = txtcournum04.Text;
            string teanum = txtteanum04.Text;
            string teachingnum = txt教师号04.Text;
            string room = txtclass04.Text;
            string time = txttime04.Text;
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from teaching where 课程号 = " + cournum +" and (工号 = "+ teanum +"or 教师号 = "+ teachingnum +");" , conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            SqlCommand cmd3 = new SqlCommand("select * from cour_infor where 课程号 = " + cournum +";", conn);
            int n3 = Convert.ToInt32(cmd.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("select * from tea_infor where 工号 = " + teanum + ";", conn);
            int n2 = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n2 == 0)
            { 
                MessageBox.Show("保存失败，不存在该教师", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (n3 == 0)
            {
                MessageBox.Show("保存失败，不存在该课程", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (n == 0 && (cournum != "" && teanum != "" && teachingnum != "" && room != "" && time!= ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into teaching values (" + cournum + "," + teanum + "," + teachingnum + ",'" + time + "','" + room + "'); ", conn1);
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cournum == "" || teanum == "" || teachingnum == "" || room == "" || time == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该任课关系", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr04_Click(object sender, EventArgs e)
        {
            txtcournum04.Text = null;
            txtteanum04.Text = null;
            txt教师号04.Text = null;
            txtclass04.Text = null;
            txttime04.Text = null;
        }

        private void btnadd05_Click(object sender, EventArgs e)
        {
            name = txtname05.Text;
            num = txtnum05.Text;
            num2 = txtn05.Text;
            if (num2 == "") { num2 = "0"; }
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from competition where 学号 = " + num +"and 竞赛名称 = '"+ name +"'", conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("select * from stu_infor where 学号 = " + num + ";", conn);
            int n2 = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n2 == 0)
            {
                MessageBox.Show("保存失败，不存在该学生", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (n == 0 && (num != "" && name != ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into competition values (" + num + "," + num2 + ",'" + name+ "');", conn1);
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == "" || name == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该竞赛信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr05_Click(object sender, EventArgs e)
        {
            txtname05.Text = null;
            txtn05.Text = null;
            txtnum05.Text = null;
        }

        private void btnadd06_Click(object sender, EventArgs e)
        {
            name = txtname06.Text;
            num = txtnum06.Text;
            num2 = txtn06.Text;
            if (num2 == "") { num2 = "0"; }
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from award where 学号 = " + num + "and 获奖名称 = '" + name + "'", conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("select * from stu_infor where 学号 = " + num + ";", conn);
            int n2 = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n2 == 0)
            {
                MessageBox.Show("保存失败，不存在该学生", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (n == 0 && (num != "" && name != ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into award values (" + num + "," + num2 + ",'" + name + "');", conn1);
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == "" || name == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该获奖信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr06_Click(object sender, EventArgs e)
        {
            txtname06.Text = null;
            txtn06.Text = null;
            txtnum06.Text = null;
        }

        private void btnadd07_Click(object sender, EventArgs e)
        {
            name = txtname07.Text;
            num = txtnum07.Text;
            num2 = txtn07.Text;
            string date = txtdate07.Text;
            if (num2 == "") { num2 = "0"; }
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from aca_ex where 学号 = " + num + "and 学术交流名称 = '" + name + "'", conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("select * from stu_infor where 学号 = " + num + ";", conn);
            int n2 = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n2 == 0)
            {
                MessageBox.Show("保存失败，不存在该学生", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (n == 0 && (num != "" && name != ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into aca_ex values (" + num + "," + num2 + ",'" + name + "','"+date+"');", conn1);
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == "" || name == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该学术交流信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr07_Click(object sender, EventArgs e)
        {
            txtname07.Text = null;
            txtn07.Text = null;
            txtnum07.Text = null;
        }

        private void btnadd08_Click(object sender, EventArgs e)
        {
            name = txtname08.Text;
            num = txtnum08.Text;
            num2 = txtn08.Text;
            SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from punish where 学号 = " + num + "and 事件 = '" + name + "'", conn);
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("select * from stu_infor where 学号 = " + num + ";", conn);
            int n2 = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (n2 == 0)
            {
                MessageBox.Show("保存失败，不存在该学生", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (n == 0 && (num != "" && name != ""))
            {
                SqlConnection conn1 = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into punish values (" + num + "," + num2 + ",'" + name + "');", conn1);
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (num == "" || name == "")
            {
                MessageBox.Show("保存失败，请完善信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("保存失败，系统内已保存该不良记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclr08_Click(object sender, EventArgs e)
        {
            txtname08.Text = null;
            txtn08.Text = null;
            txtnum08.Text = null;
        }
    }
}
