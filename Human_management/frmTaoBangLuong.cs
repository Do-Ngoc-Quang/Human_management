using Human_management.Modle;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_management
{
    public partial class frmTaoBangLuong : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        public string path = Application.StartupPath;

        public string _manhansu;
        public string _id_user;

        public frmTaoBangLuong(string manhansu, string id_user)
        {
            InitializeComponent();

            _manhansu = manhansu;
            _id_user = id_user;
        }

        private void frmTaoBangLuong_Load(object sender, EventArgs e)
        {
            // Lấy ngày và giờ hiện tại
            DateTime now = DateTime.Now;

            // Tách ngày, tháng, năm thành ba biến riêng
            String currentDay = now.Day.ToString();
            String currentMonth = now.Month.ToString();
            String currentYear = now.Year.ToString();

            pgdatabase = new Class_pgdatabase();

            show_report(currentDay, currentMonth, currentYear);
        }
        public void show_report(string currentDay, string currentMonth, string currentYear)
        {
            CultureInfo culture = new CultureInfo("vi-VN");

            this.rpV_Bangluong.LocalReport.DataSources.Clear();

            rpV_Bangluong.LocalReport.ReportPath = path + @"\report\ReportBangLuong.rdlc";

            //paramater ngay
            ReportParameter ngay = new ReportParameter("Rpm_ngay");
            ngay.Values.Add(string.Format("{0}", currentDay));
            this.rpV_Bangluong.LocalReport.SetParameters(ngay);

            //paramater thang
            ReportParameter thang = new ReportParameter("Rpm_thang");
            thang.Values.Add(string.Format("{0}", currentMonth));
            this.rpV_Bangluong.LocalReport.SetParameters(thang);

            //paramater nam
            ReportParameter nam = new ReportParameter("Rpm_nam");
            nam.Values.Add(string.Format("{0}", currentYear));
            this.rpV_Bangluong.LocalReport.SetParameters(nam);

            //paramater ngaycong
            sql = string.Format("SELECT count(ctcc.id) " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietchamcong AS ctcc " +
                "ON ns.manhansu = ctcc.manhansu WHERE ns.manhansu = '{0}'", _manhansu);
            int songaycong = int.Parse(pgdatabase.getValue(Class_connect.connection_pg, sql));
            ReportParameter ngaycong = new ReportParameter("Rpm_ngaycong");
            ngaycong.Values.Add(string.Format("{0}", songaycong.ToString()));
            this.rpV_Bangluong.LocalReport.SetParameters(ngaycong);

            //luongcoban
            int luongcoban = 0;
            sql = string.Format("SELECT lcb.mucluongcoban " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietnhansu AS ctns ON ns.manhansu = ctns.manhansu " +
                "INNER JOIN public.tbd_hopdonglaodong AS hdld ON hdld.manhansu = ns.manhansu " +
                "INNER JOIN public.tbl_luongcoban AS lcb ON lcb.macapbac = hdld.macapbac " +
                "WHERE ns.ishienthi AND ctns.isnhanvien AND ns.manhansu = '" + _manhansu + "';");
            luongcoban = int.Parse(pgdatabase.getValue(Class_connect.connection_pg, sql));

            //phucap
            int phucap = 0;
            sql = string.Format("SELECT tc.muctrocap " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietnhansu AS ctns ON ns.manhansu = ctns.manhansu " +
                "INNER JOIN public.tbd_hopdonglaodong AS hdld ON hdld.manhansu = ns.manhansu " +
                "INNER JOIN public.tbl_luongcoban AS lcb ON lcb.macapbac = hdld.macapbac " +
                "INNER JOIN public.tbl_trocap AS tc ON tc.matrocap = hdld.matrocap " +
                "WHERE ns.ishienthi AND ctns.isnhanvien AND ns.manhansu = '" + _manhansu + "'");
            phucap = int.Parse(pgdatabase.getValue(Class_connect.connection_pg, sql));

            //
            string hoten_ = "";

            //
            sql = "SELECT ns.manhansu, ns.hoten, cd.tenchucdanh as chucdanh, pb.tenphongban as phongban," +
                " lcb.mucluongcoban as luongcoban, tc.muctrocap as phucap " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietnhansu AS ctns ON ns.manhansu = ctns.manhansu " +
                "INNER JOIN public.tbl_chucdanh AS cd ON cd.machucdanh = ctns.machucdanh " +
                "INNER JOIN public.tbl_phongban AS pb ON pb.maphongban = ctns.maphongban " +
                "INNER JOIN public.tbd_hopdonglaodong AS hdld ON hdld.manhansu = ns.manhansu " +
                "INNER JOIN public.tbl_luongcoban AS lcb ON lcb.macapbac = hdld.macapbac " +
                "INNER JOIN public.tbl_trocap AS tc ON tc.matrocap = hdld.matrocap " +
                "WHERE ns.ishienthi AND ctns.isnhanvien AND ns.manhansu = '" + _manhansu + "'";

            List<object_bangluong> bangluong = new List<object_bangluong>();
            pgdatabase = new Class_pgdatabase();
            DataTable dt = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object_bangluong bl = new object_bangluong();

                bl.manhansu = dt.Rows[i]["manhansu"].ToString();
                bl.hoten = dt.Rows[i]["hoten"].ToString();
                hoten_ = dt.Rows[i]["hoten"].ToString();
                bl.chucdanh = dt.Rows[i]["chucdanh"].ToString();
                bl.phongban = dt.Rows[i]["phongban"].ToString();

                // Định dạng tiền tệ cho luongcoban
                decimal luongcobanValue;
                if (decimal.TryParse(dt.Rows[i]["luongcoban"].ToString(), out luongcobanValue))
                {
                    bl.luongcoban = luongcobanValue.ToString("C0", culture);
                }

                // Định dạng tiền tệ cho phucap
                decimal phucapValue;
                if (decimal.TryParse(dt.Rows[i]["phucap"].ToString(), out phucapValue))
                {
                    bl.phucap = phucapValue.ToString("C0", culture);
                }

                bangluong.Add(bl);
            }
            //paramater luongtheongay
            float luongtheongay = ((luongcoban / 20) * songaycong);
            ReportParameter luongngay = new ReportParameter("Rpm_luongtheongay");
            luongngay.Values.Add(string.Format("{0}", luongtheongay.ToString("C0", culture)));
            this.rpV_Bangluong.LocalReport.SetParameters(luongngay);

            //paramater tongkhoanthu
            float tongthu = luongtheongay + phucap;
            ReportParameter tongkhoanthu = new ReportParameter("Rpm_tongkhoanthu");
            tongkhoanthu.Values.Add(string.Format("{0}", tongthu.ToString("C0", culture)));
            this.rpV_Bangluong.LocalReport.SetParameters(tongkhoanthu);

            //paramater bhxh
            float tienbhxh = luongtheongay * (8.0f / 100);
            ReportParameter bhxh = new ReportParameter("Rpm_bhxh");
            bhxh.Values.Add(string.Format("{0}", tienbhxh.ToString("C0", culture)));
            this.rpV_Bangluong.LocalReport.SetParameters(bhxh);

            //paramater bhyt
            float tienbhyt = luongtheongay * (15f / 1000);
            ReportParameter bhyt = new ReportParameter("Rpm_bhyt");
            bhyt.Values.Add(string.Format("{0}", tienbhyt.ToString("C0", culture)));
            this.rpV_Bangluong.LocalReport.SetParameters(bhyt);

            //paramater tongkhoantru
            float tongtru = tienbhxh + tienbhyt;
            ReportParameter tongkhoantru = new ReportParameter("Rpm_tongkhoantru");
            tongkhoantru.Values.Add(string.Format("{0}", tongtru.ToString("C0", culture)));
            this.rpV_Bangluong.LocalReport.SetParameters(tongkhoantru);

            //paramater thucnhan
            ReportParameter thucnhan = new ReportParameter("Rpm_thucnhan");
            thucnhan.Values.Add(string.Format("{0}", (tongthu - tongtru).ToString("C0", culture)));
            this.rpV_Bangluong.LocalReport.SetParameters(thucnhan);

            //paramater nguoilapphieu
            sql = string.Format("SELECT hovaten FROM public.tbl_users WHERE id = '" + _id_user + "';");
            string nguoilapphieu = pgdatabase.getValue(Class_connect.connection_pg, sql);
            ReportParameter nguoilap = new ReportParameter("Rpm_nguoilapphieu");
            nguoilap.Values.Add(string.Format("{0}", nguoilapphieu));
            this.rpV_Bangluong.LocalReport.SetParameters(nguoilap);

            //paramater nguoinhantien
            ReportParameter nguoinhantien = new ReportParameter("Rpm_nguoinhantien");
            nguoinhantien.Values.Add(string.Format("{0}", hoten_));
            this.rpV_Bangluong.LocalReport.SetParameters(nguoinhantien);

            // ---
            ReportDataSource bangluong_datasource = new ReportDataSource("DataSet_BangLuong", bangluong);
            this.rpV_Bangluong.LocalReport.DataSources.Add(bangluong_datasource);

            rpV_Bangluong.RefreshReport();
            rpV_Bangluong.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
