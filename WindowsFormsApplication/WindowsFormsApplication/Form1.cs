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

    
    public partial class Login : Form
    {
        String uID; //user name 
        String uPswd;//user password   
        int power = 0;
        
        class db
        {
            public static SqlConnection Systemcon()
            {
                return new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
            }
        }  
        public Login()
        {
            InitializeComponent();
        }
        private void btncancel_Click_1(object sender, EventArgs e)
        {
            txtuser.Text = null;
            txtpswd.Text = null;
            power = 0;
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            uID = txtuser.Text;
            uPswd = txtpswd.Text;
            if (uID == "")
            {
                MessageBox.Show("请输入用户名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (uPswd == "")
            {
                MessageBox.Show("请输入密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (power == 0)
            {
                MessageBox.Show("请选择权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source = (local);Initial Catalog = one;Integrated Security=SSPI");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from login where Username ='" + uID + "'and password ='" + uPswd + "'", conn);
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                
                if (num == power)
                {
                    if (power == 1)
                    {
                        app.value = 1;                    
                        conn.Close();
                        MessageBox.Show("管理员登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        controller form = new controller();
                        form.Show();
                    }
                    else if (power == 2)
                    {
                        SqlCommand cmd1 = new SqlCommand("select * from stu_infor where 姓名 ='" + uID + "'", conn);
                        app.value = Convert.ToInt32(cmd1.ExecuteScalar());
                        conn.Close();
                        MessageBox.Show("学生登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        student form = new student();
                        form.Show();
                    }
                    else
                    {
                        SqlCommand cmd1 = new SqlCommand("select * from tea_infor where 姓名 ='" + uID + "'", conn);
                        app.value = Convert.ToInt32(cmd1.ExecuteScalar());
                        conn.Close();
                        MessageBox.Show("教师登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        teacher form = new teacher();
                        form.Show();
                    }       
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuser.Text = null;
                    txtpswd.Text = null;
                    
                }
            }
        }

        private void rbtnpower01_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnpower01.Checked)
            {
                power = 1;
            }
        }

        private void rbtnpower02_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnpower02.Checked)
            {
                power = 2;
            }
        }

        private void rbtnpower03_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnpower03.Checked)
            {
                power = 3;
            }
        }

    
       
    }
}
