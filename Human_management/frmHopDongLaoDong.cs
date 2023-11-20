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
    public partial class frmHopDongLaoDong : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        public frmHopDongLaoDong()
        {
            InitializeComponent();
        }

        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            pgdatabase = new Class_pgdatabase();

            load_loaihopdong();
            load_capbac();
            load_trocap();
        }

        private void load_loaihopdong()
        {
            string sql = "SELECT maloaihopdong, tenloaidongdong FROM public.tbl_loaihopdonglaodong;";
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_loaihopdong.DataSource = datatable;
            cbb_loaihopdong.DisplayMember = "tenloaidongdong";
            cbb_loaihopdong.ValueMember = "maloaihopdong";

        }

        private void load_capbac()
        {
            string sql = "SELECT macapbac, mucluongcoban FROM public.tbl_luongcoban;";
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_capbac.DataSource = datatable;
            cbb_capbac.DisplayMember = "macapbac";
            cbb_capbac.ValueMember = "macapbac";
        }

        private void load_trocap()
        {
            string sql = "SELECT matrocap, tentrocap FROM public.tbl_trocap;";
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_trocap.DataSource = datatable;
            cbb_trocap.DisplayMember = "tentrocap";
            cbb_trocap.ValueMember = "matrocap";

        }

        private void cbb_loaihopdong_SelectedValueChanged(object sender, EventArgs e)
        {
            string maloaihopdong = cbb_loaihopdong.SelectedValue.ToString();

            txt_tenloaihopdong.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tenloaidongdong " +
                "FROM public.tbl_loaihopdonglaodong WHERE maloaihopdong = '" + maloaihopdong + "';");

            txt_thoihan.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT thoihan " +
                "FROM public.tbl_loaihopdonglaodong WHERE maloaihopdong = '" + maloaihopdong + "';");
        }

        private void cbb_capbac_SelectedValueChanged(object sender, EventArgs e)
        {
            string macapbac = cbb_capbac.SelectedValue.ToString();

            txt_luongcoban.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT mucluongcoban " +
                "FROM public.tbl_luongcoban WHERE macapbac = '" + macapbac + "';");
        }

        private void cbb_trocap_SelectedValueChanged(object sender, EventArgs e)
        {
            string matrocap = cbb_trocap.SelectedValue.ToString();

            txt_tentrocap.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tentrocap " +
                "FROM public.tbl_trocap WHERE matrocap = '" + matrocap + "';");
            txt_muctrocap.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT muctrocap " +
                "FROM public.tbl_trocap WHERE matrocap = '" + matrocap + "';");
        }

        private void dTP_ngaybatdau_ValueChanged(object sender, EventArgs e)
        {
            updateTime();
        }

        private void txt_thoihan_TextChanged(object sender, EventArgs e)
        {
            updateTime();
        }

        private void updateTime()
        {
            int thoihan = int.Parse(txt_thoihan.Text);
            DateTime currentDate = dTP_ngaybatdau.Value;
            DateTime newDate = currentDate.AddMonths(thoihan);

            dTP_ngayketthuc.Value = newDate;
        }
    }
}
