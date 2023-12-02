using Human_management.Modle;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_management
{
    public partial class frmBaoCaoNhanSu : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        public frmBaoCaoNhanSu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNhanSu_Load(object sender, EventArgs e)
        {
            this.rpvBaoCao.RefreshReport();
            load_phongban();
        }

        public void load_phongban()
        {
            string sql = "SELECT maphongban, tenphongban FROM public.tbl_phongban;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_phongban.DataSource = datatable;
            cbb_phongban.DisplayMember = "tenphongban";
            cbb_phongban.ValueMember = "maphongban";
        }

        private void btn_Taobaocao_Click(object sender, EventArgs e)
        {
            show_report(@"C:\Do Ngoc Quang\HK1-Y3\HRM\Human_management\Human_management\ReportBaoCaoNhanSu.rdlc");

        }
        
        public void show_report(string path)
        {
            rpvBaoCao.LocalReport.ReportPath = path;
            rpvBaoCao.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvBaoCao.ZoomMode = ZoomMode.FullPage;
            rpvBaoCao.ZoomPercent = 100;
        }
    }
}
