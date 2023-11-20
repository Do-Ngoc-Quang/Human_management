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
    public partial class frmDaoTao : Form
    {
        private Class_pgdatabase pgdatabase;

        protected string _maphongban;
        protected string _manhansu;

        public frmDaoTao()
        {
            InitializeComponent();
        }

        private void frmDaoTao_Load(object sender, EventArgs e)
        {
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

        public void load_dsnhansu(string maphongban)
        {
            string sql = "SELECT ns.*, ctns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
                "WHERE ns.ishienthi = true and ctns.isnhanvien = true and ctns.maphongban = '" + maphongban + "';";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }

        private void cbb_phongban_SelectedValueChanged(object sender, EventArgs e)
        {
            string maphongban = cbb_phongban.SelectedValue.ToString();

            txt_dadaotao.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT COUNT(id_ctdt) FROM public.tbd_chitietdaotao " +
                "WHERE maphongban_ctdt = '"+ maphongban +"' AND ketqua ;");
            txt_chuadaotao.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT COUNT(id_ctdt) FROM public.tbd_chitietdaotao " +
                "WHERE maphongban_ctdt = '"+ maphongban +"' AND ketqua = false;");

            load_dsnhansu(maphongban);
        }



        private void dGVNhanSu_Click(object sender, EventArgs e)
        {
            string maphongban = dGVNhanSu.CurrentRow.Cells["maphongban"].Value.ToString();
            string manhansu = dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString();

            _maphongban = maphongban;
            _manhansu = manhansu;

            load_kehoachdaotao(maphongban, manhansu);
            load_ketquadaotao(manhansu);
        }

        private void load_kehoachdaotao(string maphongban, string manhansu)
        {
            dGV_kehoachdaotao.DataSource = null;

            string sql = "SELECT dt.id_daotao, dt.tendaotao, (ctns.ngaybatdau + dt.ycau_sothanglamviec * 30) AS dukiendaotao " +
                "FROM public.tbl_daotao AS dt LEFT JOIN public.tbd_chitietdaotao AS ctdt ON dt.maphongban = ctdt.maphongban_ctdt " +
                "INNER JOIN public.tbd_chitietnhansu AS ctns ON ctdt.manhansu_ctdt = ctns.manhansu " +
                "WHERE dt.maphongban = '" + maphongban + "' AND ctns.manhansu = '" + manhansu + "'  AND ctdt.madaotao_ctdt IS NULL " +
                "AND NOT EXISTS (SELECT ctdt2.madaotao_ctdt FROM public.tbd_chitietdaotao AS ctdt2 " +
                "WHERE dt.madaotao = ctdt2.madaotao_ctdt AND ctdt2.maphongban_ctdt = '" + maphongban + "' AND ctdt2.manhansu_ctdt = '" + manhansu + "');";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGV_kehoachdaotao.DataSource = datatable;
                dGV_kehoachdaotao.AutoGenerateColumns = false;
            }
        }

        private void load_ketquadaotao(string manhansu)
        {
            dGV_hoanthanhdaotao.DataSource = null;

            string sql = "SELECT ctdt.id_ctdt, dt.tendaotao AS tendaodao_ctdt, ctdt.chungnhan " +
                "FROM public.tbd_chitietdaotao AS ctdt INNER JOIN public.tbl_daotao AS dt ON ctdt.madaotao_ctdt = dt.madaotao " +
                "WHERE ctdt.ketqua = true AND ctdt.manhansu_ctdt = '"+ manhansu +"';";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGV_hoanthanhdaotao.DataSource = datatable;
                dGV_hoanthanhdaotao.AutoGenerateColumns = false;
            }
        }

        private void btn_ghinhandaotao_Click(object sender, EventArgs e)
        {
            frmGhiNhanDaoTao frm = new frmGhiNhanDaoTao(_maphongban, _manhansu);
            frm.Show();
        }
    }
}
