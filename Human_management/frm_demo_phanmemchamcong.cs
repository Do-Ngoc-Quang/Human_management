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
    public partial class frm_demo_phanmemchamcong : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";
        public frm_demo_phanmemchamcong()
        {
            InitializeComponent();
        }

        private void frm_demo_phanmemchamcong_Load(object sender, EventArgs e)
        {
            pgdatabase = new Class_pgdatabase();


            //Thanh tìm kiến hiển thị placeholder 
            txt_timnhansu.Text = "Nhập mã số nhân viên của bạn";
            txt_timnhansu.ForeColor = SystemColors.GrayText;
            txtHoTen.Focus();
        }



        private void txt_timnhansu_Enter(object sender, EventArgs e)
        {
            if (txt_timnhansu.Text == "Nhập mã số nhân viên của bạn")
            {
                txt_timnhansu.Text = "";
                txt_timnhansu.ForeColor = SystemColors.WindowText; // Thay đổi màu chữ khi viết
            }
        }

        private void txt_timnhansu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_timnhansu.Text))
            {
                txt_timnhansu.Text = "Nhập mã số nhân viên của bạn";
                txt_timnhansu.ForeColor = SystemColors.GrayText; // Màu chữ mặc định khi không nhập
            }
        }

        private void txt_timnhansu_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ns.hoten FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
                "WHERE ns.manhansu LIKE '%" + txt_timnhansu.Text + "%' and ns.ishienthi = true and ctns.isnhanvien = true LIMIT 1; ";
            string hoten = pgdatabase.getValue(Class_connect.connection_pg, sql);

            sql = "SELECT ns.manhansu FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
                "WHERE ns.manhansu LIKE '%" + txt_timnhansu.Text + "%' and ns.ishienthi = true and ctns.isnhanvien = true LIMIT 1; ";
            string manhansu = pgdatabase.getValue(Class_connect.connection_pg, sql);

            txt_manhansu.Text = manhansu.ToString();
            txtHoTen.Text = hoten.ToString();
        }

        private void btn_ghinhanchamcong_Click(object sender, EventArgs e)
        {
            if (txt_manhansu.Text != "")
            {
                sql = "SELECT id FROM public.tbd_chitietchamcong WHERE manhansu = '" + txt_manhansu.Text + "' " +
                    "AND ngay = '" + dTP_ngay.Value.ToString("MM/dd/yyyy") + "';";
                int id = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (id == 0)
                {
                    //Xử lý lưu dữ liệu vào cơ sở dữ liệu vào postgreSQL
                    sql = string.Format("INSERT INTO public.tbd_chitietchamcong(manhansu, giovao, giora, sogiolamviec, ngay) " +
                        "VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}');", txt_manhansu.Text, dTP_giovao.Value.TimeOfDay.ToString(@"hh\:mm\:ss"),
                        dTP_giora.Value.TimeOfDay.ToString(@"hh\:mm\:ss"), (dTP_giora.Value.TimeOfDay - dTP_giovao.Value.TimeOfDay).ToString(@"hh\:mm\:ss"),
                        dTP_ngay.Value.ToString("MM/dd/yyyy"));
                    bool kqua = pgdatabase.Runsql(Class_connect.connection_pg, sql);
                    if (kqua)
                    {
                        MessageBox.Show("Chấm công thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Nhân sự " + txtHoTen.Text + " đã chấm công cho ngày " + dTP_ngay.Value.ToString("MM/dd/yyyy"), "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa có nhân sự nào được chọn", "Thông báo");
            }
        }
    }
}
