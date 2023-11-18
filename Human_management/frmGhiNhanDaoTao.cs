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

        protected string _maphongban;
        protected string _manhansu;

        public frmGhiNhanDaoTao(string maphongban, string manhansu)
        {
            InitializeComponent();
            _maphongban = maphongban;
            _manhansu = manhansu;
        }

        private void frmGhiNhanDaoTao_Load(object sender, EventArgs e)
        {
            load_dsdaotao();
        }

        private void load_dsdaotao()
        {
            dGV_dsdaotao.DataSource = null;

            string sql = "SELECT dt.id_daotao, ctns.manhansu AS mns, dt.madaotao AS mdt, dt.tendaotao, ctdt.ketqua " +
                "FROM public.tbl_daotao AS dt INNER JOIN public.tbd_chitietdaotao AS ctdt ON dt.maphongban = ctdt.maphongban_ctdt " +
                "INNER JOIN public.tbd_chitietnhansu AS ctns ON ctdt.manhansu_ctdt = ctns.manhansu " +
                "INNER JOIN public.tbd_kehoachdaotao AS khdt ON dt.madaotao = khdt.madaotao " +
                "WHERE dt.maphongban = '" + _maphongban + "' AND ctns.manhansu = '"+ _manhansu +  "' AND ctdt.ketqua = false;";
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
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dGV_dsdaotao.Rows[e.RowIndex].Cells[1].Value is string mns)
                {
                    MessageBox.Show($"manhansu của hàng: {mns}");
                    //mở một form để điền thông tin khóa học và chứng nhận đã hoàn thành

                    //form: frmHoanTatQuaTrinhDaoTao
                    // - nếu manhansu_ctdt is not null and madaotao_ctdt is null thì update
                    // - nếu manhansu_ctdt is not null and madaotao_ctdt is not null thì thì insert thêm một dòng mới với cùng mã nhân sự
                }
                else
                {
                    MessageBox.Show("Giá trị là null hoặc không phải kiểu string.");
                }
            }

        }
    }
}
