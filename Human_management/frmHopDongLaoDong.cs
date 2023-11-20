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
            load_loaihopdong();
            load_capbac();
            load_trocap();
        }

        private void load_loaihopdong()
        {
            string sql = "SELECT maloaihopdong, tenloaidongdong, thoihan FROM public.tbl_loaihopdonglaodong;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_maloaihopdong.DataSource = datatable;
            cbb_maloaihopdong.DisplayMember = "tenloaidongdong";
            cbb_maloaihopdong.ValueMember = "maloaihopdong";

        }

        private void load_capbac()
        {
            string sql = "SELECT macapbac, mucluongcoban FROM public.tbl_luongcoban;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_maloaihopdong.DataSource = datatable;
            cbb_maloaihopdong.DisplayMember = "mucluongcoban";
            cbb_maloaihopdong.ValueMember = "macapbac";

            txt_luongcoban.Text = "mucluongcoban";
        }

        private void load_trocap()
        {
            string sql = "SELECT matrocap, tentrocap, muctrocap FROM public.tbl_trocap;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_maloaihopdong.DataSource = datatable;
            cbb_maloaihopdong.DisplayMember = "tentrocap";
            cbb_maloaihopdong.ValueMember = "matrocap";

            txt_tentrocap.Text = "tentrocap";
            txt_muctrocap.Text = "muctrocap";
        }
    }
}
