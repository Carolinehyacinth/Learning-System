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
    public partial class sendemail : Form
    {
        public sendemail()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            controller form = new controller();
            form.Show();
        }

        private void btnsend01_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select 邮箱 from tea_infor where 邮箱 like '%.com%'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int Num = dt.Rows.Count; 
            //邮件发送
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.163.com";
            client.Port = 25;
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = "13120513868@163.com";//mail.163.com上的帐号
            nc.Password = "123456a";//密码
            client.Credentials = nc;
            MailMessage msg = new MailMessage();//创建一个对象
            msg.Subject =rtxt主题.Text;//主题
            msg.Body = rtxt正文.Text;//正文
            msg.From = new MailAddress("13120513868@163.com");//发送人地址
            //从email中遍历地址
            for (int i = 0; i < Num; i++)
            {
                string dz = dt.Rows[i][0].ToString();
                string emailAddress = dz;
  
                 msg.To.Add(new MailAddress(emailAddress)); //收件人地址
            }   
   
            if(rtxt附件.Text!="")
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

        private void btnsend02_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=one;Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select 邮箱 from stu_infor where 邮箱 like '%.com%'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int Num = dt.Rows.Count;
            //邮件发送
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.163.com";
            client.Port = 25;
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = "13120513868@163.com";//mail.163.com上的帐号
            nc.Password = "123456a";//密码
            client.Credentials = nc;
            MailMessage msg = new MailMessage();//创建一个对象
            msg.Subject = rtxt主题.Text;//主题
            msg.Body = rtxt正文.Text;//正文
            msg.From = new MailAddress("13120513868@163.com");//发送人地址
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

        private void btnclr01_Click(object sender, EventArgs e)
        {
            rtxt主题.Text = null;
        }

        private void btnclr02_Click(object sender, EventArgs e)
        {
            rtxt正文.Text = null;
            rtxt附件.Text = null;
        }


    }
}
