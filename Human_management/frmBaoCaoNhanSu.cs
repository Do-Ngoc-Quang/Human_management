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
            cbb_phongban.SelectedItem = "all";
            this.rpvBaoCao.RefreshReport();
            load_phongban();
        }

        public void load_phongban()
        {
            string sql = "SELECT maphongban, tenphongban FROM public.tbl_phongban ORDER BY maphongban;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_phongban.DataSource = datatable;
            cbb_phongban.DisplayMember = "tenphongban";
            cbb_phongban.ValueMember = "maphongban";
        }

        private void btn_Taobaocao_Click(object sender, EventArgs e)
        {
            this.rpvBaoCao.LocalReport.DataSources.Clear();

            rpvBaoCao.LocalReport.ReportPath = @"C:\Do Ngoc Quang\HK1-Y3\HRM\Human_management\Human_management\ReportBaoCaoNhanSu.rdlc";

            string isall = "";
            if (cbb_phongban.SelectedValue.ToString() == "all")
            {
                isall = "";
            }
            else
            {
                isall = "AND ctns.maphongban = '" + cbb_phongban.SelectedValue.ToString() + "'";
            }

            sql = "SELECT ns.manhansu, ns.hoten, ns.gioitinh, TO_CHAR(ns.ngaysinh, 'DD/MM/YYYY') AS ngaysinh , ns.hocham, cd.tenchucdanh, pb.tenphongban," +
                " TO_CHAR(ctns.ngaybatdau, 'DD/MM/YYYY') AS ngaybatdau " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietnhansu AS ctns ON ns.manhansu = ctns.manhansu " +
                "INNER JOIN public.tbl_chucdanh AS cd ON cd.machucdanh = ctns.machucdanh INNER JOIN public.tbl_phongban AS pb ON pb.maphongban = ctns.maphongban " +
                "WHERE ns.ishienthi AND ctns.isnhanvien "+ isall +" ORDER BY ns.manhansu;";

            List<object_nhansu> list_nhansu = new List<object_nhansu>();
            pgdatabase = new Class_pgdatabase();
            DataTable dt = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object_nhansu nhansu = new object_nhansu();

                nhansu.manhansu = dt.Rows[i]["manhansu"].ToString();
                nhansu.hoten = dt.Rows[i]["hoten"].ToString();
                nhansu.gioitinh = dt.Rows[i]["gioitinh"].ToString();
                nhansu.ngaysinh = dt.Rows[i]["ngaysinh"].ToString();
                nhansu.hocham = dt.Rows[i]["hocham"].ToString();
                nhansu.tenchucdanh = dt.Rows[i]["tenchucdanh"].ToString();
                nhansu.tenphongban = dt.Rows[i]["tenphongban"].ToString();
                nhansu.ngaybatdau = dt.Rows[i]["ngaybatdau"].ToString();

                list_nhansu.Add(nhansu);
            }
       
            ReportDataSource danhsachnhansu_datasource = new ReportDataSource("DataSet_DSnhansu", list_nhansu);
            this.rpvBaoCao.LocalReport.DataSources.Add(danhsachnhansu_datasource);
            rpvBaoCao.RefreshReport();
            //rpvBaoCao.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //rpvBaoCao.ZoomMode = ZoomMode.FullPage;
            //rpvBaoCao.ZoomPercent = 100;
            rpvBaoCao.ZoomMode = ZoomMode.PageWidth;
        }
    }
}


