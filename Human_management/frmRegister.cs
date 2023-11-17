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
    public partial class frmRegister : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        //Thiết lập hình ảnh mặc định khi thêm mới một nhân sự
        protected string imageName = "default_account_1024px";

        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            load_gioitinh();
        }

        public void load_gioitinh()
        {
            string sql = "SELECT magioitinh,tengioitinh FROM public.tbl_gioitinh";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbbGioiTinh.DataSource = datatable;
            cbbGioiTinh.DisplayMember = "tengioitinh";
            cbbGioiTinh.ValueMember = "magioitinh";
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            erPRegister = new ErrorProvider();

            if (txtHoTen.Text == "")
            {
                erPRegister.SetError(txtHoTen, "Trường dữ liệu không được để trống!");
                txtHoTen.Focus();
            }
            else if (txtUsername.Text == "")
            {
                erPRegister.SetError(txtUsername, "Trường dữ liệu không được để trống!");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                erPRegister.SetError(txtPassword, "Trường dữ liệu không được để trống!");
                txtPassword.Focus();
            }
            else if (txtComfimPassword.Text == "")
            {
                erPRegister.SetError(txtComfimPassword, "Trường dữ liệu không được để trống!");
                txtComfimPassword.Focus();
            }
            else
            {
                pgdatabase = new Class_pgdatabase();

                //Lưu thông tin người dùng
                sql = "SELECT id FROM public.tbl_users WHERE username = '"+ txtUsername.Text +"';";
                int id = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (id == 0)
                {
                    //Tạo người dùng
                    sql = string.Format("INSERT INTO public.tbl_users(username, password, hovaten, gioitinh, ngaysinh, sodienthoai, email, diachi, avatar)" +
                        " VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", txtUsername.Text, txtPassword.Text, txtHoTen.Text,
                            cbbGioiTinh.SelectedValue.ToString(), dTP_ngaysinh.Value, txtSoDienThoai.Text, txtEmail.Text, txtDiaChi.Text, imageName);
                    bool kqua =  pgdatabase.Runsql(Class_connect.connection_pg, sql);

                    if (kqua)
                    {
                        MessageBox.Show("Đăng ký thành công");

                        //Tạo bảng phân quyền cho người dùng
                        sql = string.Format("INSERT INTO public.tbd_chitietphanquyen(username_ctpq) VALUES ('{0}');", txtUsername.Text);
                        pgdatabase.Runsql(Class_connect.connection_pg, sql);

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("'username' đã tồn tại, hãy thử lại", "Thông báo");
                } 
            }
        }

        private void txtComfimPassword_Leave(object sender, EventArgs e)
        {
            erPRegister = new ErrorProvider();
            if (txtPassword.Text != txtComfimPassword.Text)
            {
                erPRegister.SetError(txtComfimPassword, "Mật khẩu không trùng khớp");
                txtComfimPassword.Focus();
            }
        }

        private void returnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


    }
}
