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
    public partial class frmMain : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";
        private frmLogin _frmLogin;
        private bool _isloggined;
        private string _id_user;
        private int _isadmin;
        private string _username;

        public frmMain(frmLogin frmLogin, bool isloggined, string id_user, int isadmin, string username)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
            _isloggined = isloggined;
            _id_user = id_user;
            _isadmin = isadmin;
            _username = username;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (_isadmin != 0)
            {
                ttmnu_PhanQuyen.Visible = true;
            }
            else
            {
                ttmnu_PhanQuyen.Visible = false;


                //Phân quyền theo từng vai trò
                pgdatabase = new Class_pgdatabase();
                //Được phép nhập nhập liệu
                sql = "SELECT id_phanquyen FROM public.tbd_chitietphanquyen WHERE username_ctpq = '" + _username + "' AND isxulynhaplieu;"; //nếu true thì sẽ trả về id
                int isxulynhaplieu = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (isxulynhaplieu == 0)
                {
                    ttmnu_QLTiepNhanHoSo.Visible = false;
                }
                else
                {
                    ttmnu_QLTiepNhanHoSo.Visible = true;
                }

                //Được phép xử lý quá trình tuyển dụng
                sql = "SELECT id_phanquyen FROM public.tbd_chitietphanquyen WHERE username_ctpq = '" + _username + "' AND isxulyquatrinh;"; //nếu true thì sẽ trả về id
                int isxulyquatrinh = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (isxulyquatrinh == 0)
                {
                    ttmnu_QLQuaTrinhPhongVan.Visible = false;
                }
                else
                {
                    ttmnu_QLQuaTrinhPhongVan.Visible = true;
                }

                //Được phép xử lý cập nhật thông tin ứng viên, xem hợp đồng lao động
                sql = "SELECT id_phanquyen FROM public.tbd_chitietphanquyen WHERE username_ctpq = '" + _username + "' AND iscapnhatthongtin;"; //nếu true thì sẽ trả về id
                int iscapnhatthongtin = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (iscapnhatthongtin == 0)
                {
                    ttmnu_QLThongTinNhanSu.Visible = false;
                }
                else
                {
                    ttmnu_QLThongTinNhanSu.Visible = true;
                }

                //Được phép quản lý, theo dõi các quá trình đào tạo, chấm công, bảng lương, ...
                sql = "SELECT id_phanquyen FROM public.tbd_chitietphanquyen WHERE username_ctpq = '" + _username + "' AND istheodoi;"; //nếu true thì sẽ trả về id
                int istheodoi = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (istheodoi == 0)
                {
                    ttmnu_QLChamCong.Visible = false;
                    ttmnu_QLDaoTao.Visible = false;
                    ttmnu_QLKPI.Visible = false;
                }
                else
                {
                    ttmnu_QLChamCong.Visible = true;
                    ttmnu_QLDaoTao.Visible = true;
                    ttmnu_QLKPI.Visible = true;
                }

            }
        }


        //Chức năng quản lý
        private void ttmnu_QLTiepNhanHoSo_Click(object sender, EventArgs e)
        {
            // Mỗi khi muốn mở một form con mới, hãy gọi hàm OpenChildForm
            OpenChildForm(new frmTiepNhanHoSo(_username));
        }

        private void ttmnu_QLQuaTrinhPhongVan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXuLyQuaTrinhPhongVan());
        }

        private void ttmnu_QLThongTinNhanSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongTinNhanSu());
        }

        private void ttmnu_QLChamCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChamCong());
        }

        private void ttmnu_QLDaoTao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDaoTao());
        }

        private void ttmnu_QLQuyenLoiPhucLoi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuyenLoiPhucLoi(_id_user));
        }

        private void ttmnu_QLKPI_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHieuSuatCongViecKPI());
        }

        //Báo cáo
        private void ttmu_BCNhanSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCaoNhanSu());
        }

        //Trợ giúp
        private void ttmnu_About_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAbout());
        }

        private void ttmnu_HuongDanSuDung_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHuongDanSuDung());
        }

        private void ttmnu_phanmemgialapghinhanchamcong_Click(object sender, EventArgs e)
        {
            frm_demo_phanmemchamcong frm = new frm_demo_phanmemchamcong();
            frm.Show();
        }

        //Hệ thống
        private void ttmnu_TaiKhoan_Click(object sender, EventArgs e)
        {
            // Mỗi khi muốn mở một form con mới, hãy gọi hàm OpenChildForm
            OpenChildForm(new frmTaiKhoan(_id_user));

        }

        private void ttmnu_PhanQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhanQuyen());
        }

        private void ttmnu_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _isloggined = false;
                _id_user = null;
                this.Hide();

                _frmLogin.resetValue();
                _frmLogin.Show();

            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.Invalidate();

            // Xử lý khi người dùng chuyển đổi giữa các tab
            if (tabControl.SelectedTab != null && tabControl.SelectedTab.Tag is Form)
            {
                Form selectedForm = (Form)tabControl.SelectedTab.Tag;

                // Nếu form đã mở, đưa nó lên trước cùng bằng cách tập trung vào TabPage
                if (selectedForm.IsHandleCreated)
                {
                    tabControl.SelectedTab.Focus();
                }
                else
                {
                    selectedForm.BringToFront();
                }
            }
        }

        public void OpenChildForm(Form childForm)
        {
            // Kiểm tra xem form con đã tồn tại trong TabControl hay chưa
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                if (tabPage.Text == childForm.Text)
                {
                    // Nếu đã tồn tại, đặt TabPage đó làm Tab được chọn
                    tabControl.SelectedTab = tabPage;
                    return;
                }
            }

            // Nếu form con chưa tồn tại, tạo một TabPage mới
            TabPage newTabPage = new TabPage();
            newTabPage.Text = childForm.Text;
            newTabPage.Tag = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            newTabPage.Controls.Add(childForm);
            tabControl.TabPages.Add(newTabPage);

            childForm.Show();
            tabControl.SelectedTab = newTabPage;
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
