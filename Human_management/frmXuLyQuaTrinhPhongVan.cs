using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
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
    public partial class frmXuLyQuaTrinhPhongVan : Form 
    {
        //Khai báo class
        Class_pgdatabase pgdatabase;
        
        //Tạo biến string toàn cục
        public string sql = "";

        //Cloudinary
        public Cloudinary cloudinary = null;
        Account account = new Account("hrmcloudinary", "336624331362197", "HR8ln3AxXVA05sAmpMi7pBLDAHA");

        public frmXuLyQuaTrinhPhongVan()
        {
            InitializeComponent();
        }
        private void frmKetQuaPhongVan_Load(object sender, EventArgs e)
        {
            //Tải lên danh sách nhân sự
            load_dsnhansu();

            //Thanh tìm kiến hiển thị placeholder 
            txtTimMaNhanSu.Text = "Tìm kiếm theo mã hoặc tên nhân sự";
            txtTimMaNhanSu.ForeColor = SystemColors.GrayText;
        }

        public void load_dsnhansu()
        {
            string sql = "SELECT ns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietphongvan as ctpv" +
                " on ctpv.manhansu = ns.manhansu WHERE ctpv.ishoantatquatrinh = false and ns.ishienthi = true;";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }

        private void dGVNhanSu_Click(object sender, EventArgs e)
        {
            // Gán hình ảnh từ tệp cho PictureBox
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "image\\default_account_1024px.png");
            picAnhNhanSu.Image = System.Drawing.Image.FromFile(imagePath);
            picAnhNhanSu.SizeMode = PictureBoxSizeMode.StretchImage;

            //Thông tin nhân sự
            txtMaNhanSu.Text = dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString();
            txtHoTen.Text = dGVNhanSu.CurrentRow.Cells["hoten"].Value.ToString();
            //string magioitinh = dGVNhanSu.CurrentRow.Cells["gioitinh"].Value.ToString();
            //if (magioitinh != "") { cbbGioiTinh.SelectedValue = magioitinh; }
            cbbGioiTinh.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tengioitinh FROM " +
                "public.tbl_gioitinh WHERE magioitinh = '" + dGVNhanSu.CurrentRow.Cells["gioitinh"].Value + "'");
            dateTimePickerNgaySinh.Text = dGVNhanSu.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtCCCD.Text = dGVNhanSu.CurrentRow.Cells["cccd"].Value.ToString();
            txtEmail.Text = dGVNhanSu.CurrentRow.Cells["email"].Value.ToString();
            txtSoDienThoai.Text = dGVNhanSu.CurrentRow.Cells["sodienthoai"].Value.ToString();
            cbbDanToc.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tendantoc FROM " +
                "public.tbl_dantoc WHERE madantoc = '" + dGVNhanSu.CurrentRow.Cells["dantoc"].Value + "'");
            cbbTonGiao.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tentongiao FROM " +
                "public.tbl_tongiao WHERE matongiao = '" + dGVNhanSu.CurrentRow.Cells["tongiao"].Value + "'");
            cbbQuocTich.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tenquoctich FROM " +
                "public.tbl_quoctich WHERE maquoctich = '" + dGVNhanSu.CurrentRow.Cells["quoctich"].Value + "'");
            txtNoiSinh.Text = dGVNhanSu.CurrentRow.Cells["noisinh"].Value.ToString();
            cbbTinhTrangHonNhan.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tentinhtranghonnhan FROM " +
                "public.tbl_tinhtranghonnhan WHERE matinhtranghonnhan = '" + dGVNhanSu.CurrentRow.Cells["tinhtranghonnhan"].Value + "'");
            txtMaSoThue.Text = dGVNhanSu.CurrentRow.Cells["masothue"].Value.ToString();
            cbbTinhTrangViecLam.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tentinhtrangvieclam FROM " +
                "public.tbl_tinhtrangvieclam WHERE matinhtrangvieclam = '" + dGVNhanSu.CurrentRow.Cells["tinhtrangvieclam"].Value + "'");
            txtTrinhDoHocVan.Text = dGVNhanSu.CurrentRow.Cells["trinhdohocvan"].Value.ToString();
            txtChuyenMon.Text = dGVNhanSu.CurrentRow.Cells["chuyenmon"].Value.ToString();
            txtHocHam.Text = dGVNhanSu.CurrentRow.Cells["hocham"].Value.ToString();
            txtDCTamTru.Text = dGVNhanSu.CurrentRow.Cells["diachitamtru"].Value.ToString();
            txtDCThuongTru.Text = dGVNhanSu.CurrentRow.Cells["diachithuongtru"].Value.ToString();
            txtGhiChu.Text = dGVNhanSu.CurrentRow.Cells["ghichu"].Value.ToString();
            txt_anhnhansu.Text = dGVNhanSu.CurrentRow.Cells["anhnhansu"].Value.ToString();

            //Thiết lập trường dữ liệu mã chỉ đọc
            txtMaNhanSu.ReadOnly = true;
        }

        private void btn_hienthianh_Click(object sender, EventArgs e)
        {
            //Lấy file ảnh nhân sự
            string fileNameImage = txt_anhnhansu.Text;

            //Ảnh nhân sự
            Cloudinary cloudinary = new Cloudinary(account);

            var getResourceParams = new GetResourceParams(string.Format("{0}/{1}", "hrmcloudinary_serve_uploadimage", fileNameImage.ToString()))
            {
                QualityAnalysis = true
            };
            var getResourceResult = cloudinary.GetResource(getResourceParams);

            picAnhNhanSu.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhNhanSu.Load(getResourceResult.Url);
        }

        private void btn_reloadDGV_Click(object sender, EventArgs e)
        {
            load_dsnhansu();
        }

        private void txtTimMaNhanSu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimMaNhanSu.Text))
            {
                txtTimMaNhanSu.Text = "Tìm kiếm theo mã hoặc tên nhân sự";
                txtTimMaNhanSu.ForeColor = SystemColors.GrayText; // Màu chữ mặc định khi không nhập
            }
        }

        private void txtTimMaNhanSu_Enter(object sender, EventArgs e)
        {
            if (txtTimMaNhanSu.Text == "Tìm kiếm theo mã hoặc tên nhân sự")
            {
                txtTimMaNhanSu.Text = "";
                txtTimMaNhanSu.ForeColor = SystemColors.WindowText; // Thay đổi màu chữ khi viết
            }
        }

        private void txtTimMaNhanSu_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietphongvan as ctpv on ctpv.manhansu = ns.manhansu " +
                "WHERE ns.manhansu LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%' AND ns.ishienthi = true AND ctpv.ishoantatquatrinh = false " +
                "OR ns.hoten LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%' AND ns.ishienthi = true AND ctpv.ishoantatquatrinh = false; ";

            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }

        private void btn_khongtiepnhan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không tuyển dụng nhân sự này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                sql = "SELECT id_chitiet FROM public.tbd_chitietphongvan WHERE manhansu = '" + txtMaNhanSu.Text + "'";
                int id_chitiet = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (id_chitiet != 0)
                {
                    //Cập nhật trạng thái chi tiết
                    sql = string.Format("UPDATE public.tbd_chitietphongvan SET isnhanvien = '{0}', ishoantatquatrinh = '{1}'" +
                        " WHERE id_chitiet = '" + id_chitiet + "';", false, true);
                    pgdatabase.Runsql(Class_connect.connection_pg, sql);

                    load_dsnhansu();

                }
                else
                {
                    MessageBox.Show("Không có nhân sự nào được chọn", "Thông báo");
                }
            }
        }

        private void btn_tiepnhan_Click(object sender, EventArgs e)
        {
            string manhansu = txtMaNhanSu.Text;
            string hoten = txtHoTen.Text;

            frmTiepNhanVaBanGiaoCV frm = new frmTiepNhanVaBanGiaoCV(this, manhansu, hoten);
            frm.Show();

        }

    }
}
