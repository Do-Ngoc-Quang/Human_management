using Human_management.Modle;
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
    public partial class frmHopDongLaoDong : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";
        private string _manhansu;

        CultureInfo culture = new CultureInfo("vi-VN");

        public frmHopDongLaoDong(string manhansu)
        {
            InitializeComponent();
            _manhansu = manhansu;
        }

        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            pgdatabase = new Class_pgdatabase();
            load_loaihopdong();
            load_capbac();
            load_trocap();

            isHDLD();
            load_nhansu();

        }

        private void isHDLD()
        {
            sql = "SELECT id FROM public.tbd_hopdonglaodong WHERE manhansu = '" + _manhansu + "';";
            int id = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id != 0)
            {
                btnThietLapHDLD.Enabled = false;

                lbl_thongbao.Text = "(Đã gia hạn hợp đồng)";
                lbl_thongbao.Visible = true;
            }
        }

        private void load_nhansu()
        {
            txtMaNhanSu.Text = _manhansu;
            txtHoTen.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT hoten FROM public.tbd_nhansu WHERE manhansu = '"+ _manhansu + "';");
            dateTimePickerNgaySinh.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT ngaysinh FROM public.tbd_nhansu WHERE manhansu = '" + _manhansu + "';");
            txtCCCD.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT cccd FROM public.tbd_nhansu WHERE manhansu = '" + _manhansu + "';");
            txtEmail.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT email FROM public.tbd_nhansu WHERE manhansu = '" + _manhansu + "';");
            txtSoDienThoai.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT sodienthoai FROM public.tbd_nhansu WHERE manhansu = '" + _manhansu + "';");
            txtMaSoThue.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT masothue FROM public.tbd_nhansu WHERE manhansu = '" + _manhansu + "';");
            txtDCTamTru.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT diachitamtru FROM public.tbd_nhansu WHERE manhansu = '" + _manhansu + "';");

            sql = "SELECT id FROM public.tbd_hopdonglaodong WHERE manhansu = '" + _manhansu + "';";
            int id = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id != 0)
            {
                cbb_loaihopdong.SelectedValue = pgdatabase.getValue(Class_connect.connection_pg, "SELECT maloaihopdong FROM public.tbd_hopdonglaodong WHERE manhansu = '" + _manhansu + "';");
                cbb_capbac.SelectedValue = pgdatabase.getValue(Class_connect.connection_pg, "SELECT macapbac FROM public.tbd_hopdonglaodong WHERE manhansu = '" + _manhansu + "';");
                cbb_trocap.SelectedValue = pgdatabase.getValue(Class_connect.connection_pg, "SELECT matrocap FROM public.tbd_hopdonglaodong WHERE manhansu = '" + _manhansu + "';");
            }
            
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

            string mucluongcoban = pgdatabase.getValue(Class_connect.connection_pg, "SELECT mucluongcoban FROM public.tbl_luongcoban WHERE macapbac = '" + macapbac + "';");
            if (decimal.TryParse(mucluongcoban, out decimal mucluongcobanValue))
            {
                txt_luongcoban.Text = mucluongcobanValue.ToString("C0", culture);
            }
        }

        private void cbb_trocap_SelectedValueChanged(object sender, EventArgs e)
        {
            string matrocap = cbb_trocap.SelectedValue.ToString();

            txt_tentrocap.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tentrocap " +
                "FROM public.tbl_trocap WHERE matrocap = '" + matrocap + "';");

            string muctrocap = pgdatabase.getValue(Class_connect.connection_pg, "SELECT muctrocap FROM public.tbl_trocap WHERE matrocap = '" + matrocap + "';");
            if (decimal.TryParse(muctrocap, out decimal muctrocapValue))
            {
                txt_muctrocap.Text = muctrocapValue.ToString("C0", culture);
            }

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
            int thoihan;

            if (txt_thoihan.Text == "")
            {
                lbl_denngay.Text = "Vô thời hạn";
                dTP_ngayketthuc.Visible = false;
                //dTP_ngayketthuc.Value = null;
            }
            else
            {
                lbl_denngay.Text =  "Đến ngày";
                dTP_ngayketthuc.Visible = true;
                thoihan = int.Parse(txt_thoihan.Text);
                DateTime currentDate = dTP_ngaybatdau.Value;
                DateTime newDate = currentDate.AddMonths(thoihan);
                dTP_ngayketthuc.Value = newDate;
            }
        }

        private void btnThietLapHDLD_Click(object sender, EventArgs e)
        {
            sql = "SELECT id FROM public.tbd_hopdonglaodong WHERE manhansu = '" + _manhansu + "';";
            int id = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id == 0)
            {
                sql = string.Format("INSERT INTO public.tbd_hopdonglaodong(manhansu, maloaihopdong, macapbac, matrocap, thoihan, ngaybatdau, ngayketthuc, ishoantat) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", _manhansu, cbb_loaihopdong.SelectedValue.ToString(),
                    cbb_capbac.SelectedValue.ToString(), cbb_trocap.SelectedValue.ToString(), txt_thoihan.Text, dTP_ngaybatdau.Value, dTP_ngayketthuc.Value, true);
                bool kqua = pgdatabase.Runsql(Class_connect.connection_pg, sql);

                if (kqua)
                {
                    this.Close();
                }
            }
        }
    }
}
