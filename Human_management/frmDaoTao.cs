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
        private string sql = "";

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

            load_dsnhansu(maphongban);
        }

        private void dGVNhanSu_Click(object sender, EventArgs e)
        {
            string manhansu = dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString();

            load_kehoachdaotao(manhansu);
            load_ketquadaotao(manhansu);
        }


        private void load_kehoachdaotao(string manhansu)
        {
            dGV_kehoachdaotao.DataSource = null;
            string sql = "SELECT khdt.id_khdt, dt.tendaotao, (ctns.ngaybatdau + khdt.ycau_sothanglamviec * 30) AS dukiendaotao " +
                "FROM public.tbd_kehoachdaotao AS khdt INNER JOIN public.tbl_daotao AS dt ON dt.madaotao = khdt.madaotao" +
                " INNER JOIN public.tbd_chitietdaotao AS ctdt ON ctdt.madaotao_ctdt = khdt.madaotao" +
                " INNER JOIN public.tbd_chitietnhansu AS ctns ON ctns.manhansu = ctdt.manhansu_ctdt " +
                "WHERE ctdt.ketqua = false AND ctdt.manhansu_ctdt = '" + manhansu + "';";
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


    }
}
