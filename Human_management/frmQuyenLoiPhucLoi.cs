using CloudinaryDotNet;
using Human_management.Modle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_management
{
    public partial class frmQuyenLoiPhucLoi : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        //Khai báo biến toàn cục cho mục đích upload image to cloudinary
        protected string fullPath_imageUpload = "";
        private string imageName = "";

        //Cloudinary
        public Cloudinary cloudinary = null;
        Account account = new Account("hrmcloudinary", "336624331362197", "HR8ln3AxXVA05sAmpMi7pBLDAHA");

        public frmQuyenLoiPhucLoi()
        {
            InitializeComponent();
        }

        private void frmQuyenLoiPhucLoi_Load(object sender, EventArgs e)
        {
            load_dsnhansu();

            //Thanh tìm kiến hiển thị placeholder 
            txtTimMaNhanSu.Text = "Tìm kiếm theo mã hoặc tên nhân sự";
            txtTimMaNhanSu.ForeColor = SystemColors.GrayText;
        }

        public void load_dsnhansu()
        {
            string sql = "SELECT ns.*, ctns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
                "WHERE ns.ishienthi = true and ctns.isnhanvien = true; ";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }

        private void txtTimMaNhanSu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimMaNhanSu.Text))
            {
                txtTimMaNhanSu.Text = "Tìm kiếm theo mã hoặc tên nhân sự";
                txtTimMaNhanSu.ForeColor = SystemColors.GrayText; // Màu chữ mặc định khi không nhập
            }
        }

        private void txtTimMaNhanSu_Enter(object sender, EventArgs e)
        {
            if (txtTimMaNhanSu.Text == "Tìm kiếm theo mã hoặc tên nhân sự")
            {
                txtTimMaNhanSu.Text = "";
                txtTimMaNhanSu.ForeColor = SystemColors.WindowText; // Thay đổi màu chữ khi viết
            }
        }

        private void txtTimMaNhanSu_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ns.*, ctns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
                "WHERE ns.manhansu LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%' and ns.ishienthi = true and ctns.isnhanvien = true " +
                "OR ns.hoten LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%' and ns.ishienthi = true and ctns.isnhanvien = true ;";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }

        private void dGVNhanSu_Click(object sender, EventArgs e)
        {
            txtMaNhanSu.Text = dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString();
        }

        private void btn_nhansunghiphep_Click(object sender, EventArgs e)
        {
            frmNhanSuNghiPhep frm = new frmNhanSuNghiPhep(txtMaNhanSu.Text.ToString());
            frm.Show();
        }


    }
}
