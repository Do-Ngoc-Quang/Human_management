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
        public string _id_user;

        public frmQuyenLoiPhucLoi(string id_user)
        {
            InitializeComponent();
            _id_user = id_user;
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
            //----------------------------------------------   -------------------------------------------//
            txtMaNhanSu.Text = dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString();

            //---------------------------------------------- NGHỈ PHÉP -------------------------------------------//
            int countDay_start_to_now = int.Parse(pgdatabase.getValue(Class_connect.connection_pg, "SELECT " +
                "EXTRACT(year FROM AGE(NOW(), ngaybatdau)) * 365 + EXTRACT(month FROM AGE(NOW(), ngaybatdau)) * 30 + EXTRACT(day FROM AGE(NOW(), ngaybatdau)) AS phepnam " +
                "FROM public.tbd_chitietnhansu WHERE manhansu = '" + dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString() + "';"));
            int tongPhepNam = countDay_start_to_now/30;
            txt_TongPhepNam.Text = tongPhepNam.ToString();

            txtPhepnamdanghi.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT SUM(songay) FROM public.tbd_chitietnghiphep " +
                "WHERE manghiphep = 'phepnam' AND manhansu_ctnp = '" + dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString() + "';");

            //---------------------------------------------- ĐÀO TẠO -------------------------------------------//
            txt_SLdaotao.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT COUNT(id_ctdt) FROM public.tbd_chitietdaotao " +
                "WHERE manhansu_ctdt = '" + dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString() + "' AND ketqua;");
        }

        private void btn_nhansunghiphep_Click(object sender, EventArgs e)
        {
            frmNhanSuNghiPhep frm = new frmNhanSuNghiPhep(txtMaNhanSu.Text.ToString());
            frm.Show();
        }

        private void btn_Taobangluong_Click(object sender, EventArgs e)
        {

            frmTaoBangLuong frm = new frmTaoBangLuong(txtMaNhanSu.Text, _id_user);
            frm.Show();
        }
    }
}
