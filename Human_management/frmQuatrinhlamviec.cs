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
    public partial class frmQuatrinhlamviec : Form
    {
        Class_pgdatabase pgdatabase = new Class_pgdatabase();
        public string sql = "";
        private string _manhansu;
        public frmQuatrinhlamviec(string manhansu)
        {
            InitializeComponent();
            _manhansu = manhansu;
        }

        private void frmQuatrinhlamviec_Load(object sender, EventArgs e)
        {
            load_quatrinhlamviec();
        }

        public void load_quatrinhlamviec()
        {
            string sql = "SELECT ns.manhansu, ns.hoten, cd.tenchucdanh, pb.tenphongban, ctns.ngaybatdau, ctns.ngayketthuc " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietnhansu AS ctns ON ns.manhansu = ctns.manhansu " +
                "INNER JOIN public.tbl_chucdanh AS cd ON ctns.machucdanh = cd.machucdanh " +
                "INNER JOIN public.tbl_phongban AS pb ON ctns.maphongban = pb.maphongban " +
                "WHERE ns.manhansu LIKE '"+ _manhansu +"' AND ns.ishienthi AND ctns.isnhanvien;";
            DataTable datatable = new DataTable();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGV_quatrinhlamviec.DataSource = datatable;
                dGV_quatrinhlamviec.AutoGenerateColumns = false;
            }
        }


    }
}
