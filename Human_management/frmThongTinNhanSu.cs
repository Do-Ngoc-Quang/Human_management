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
    public partial class frmThongTinNhanSu : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        //Khai báo biến toàn cục cho mục đích upload image to cloudinary
        protected string fullPath_imageUpload = "";
        private string imageName = "";

        //Cloudinary
        public Cloudinary cloudinary = null;
        Account account = new Account("hrmcloudinary", "336624331362197", "HR8ln3AxXVA05sAmpMi7pBLDAHA");

        //--- Biến bool kiểm tra răng buộc dữ liệu
        bool valid_cccd, valid_sdt, valid_mst, valid_tdhv = true;

        bool valid_stk, valid_bhxh, valid_bhyt = false;

        public frmThongTinNhanSu()
        {
            InitializeComponent();
        }

        private void frmThongTinNhanSu_Load(object sender, EventArgs e)
        {
            load_dsnhansu();
            load_gioitinh();
            load_dantoc();
            load_tongiao();
            load_tinhtranghonnhan();
            load_quoctich();
            load_tinhtrangvieclam();

            //Thanh tìm kiến hiển thị placeholder 
            txtTimMaNhanSu.Text = "Tìm kiếm theo mã hoặc tên nhân sự";
            txtTimMaNhanSu.ForeColor = SystemColors.GrayText;
        }

        public void load_dsnhansu()
        {
            string sql = "SELECT ns.*, ctns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
                "WHERE ns.ishienthi = true and ctns.isnhanvien = true; ";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }

        public void load_gioitinh()
        {
            string sql = "SELECT magioitinh,tengioitinh FROM public.tbl_gioitinh";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbbGioiTinh.DataSource = datatable;
            cbbGioiTinh.DisplayMember = "tengioitinh";
            cbbGioiTinh.ValueMember = "magioitinh";
        }

        public void load_dantoc()
        {
            string sql = "SELECT madantoc,tendantoc FROM public.tbl_dantoc";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbbDanToc.DataSource = datatable;
            cbbDanToc.DisplayMember = "tendantoc";
            cbbDanToc.ValueMember = "madantoc";
        }

        public void load_tongiao()
        {
            string sql = "SELECT matongiao,tentongiao FROM public.tbl_tongiao";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbbTonGiao.DataSource = datatable;
            cbbTonGiao.DisplayMember = "tentongiao";
            cbbTonGiao.ValueMember = "matongiao";
        }

        public void load_tinhtranghonnhan()
        {
            string sql = "SELECT matinhtranghonnhan,tentinhtranghonnhan FROM public.tbl_tinhtranghonnhan";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbbTinhTrangHonNhan.DataSource = datatable;
            cbbTinhTrangHonNhan.DisplayMember = "tentinhtranghonnhan";
            cbbTinhTrangHonNhan.ValueMember = "matinhtranghonnhan";
        }

        public void load_quoctich()
        {
            string sql = "SELECT maquoctich,tenquoctich FROM public.tbl_quoctich";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbbQuocTich.DataSource = datatable;
            cbbQuocTich.DisplayMember = "tenquoctich";
            cbbQuocTich.ValueMember = "maquoctich";
        }

        public void load_tinhtrangvieclam()
        {
            string sql = "SELECT matinhtrangvieclam,tentinhtrangvieclam FROM public.tbl_tinhtrangvieclam";
            pgdatabase = new Class_pgdatabase();
            DataTable datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);
            cbbTinhTrangViecLam.DataSource = datatable;
            cbbTinhTrangViecLam.DisplayMember = "tentinhtrangvieclam";
            cbbTinhTrangViecLam.ValueMember = "matinhtrangvieclam";
        }

        private void dGVNhanSu_Click(object sender, EventArgs e)
        {
            // Gán hình ảnh từ tệp cho PictureBox
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "image\\default_account_1024px.png");
            picAnhNhanSu.Image = System.Drawing.Image.FromFile(imagePath);
            picAnhNhanSu.SizeMode = PictureBoxSizeMode.StretchImage;

            //Thông tin nhân sự
            txtMaNhanSu.ReadOnly = true;  //Thiết lập trường dữ liệu mã chỉ đọc
            txtMaNhanSu.Text = dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString();
            txtHoTen.Text = dGVNhanSu.CurrentRow.Cells["hoten"].Value.ToString();
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

            //Thông tin chi tiết
            txt_chucdanh.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT cd.tenchucdanh " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietnhansu AS ctns ON ctns.manhansu = ns.manhansu " +
                "INNER JOIN public.tbl_chucdanh AS cd ON ctns.machucdanh = cd.machucdanh " +
                "WHERE cd.machucdanh = '" + dGVNhanSu.CurrentRow.Cells["machucdanh"].Value + "' " +
                "AND ctns.manhansu = '" + dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString() + "';");
            txt_phongban.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT pb.tenphongban " +
                "FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietnhansu AS ctns ON ctns.manhansu = ns.manhansu " +
                "INNER JOIN public.tbl_phongban AS pb ON ctns.maphongban = pb.maphongban " +
                "WHERE pb.maphongban = '" + dGVNhanSu.CurrentRow.Cells["maphongban"].Value + "' " +
                "AND ctns.manhansu = '" + dGVNhanSu.CurrentRow.Cells["manhansu"].Value.ToString() + "';");
            txt_stknganhang.Text = dGVNhanSu.CurrentRow.Cells["stknganhang"].Value.ToString();
            txt_tennganhang.Text = dGVNhanSu.CurrentRow.Cells["tennganhang"].Value.ToString();
            txt_sobhxh.Text = dGVNhanSu.CurrentRow.Cells["sobhxh"].Value.ToString();
            txt_sobhyt.Text = dGVNhanSu.CurrentRow.Cells["sobhyt"].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            sql = "SELECT id FROM public.tbd_nhansu WHERE manhansu = '" + txtMaNhanSu.Text + "'";
            int id = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id != 0)
            {
                if (empty_check() && valid_stk && valid_bhxh && valid_bhyt)
                {
                    //Xử lý upload hình ảnh nhân sự lên cloudinary
                    if (fullPath_imageUpload != "")
                    {
                        UploadImageTo_Cloudinary(fullPath_imageUpload, imageName);

                        //Xử lý chỉ cập nhật imageName
                        sql = string.Format("UPDATE public.tbd_nhansu SET anhnhansu = '{0}' WHERE id = '" + id + "' and manhansu = '" + txtMaNhanSu.Text + "';", imageName.ToString());
                        pgdatabase.Runsql(Class_connect.connection_pg, sql);
                    }

                    //Xử lý cập nhật dữ liệu vào cơ sở dữ liệu vào postgreSQL
                    sql = string.Format("UPDATE public.tbd_nhansu SET hoten = '{0}', gioitinh = '{1}', ngaysinh = '{2}'," +
                        " cccd = '{3}', email = '{4}', sodienthoai = '{5}', dantoc = '{6}', tongiao = '{7}', quoctich = '{8}', noisinh = '{9}'," +
                        " tinhtranghonnhan = '{10}', masothue = '{11}', tinhtrangvieclam = '{12}', trinhdohocvan = '{13}', chuyenmon = '{14}'," +
                        " hocham = '{15}', diachitamtru = '{16}', diachithuongtru = '{17}', ghichu = '{18}'" +
                        " WHERE id = '" + id + "' and manhansu = '" + txtMaNhanSu.Text + "';", txtHoTen.Text, cbbGioiTinh.SelectedValue.ToString(),
                        dateTimePickerNgaySinh.Value, txtCCCD.Text, txtEmail.Text, txtSoDienThoai.Text, cbbDanToc.SelectedValue.ToString(),
                        cbbTonGiao.SelectedValue.ToString(), cbbQuocTich.SelectedValue.ToString(), txtNoiSinh.Text, cbbTinhTrangHonNhan.SelectedValue.ToString(),
                        txtMaSoThue.Text, cbbTinhTrangViecLam.SelectedValue.ToString(), txtTrinhDoHocVan.Text, txtChuyenMon.Text,
                        txtHocHam.Text, txtDCTamTru.Text, txtDCThuongTru.Text, txtGhiChu.Text);
                    pgdatabase.Runsql(Class_connect.connection_pg, sql);

                    //Xử lý cập nhật chi tiết nhân sự
                    sql = string.Format("UPDATE public.tbd_chitietnhansu SET stknganhang='{0}', tennganhang='{1}', sobhxh='{2}', sobhyt='{3}' " +
                        "WHERE manhansu = '" + txtMaNhanSu.Text + "';", txt_stknganhang.Text, txt_tennganhang.Text, txt_sobhxh.Text, txt_sobhyt.Text);
                    pgdatabase.Runsql(Class_connect.connection_pg, sql);

                    load_dsnhansu();
                }
                else
                {
                    MessageBox.Show("Các trường nhập liệu không được để trống", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không có trường dữ liệu nào được chọn", "Thông báo");
            }
        }

        private bool empty_check()
        {
            if (string.IsNullOrEmpty(txt_stknganhang.Text))
            {
                txt_stknganhang.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_tennganhang.Text))
            {
                txt_tennganhang.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_sobhxh.Text))
            {
                txt_sobhxh.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txt_sobhyt.Text))
            {
                txt_sobhyt.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                sql = "SELECT id FROM public.tbd_nhansu WHERE manhansu = '" + txtMaNhanSu.Text + "'";
                int id = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (id != 0)
                {
                    //Cập nhật trạng thái hiển thị [true || false] cho bảng nhân sự
                    sql = string.Format("UPDATE public.tbd_nhansu SET ishienthi = FALSE WHERE id = '{0}';", id);
                    pgdatabase.Runsql(Class_connect.connection_pg, sql);

                    //Cập nhật trạng thái là nhân viên [true || false] cho bẳn chi tiết nhân sự
                    sql = string.Format("UPDATE public.tbd_chitietnhansu SET isnhanvien= FALSE WHERE manhansu = '{0}';", txtMaNhanSu.Text);
                    pgdatabase.Runsql(Class_connect.connection_pg, sql);

                    load_dsnhansu();
                }
                else
                {
                    MessageBox.Show("Không có nhân sự nào được chọn", "Thông báo");
                }
            }
        }

        public void UploadImageTo_Cloudinary(string fullPath, string name_img)
        {
            Cloudinary cloudinary = new Cloudinary(account);
            //Thiết lập một số thuộc tính trước khi upload to cloudinary
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(fullPath), // Gán đường dẫn đầy đủ của tệp ảnh
                PublicId = string.Format("{0}/{1}", "hrmcloudinary_serve_uploadimage", name_img) // Gán PublicId
            };
            //Thực thi tải ảnh lên cloudinary
            cloudinary.Upload(uploadParams);
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            //Cloudinary cloudinary = new Cloudinary(account);

            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "All files(*.*)|*.*|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            dlgOpen.FilterIndex = 1;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnhNhanSu.Image = Image.FromFile(dlgOpen.FileName);
                picAnhNhanSu.SizeMode = PictureBoxSizeMode.StretchImage;

                //Gắn đường link url của ảnh để lưu vào cơ sở dữ liệu
                fullPath_imageUpload = dlgOpen.FileName; // Đường dẫn đầy đủ đến tệp ảnh
                imageName = System.IO.Path.GetFileNameWithoutExtension(fullPath_imageUpload);  // Lấy tên tệp 

            }
        }

        private void btnHienThiAnh_Click(object sender, EventArgs e)
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
            sql = "SELECT ns.*, ctns.* FROM public.tbd_nhansu as ns inner join public.tbd_chitietnhansu as ctns on ctns.manhansu = ns.manhansu " +
                "WHERE ns.manhansu LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%' and ns.ishienthi = true and ctns.isnhanvien = true " +
                "OR ns.hoten LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%' and ns.ishienthi = true and ctns.isnhanvien = true ;";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }


        private void btn_quatrinhlamviec_Click(object sender, EventArgs e)
        {
            frmQuatrinhlamviec frm = new frmQuatrinhlamviec(txtMaNhanSu.Text.ToString());
            frm.Show();
        }

        private void btn_hopdonglaodong_Click(object sender, EventArgs e)
        {
            frmHopDongLaoDong frm = new frmHopDongLaoDong(txtMaNhanSu.Text);
            frm.Show();
        }

        private void txtCCCD_Leave(object sender, EventArgs e)
        {
            erP_thongbaoloi = new ErrorProvider();

            // Kiểm tra độ dài của chuỗi nhập liệu
            if (txtCCCD.Text.Trim().Length != 12)
            {
                // Nếu độ dài không phù hợp, thông báo lỗi
                erP_thongbaoloi.SetError(txtCCCD, "Chỉ chứa 12 chữ số");
                txtCCCD.Focus();
                txtCCCD.Text = string.Empty;
                valid_cccd = false;
                return;
            }
            else
            {
                valid_cccd = true;
            }

            // Kiểm tra xem tất cả các ký tự có phải là số không
            foreach (char c in txtCCCD.Text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải số, thông báo lỗi và xóa nội dung nhập
                    erP_thongbaoloi.SetError(txtCCCD, "CCCD phải là chữ số");
                    txtCCCD.Focus();
                    valid_cccd = false;
                    return;
                }
                else
                {
                    valid_cccd = true;
                }
            }

            if (valid_cccd)
            {
                erP_thongbaoloi.SetError(txtCCCD, "Đã hợp lệ");
            }
        }


        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            erP_thongbaoloi = new ErrorProvider();

            // Kiểm tra độ dài của chuỗi nhập liệu
            if (txtSoDienThoai.Text.Trim().Length < 10 || txtSoDienThoai.Text.Trim().Length > 11)
            {
                // Nếu độ dài không phù hợp, thông báo lỗi
                erP_thongbaoloi.SetError(txtSoDienThoai, "Chỉ chứa 10 tới 11 chữ số");
                txtSoDienThoai.Focus();
                txtSoDienThoai.Text = string.Empty;
                valid_sdt = false;
                return;
            }
            else
            {
                valid_sdt = true;
            }

            // Kiểm tra xem tất cả các ký tự có phải là số không
            foreach (char c in txtSoDienThoai.Text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải số, thông báo lỗi và xóa nội dung nhập
                    erP_thongbaoloi.SetError(txtSoDienThoai, "Số điện thoại phải là chữ số");
                    txtSoDienThoai.Focus();
                    valid_sdt = false;
                    return;
                }
                else
                {
                    valid_sdt = true;
                }
            }

            if (valid_sdt)
            {
                erP_thongbaoloi.SetError(txtSoDienThoai, "Đã hợp lệ");
            }
        }

        private void txtMaSoThue_Leave(object sender, EventArgs e)
        {
            erP_thongbaoloi = new ErrorProvider();

            // Kiểm tra độ dài của chuỗi nhập liệu
            if (txtMaSoThue.Text.Trim().Length != 10 && txtMaSoThue.Text.Trim().Length != 13)
            {
                // Nếu độ dài không phù hợp, thông báo lỗi
                erP_thongbaoloi.SetError(txtMaSoThue, "Chỉ chứa 10 hoặc 13 chữ số");
                txtMaSoThue.Focus();
                txtMaSoThue.Text = string.Empty;
                valid_mst = false;
                return;
            }
            else
            {
                valid_mst = true;
            }

            // Kiểm tra xem tất cả các ký tự có phải là số không
            foreach (char c in txtMaSoThue.Text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải số, thông báo lỗi và xóa nội dung nhập
                    erP_thongbaoloi.SetError(txtMaSoThue, "Mã số thuế phải là chữ số");
                    txtMaSoThue.Focus();
                    valid_mst = false;
                    return;
                }
                else
                {
                    valid_mst = true;
                }
            }

            if (valid_mst)
            {
                erP_thongbaoloi.SetError(txtMaSoThue, "Đã hợp lệ");
            }
        }

        private void txtTrinhDoHocVan_Leave(object sender, EventArgs e)
        {
            erP_thongbaoloi = new ErrorProvider();

            // Kiểm tra độ dài của chuỗi nhập liệu
            if (txtTrinhDoHocVan.Text.Trim().Length != 2)
            {
                // Nếu độ dài không phù hợp, thông báo lỗi
                erP_thongbaoloi.SetError(txtTrinhDoHocVan, "Chỉ chứa 2 chữ số");
                txtTrinhDoHocVan.Focus();
                txtTrinhDoHocVan.Text = string.Empty;
                valid_tdhv = false;
                return;
            }
            else
            {
                valid_tdhv = true;
            }

            // Kiểm tra xem tất cả các ký tự có phải là số không
            foreach (char c in txtTrinhDoHocVan.Text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải số, thông báo lỗi và xóa nội dung nhập
                    erP_thongbaoloi.SetError(txtTrinhDoHocVan, "Trình độ học vấn phải là chữ số");
                    txtTrinhDoHocVan.Focus();
                    valid_tdhv = false;
                    return;
                }
                else
                {
                    valid_tdhv = true;
                }
            }

            if (valid_tdhv)
            {
                erP_thongbaoloi.SetError(txtTrinhDoHocVan, "Đã hợp lệ");
            }
        }

        private void txt_stknganhang_Leave(object sender, EventArgs e)
        {
            erP_thongbaoloi = new ErrorProvider();

            // Kiểm tra xem tất cả các ký tự có phải là số không
            foreach (char c in txt_stknganhang.Text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải số, thông báo lỗi và xóa nội dung nhập
                    erP_thongbaoloi.SetError(txt_stknganhang, "Số tài khoản phải là chữ số");
                    txt_stknganhang.Focus();
                    valid_stk = false;
                    return;
                }
                else
                {
                    valid_stk = true;
                }
            }

            if (valid_stk)
            {
                erP_thongbaoloi.SetError(txt_stknganhang, "Đã hợp lệ");
            }
        }

        private void txt_sobhxh_Leave(object sender, EventArgs e)
        {
            erP_thongbaoloi = new ErrorProvider();

            // Kiểm tra xem tất cả các ký tự có phải là số không
            foreach (char c in txt_sobhxh.Text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải số, thông báo lỗi và xóa nội dung nhập
                    erP_thongbaoloi.SetError(txt_sobhxh, "BHXH phải là chữ số");
                    txt_sobhxh.Focus();
                    valid_bhxh = false;
                    return;
                }
                else
                {
                    valid_bhxh = true;
                }
            }

            if (valid_bhxh)
            {
                erP_thongbaoloi.SetError(txt_sobhxh, "Đã hợp lệ");
            }
        }

        private void txt_sobhyt_Leave(object sender, EventArgs e)
        {
            erP_thongbaoloi = new ErrorProvider();

            // Kiểm tra xem tất cả các ký tự có phải là số không
            foreach (char c in txt_sobhyt.Text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải số, thông báo lỗi và xóa nội dung nhập
                    erP_thongbaoloi.SetError(txt_sobhyt, "Số tài khoản phải là chữ số");
                    txt_sobhyt.Focus();
                    valid_bhyt = false;
                    return;
                }
                else
                {
                    valid_bhyt = true;
                }
            }

            if (valid_bhyt)
            {
                erP_thongbaoloi.SetError(txt_sobhyt, "Đã hợp lệ");
            }
        }
    }
}
