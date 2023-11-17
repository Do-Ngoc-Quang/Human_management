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
    public partial class frmTiepNhanVaBanGiaoCV : Form
    {
        private Class_pgdatabase pgdatabase;

        private string sql = "";
        private string _manhansu, _hoten;
        private frmXuLyQuaTrinhPhongVan _frm_parent;

        public frmTiepNhanVaBanGiaoCV(frmXuLyQuaTrinhPhongVan frm_parent, string manhansu, string hoten)
        {
            InitializeComponent();
            _manhansu = manhansu;
            _hoten = hoten;
            _frm_parent = frm_parent;
        }
        
        private void frmTiepNhanVaBanGiaoCV_Load(object sender, EventArgs e)
        {
            load_phongban();
            load_chucdanh();

            txtMaNhanSu.Text = _manhansu;
            txtHoTen.Text = _hoten;
        }

        //Load dữ liệu giới tính
        public void load_phongban()
        {
            string sql = "SELECT maphongban, tenphongban FROM public.tbl_phongban;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_phongban.DataSource = datatable;
            cbb_phongban.DisplayMember = "tenphongban";
            cbb_phongban.ValueMember = "maphongban";
        }

        //Load dữ liệu dân tộc
        public void load_chucdanh()
        {
            string sql = "SELECT machucdanh, tenchucdanh FROM public.tbl_chucdanh;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_chucdanh.DataSource = datatable;
            cbb_chucdanh.DisplayMember = "tenchucdanh";
            cbb_chucdanh.ValueMember = "machucdanh";
        }

        private void btn_bangiaonhansu_Click(object sender, EventArgs e)
        {
            if (_manhansu == "")
            {
                MessageBox.Show("Vui lòng chọn ứng viên trước khi thực hiện bàn giao.", "Thông báo");
            }
            else
            {
                bool kqua_ctns, kqua_ctpv = false;

                //Cập nhật trạng thái nhân viên
                //1. Cập nhật tình trạng việc làm thành ` VL01 - Đang làm việc ` 
                sql = string.Format("UPDATE public.tbd_nhansu SET tinhtrangvieclam='{0}'" +
                    " WHERE manhansu = '" + _manhansu + "';", "VL01");
                pgdatabase.Runsql(Class_connect.connection_pg, sql);

                //Cập nhật chi tiết nhân viên
                sql = string.Format("INSERT INTO public.tbd_chitietnhansu(manhansu, machucdanh, maphongban, ngaybatdau, isnhanvien)" +
                    " VALUES('{0}', '{1}', '{2}', '{3}', {4}); ", _manhansu, cbb_chucdanh.SelectedValue.ToString(), cbb_phongban.SelectedValue.ToString(), "now()", true);
                kqua_ctns = pgdatabase.Runsql(Class_connect.connection_pg, sql);

                //Cập nhật trạng thái quá trình phỏng vấn
                sql = "SELECT id_chitiet FROM public.tbd_chitietphongvan WHERE manhansu = '" + _manhansu + "'";
                int id_chitiet = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (id_chitiet != 0)
                {
                    sql = string.Format("UPDATE public.tbd_chitietphongvan SET manhansu='{0}', isnhanvien='{1}', machucdanh='{2}', maphongban='{3}', ishoantatquatrinh='{4}'" +
                        " WHERE id_chitiet = '" + id_chitiet + "';", _manhansu, true, cbb_chucdanh.SelectedValue.ToString(), cbb_phongban.SelectedValue.ToString(), true);
                    kqua_ctpv = pgdatabase.Runsql(Class_connect.connection_pg, sql);

                }

                if (kqua_ctns && kqua_ctpv)
                {
                    _frm_parent.load_dsnhansu();
                    this.Close();
                }
            }
        }
    }
}
