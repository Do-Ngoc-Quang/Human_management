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
    public partial class frmPhanQuyen : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";
        bool isadim = false;


        public frmPhanQuyen()
        {
            InitializeComponent();


        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            load_dsnguoidung();


            //Thanh tìm kiến hiển thị placeholder 
            txt_timnguoidung.Text = "Tìm kiếm theo mã hoặc tên";
            txt_timnguoidung.ForeColor = SystemColors.GrayText;
        }
        public void load_dsnguoidung()
        {
            string sql = "SELECT * FROM public.tbl_users;";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGV_nguoidung.DataSource = datatable;
                dGV_nguoidung.AutoGenerateColumns = false;
            }
        }
        public void load_chitietphanquyen(string username)
        {
            if (username != "")
            {
                string sql = "SELECT * FROM public.tbd_chitietphanquyen WHERE username_ctpq = '" + username + "';";
                DataTable datatable = new DataTable();
                pgdatabase = new Class_pgdatabase();
                datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

                if (datatable.Rows.Count > 0)
                {
                    dGV_vaitro.DataSource = datatable;
                    dGV_vaitro.AutoGenerateColumns = false;
                }
            }
            else
            {
                dGV_vaitro.Refresh();
            }
        }


        private void dGV_nguoidung_Click(object sender, EventArgs e)
        {
            string username = dGV_nguoidung.CurrentRow.Cells["username"].Value.ToString();

            sql = "SELECT id FROM public.tbl_users WHERE username = '"+ username + "' and isadmin";
            int id = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id != 0)
            {
                txt_chucdanh.Text = "Admin";
                dGV_vaitro.ReadOnly = true;
            }
            else
            {
                txt_chucdanh.Text = "Nhân viên";
                dGV_vaitro.ReadOnly = false;
            }

            //Load phân quyền của từng người dùng
            load_chitietphanquyen(username);

        }



        private void txtTimMaNhanSu_Enter(object sender, EventArgs e)
        {

        }

        private void dGV_vaitro_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewColumn column = dGV_vaitro.Columns[e.ColumnIndex];

                // Kiểm tra nếu ô thay đổi là kiểu checkbox
                if (column is DataGridViewCheckBoxColumn)
                {
                    // Lấy name cột checkbox được thay đổi
                    string checkboxName = dGV_vaitro.Columns[e.ColumnIndex].Name;

                    // Thực hiện hành động với tên của checkbox
                    bool isChecked = (bool)dGV_vaitro[e.ColumnIndex, e.RowIndex].Value;

                    sql = string.Format("SELECT id_phanquyen FROM public.tbd_chitietphanquyen WHERE username_ctpq = '{0}';", dGV_vaitro.CurrentRow.Cells["username_ctpq"].Value.ToString());
                    int id = pgdatabase.getid(Class_connect.connection_pg, sql);

                    switch (checkboxName)
                    {
                        case "isxulynhaplieu":
                            sql = string.Format("UPDATE public.tbd_chitietphanquyen SET isxulynhaplieu='{0}' WHERE id_phanquyen = '" + id + "';", isChecked);
                            pgdatabase.Runsql(Class_connect.connection_pg, sql);
                            break;
                        case "isxulyquatrinh":
                            sql = string.Format("UPDATE public.tbd_chitietphanquyen SET isxulyquatrinh='{0}' WHERE id_phanquyen = '" + id + "';", isChecked);
                            pgdatabase.Runsql(Class_connect.connection_pg, sql);
                            break;
                        case "iscapnhatthongtin":
                            sql = string.Format("UPDATE public.tbd_chitietphanquyen SET iscapnhatthongtin='{0}' WHERE id_phanquyen = '" + id + "';", isChecked);
                            pgdatabase.Runsql(Class_connect.connection_pg, sql);
                            break;
                        case "istheodoi":
                            sql = string.Format("UPDATE public.tbd_chitietphanquyen SET istheodoi='{0}' WHERE id_phanquyen = '" + id + "';", isChecked);
                            pgdatabase.Runsql(Class_connect.connection_pg, sql);
                            break;
                        default:
                            break;
                    }
                }
            }

        }
    }
}
