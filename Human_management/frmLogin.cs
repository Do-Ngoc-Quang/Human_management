using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Human_management.Modle;
using Npgsql;


namespace Human_management
{
    public partial class frmLogin : Form
    {
        private frmRegister frmRegister;
        private frmForgetpassword frmForgetpw;
        private bool isloggined = false;
        public string sql = "";

        public frmLogin()
        {
            InitializeComponent();
            InitializeFrmRegister();
            InitializeFrmForgetpssword();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            resetValue();
        }

        private void InitializeFrmRegister()
        {
            frmRegister = new frmRegister();
            frmRegister.FormClosed += (s, args) =>
            {
                this.Show();
                frmRegister = null; // Đặt lại tham chiếu thành null sau khi form bị đóng
            };
        }

        private void InitializeFrmForgetpssword()
        {
            frmForgetpw = new frmForgetpassword();
            frmForgetpw.FormClosed += (s, args) =>
            {
                this.Show();
                frmForgetpw = null; // Đặt lại tham chiếu thành null sau khi form bị đóng
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Class_pgdatabase pgdatabase = new Class_pgdatabase();

            //Lấy id 
            sql = "SELECT id FROM public.tbl_users WHERE username='" + txtUsername.Text + "' and password = '" + txtPassword.Text + "';";
            int id_user = pgdatabase.getid(Class_connect.connection_pg, sql);

            //Kiểm tra xem có phải isadmin không, isadmin[true] = số id : isadmin[false] = 0 
            sql = "SELECT id FROM public.tbl_users WHERE username='" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'  AND isadmin;";
            int isadmin = pgdatabase.getid(Class_connect.connection_pg, sql);

            if (id_user != 0)
            {
                this.Hide();
                isloggined = true;
                frmMain frmmain = new frmMain(this, isloggined, id_user.ToString(), isadmin, txtUsername.Text);
                frmmain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }


        private void lblRegister_Click(object sender, EventArgs e)
        {
            if (frmRegister == null || frmRegister.IsDisposed)
            {
                frmRegister = new frmRegister();
                frmRegister.FormClosed += (s, args) => this.Show();
            }

            this.Hide();
            frmRegister.Show();
        }

        private void lblForgetpassword_Click(object sender, EventArgs e)
        {
            if (frmForgetpw == null || frmForgetpw.IsDisposed)
            {
                frmForgetpw = new frmForgetpassword();
                frmForgetpw.FormClosed += (s, args) => this.Show();
            }

            this.Hide();
            frmForgetpw.Show();

        }
        public void resetValue()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi sự kiện Click của button1
                btnLogin.PerformClick();
            }
        }
    }
}
