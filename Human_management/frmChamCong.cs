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

using System.IO;
using Google.Apis.Sheets.v4.Data;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Sheets.v4;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;

namespace Human_management
{
    public partial class frmChamCong : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";


        public frmChamCong()
        {
            InitializeComponent();

            //Thanh tìm kiến hiển thị placeholder 
            txtTimMaNhanSu.Text = "Tìm kiếm theo mã hoặc tên nhân sự";
            txtTimMaNhanSu.ForeColor = SystemColors.GrayText;
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            load_dsnhansu();
            load_thang();
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

        public void load_thang()
        {
            string sql = "SELECT thang FROM public.tbl_thang";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_thang.DataSource = datatable;
            cbb_thang.DisplayMember = "thang";
            cbb_thang.ValueMember = "thang";
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
            sql = "SELECT ns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
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


        private void btn_reloadDGV_Click(object sender, EventArgs e)
        {
            load_dsnhansu();
        }



        private void dGVNhanSu_Click(object sender, EventArgs e)
        {
            string manhansu = dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString();

            //TỔNG QUAN
            sql = string.Format("SELECT count(ctcc.id) " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietchamcong AS ctcc ON ns.manhansu = ctcc.manhansu " +
                "WHERE ns.manhansu = '{0}'", manhansu);
            string songaycong = pgdatabase.getValue(Class_connect.connection_pg, sql);
            txt_songaycong.Text = songaycong.ToString();

            sql = string.Format("SELECT SUM(songay) FROM public.tbd_chitietnghiphep WHERE manhansu_ctnp = '{0}';", manhansu);
            string songaynghi = pgdatabase.getValue(Class_connect.connection_pg, sql);
            txt_songaynghiphep.Text = songaynghi.ToString();

            load_tongquan(manhansu);

            //CHI TIẾT
            load_chitiet(manhansu);
        }

        public void load_tongquan(string manhansu)
        {
            dGV_chitietnghiphep.DataSource = null; //reset dGV

            string sql = "SELECT ctnp.*, np.tennghiphep FROM public.tbd_chitietnghiphep AS ctnp " +
                "INNER JOIN public.tbl_nghiphep AS np ON ctnp.manghiphep = np.manghiphep " +
                "WHERE ctnp.manhansu_ctnp = '"+ manhansu +"'";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGV_chitietnghiphep.DataSource = datatable;
                dGV_chitietnghiphep.AutoGenerateColumns = false;
            }


        }

        public void load_chitiet(string manhansu)
        {
            dGV_chiitietchamcong.DataSource = null; //reset dGV

            string sql = "SELECT giovao, giora, sogiolamviec, ngayhientai FROM public.tbd_chitietchamcong WHERE manhansu = '"+ manhansu + "'";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGV_chiitietchamcong.DataSource = datatable;
                dGV_chiitietchamcong.AutoGenerateColumns = false;
            }
        }

        private void btn_taobangluong_Click(object sender, EventArgs e)
        {

        }
    }
}
