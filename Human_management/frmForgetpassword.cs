using Human_management.Modle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_management
{
    public partial class frmForgetpassword : Form
    {
        public frmForgetpassword()
        {
            InitializeComponent();
        }

        private void btnGuiEmailPassword_Click(object sender, EventArgs e)
        {
            // Thông tin tài khoản email
            string senderEmail = "info.hrm2024@gmail.com";
            string senderPassword = "hrm2024@";

            // Thông tin người nhận
            string recipientEmail = txtEmail.Text.Trim();


            //Kiểm tra username trong database
            string connectionString = $"Host='localhost'; User ID = 'postgres'; Database='HRM'; Port='5432'; Password='1'";
            string selectQuery = $"select password from tbl_account where username='{txtUsername.Text}'";

            Class_pgdatabase pgdata = new Class_pgdatabase();
            DataTable dt = pgdata.getDataTable(connectionString, selectQuery);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show(dt.Rows[0]["password"].ToString());

                string password = dt.Rows[0]["password"].ToString();

                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(recipientEmail);
                mailMessage.From = new MailAddress(senderEmail);
                mailMessage.Subject = "Quên mật khẩu phần mềm quản lý nhân sự";                                                     
                mailMessage.Body = "Xin chào, mật khẩu của bạn là {password}";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                // Gửi email
                try
                {
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Mật khẩu đã được gửi, vui lòng kiểm tra email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không gửi được email, lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đăng nhập không tồn tại trong phần mềm này");
            }
            
        }


        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
