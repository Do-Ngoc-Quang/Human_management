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
    public partial class frmNhanSuNghiPhep : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        private string _manhansu;
        public frmNhanSuNghiPhep(string manhansu)
        {
            InitializeComponent();
            _manhansu = manhansu;
        }

        private void frmNhanSuNghiPhep_Load(object sender, EventArgs e)
        {
            load_nghiphep();

            txtMaNhanSu.Text = _manhansu;
        }

        private void load_nghiphep()
        {
            string sql = "SELECT id, manghiphep, tennghiphep FROM public.tbl_nghiphep;";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbb_nghiphep.DataSource = datatable;
            cbb_nghiphep.DisplayMember = "tennghiphep";
            cbb_nghiphep.ValueMember = "manghiphep";
        }

        private void btn_capnhatnghiphep_Click(object sender, EventArgs e)
        {
            if (txtMaNhanSu.Text != "")
            {
                sql = string.Format("INSERT INTO public.tbd_chitietnghiphep(manhansu_ctnp, manghiphep, songay, ngaybatdau_ctnp, ngayketthuc_ctnp) " +
                    "VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}');", _manhansu, cbb_nghiphep.SelectedValue.ToString(),
                    txt_songaynghi.Text, dTP_ngaybatdau.Value, dTP_ngayketthuc.Value);

                bool kqua = pgdatabase.Runsql(Class_connect.connection_pg, sql);
                if (kqua)
                {
                    MessageBox.Show("Đăng kí nghỉ phép cho nhân sự thành công");
                }
            }
        }
    }
}
