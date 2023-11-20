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
    public partial class frmGhiNhanDaoTao : Form
    {
        private Class_pgdatabase pgdatabase;
        private string sql = "";

        frmDaoTao _frm;
        protected string _maphongban;
        protected string _manhansu;

        public frmGhiNhanDaoTao(frmDaoTao frm, string maphongban, string manhansu)
        {
            InitializeComponent();
            _frm = frm;
            _maphongban = maphongban;
            _manhansu = manhansu;
        }

        private void frmGhiNhanDaoTao_Load(object sender, EventArgs e)
        {
            load_dsdaotao();
        }

        public void load_dsdaotao()
        {
            dGV_dsdaotao.DataSource = null;

            string sql = "SELECT dt.id_daotao, ctns.manhansu AS mns, dt.madaotao AS mdt, dt.tendaotao, ctdt.ketqua " +
                "FROM public.tbl_daotao AS dt LEFT JOIN public.tbd_chitietdaotao AS ctdt ON dt.maphongban = ctdt.maphongban_ctdt " +
                "INNER JOIN public.tbd_chitietnhansu AS ctns ON ctdt.manhansu_ctdt = ctns.manhansu " +
                "WHERE dt.maphongban = '" + _maphongban + "' AND ctns.manhansu = '" + _manhansu + "'  AND ctdt.madaotao_ctdt IS NULL " +
                "AND NOT EXISTS (SELECT ctdt2.madaotao_ctdt FROM public.tbd_chitietdaotao AS ctdt2 " +
                "WHERE dt.madaotao = ctdt2.madaotao_ctdt AND ctdt2.maphongban_ctdt = '" + _maphongban + "' AND ctdt2.manhansu_ctdt = '" + _manhansu + "');";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGV_dsdaotao.DataSource = datatable;
                dGV_dsdaotao.AutoGenerateColumns = false;
            }
        }

        private void dGV_dsdaotao_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Ghi nhận thông tin hoàn tất quá trình đào tạo
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dGV_dsdaotao.Rows[e.RowIndex].Cells[1].Value is string mns)
                {
                    string mdt = (string)dGV_dsdaotao.Rows[e.RowIndex].Cells[2].Value;
                    string tendaotao = (string)dGV_dsdaotao.Rows[e.RowIndex].Cells[3].Value;

                    frmHoanTatQuaTrinhDaoTao frm = new frmHoanTatQuaTrinhDaoTao(this, mns, mdt, tendaotao, _maphongban);
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Giá trị là null hoặc không phải kiểu string.");
                }
            }

        }

        private void frmGhiNhanDaoTao_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm.load_kehoachdaotao(_maphongban, _manhansu);
            _frm.load_ketquadaotao(_manhansu);
        }
    }
}
