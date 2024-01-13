using Human_management.Modle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.IO;
using System.Drawing.Drawing2D;

namespace Human_management
{
    public partial class frmTiepNhanHoSo : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        //Khai báo biến toàn cục cho mục đích upload image to cloudinary
        protected string fullPath_imageUpload = "";

        //Thiết lập hình ảnh mặc định khi thêm mới một nhân sự
        protected string imageName = "default_account_1024px";

        //Cloudinary
        public Cloudinary cloudinary = null;
        Account account = new Account("hrmcloudinary", "336624331362197", "HR8ln3AxXVA05sAmpMi7pBLDAHA");

        private string _username;

        //--- Biến bool kiểm tra răng buộc dữ liệu
        bool valid_cccd, valid_sdt, valid_mst, valid_tdhv = false;

        public frmTiepNhanHoSo(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmTiepNhanHoSo_Load(object sender, EventArgs e)
        {
            load_gioitinh();
            load_dantoc();
            load_tongiao();
            load_tinhtranghonnhan();
            load_quoctich();
            load_tinhtrangvieclam();
            load_dsnhansu();

            //Thanh tìm kiến hiển thị placeholder 
            txtTimMaNhanSu.Text = "Tìm kiếm theo mã hoặc tên nhân sự";
            txtTimMaNhanSu.ForeColor = SystemColors.GrayText;
        }

        //Load dữ liệu nhân sự vào datagirdview
        public void load_dsnhansu()
        {
            string sql = "SELECT ns.* FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietphongvan AS ctpv ON ns.manhansu = ctpv.manhansu " +
                "WHERE ns.ishienthi AND ctpv.isnhanvien = false AND ctpv.ishoantatquatrinh = false;";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNhanSu.Text != "")
            {
                sql = "SELECT id FROM public.tbd_nhansu WHERE manhansu = '" + txtMaNhanSu.Text + "'";
                int id = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (id == 0)
                {
                    if (valid_cccd && valid_sdt && valid_mst && valid_tdhv && empty_check())
                    {
                        //Xử lý upload hình ảnh nhân sự lên cloudinary
                        if (fullPath_imageUpload != "")
                        {
                            UploadImageTo_Cloudinary(fullPath_imageUpload, imageName);
                        }
                        //Xử lý lưu dữ liệu vào cơ sở dữ liệu vào postgreSQL
                        sql = string.Format("INSERT INTO public.tbd_nhansu(manhansu, hoten, gioitinh, ngaysinh, cccd, email, sodienthoai," +
                            " dantoc, tongiao, quoctich, noisinh, tinhtranghonnhan, masothue, tinhtrangvieclam, trinhdohocvan," +
                            " chuyenmon, hocham, diachitamtru, diachithuongtru, ghichu, manhanvientaohoso, ngaytao, hostname, anhnhansu, ishienthi) " +
                            "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}'," +
                            "'{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}');", txtMaNhanSu.Text, txtHoTen.Text,
                            cbbGioiTinh.SelectedValue.ToString(), dateTimePickerNgaySinh.Value, txtCCCD.Text, txtEmail.Text,
                            txtSoDienThoai.Text, cbbDanToc.SelectedValue.ToString(), cbbTonGiao.SelectedValue.ToString(),
                            cbbQuocTich.SelectedValue.ToString(), txtNoiSinh.Text, cbbTinhTrangHonNhan.SelectedValue.ToString(),
                            txtMaSoThue.Text, cbbTinhTrangViecLam.SelectedValue.ToString(), txtTrinhDoHocVan.Text, txtChuyenMon.Text,
                            txtHocHam.Text, txtDCTamTru.Text, txtDCThuongTru.Text, txtGhiChu.Text, _username, "now()", Dns.GetHostName(), imageName.ToString(), true);
                        pgdatabase.Runsql(Class_connect.connection_pg, sql);

                        //Cập nhật trạng thái chi tiết
                        sql = string.Format("INSERT INTO public.tbd_chitietphongvan(manhansu, isnhanvien, machucdanh, maphongban, ishoantatquatrinh)" +
                            " VALUES('{0}', '{1}', '{2}', '{3}', '{4}'); ", txtMaNhanSu.Text, false, "", "", false);
                        pgdatabase.Runsql(Class_connect.connection_pg, sql);

                        load_dsnhansu();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin", "  Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân sự đã tồn tại", "  Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mã nhân sự không được trống", "Thông báo");
            }
        }

        private bool empty_check()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                txtHoTen.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtNoiSinh.Text))
            {
                txtNoiSinh.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtChuyenMon.Text))
            {
                txtChuyenMon.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtHocHam.Text))
            {
                txtHocHam.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDCTamTru.Text))
            {
                txtDCTamTru.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDCThuongTru.Text))
            {
                txtDCThuongTru.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            sql = "SELECT id FROM public.tbd_nhansu WHERE manhansu = '" + txtMaNhanSu.Text + "'";
            int id = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id != 0)
            {
                if (valid_cccd && valid_sdt && valid_mst && valid_tdhv)
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
                    load_dsnhansu();
                }
                else
                {
                    MessageBox.Show("Một số trường nhập liệu không hợp lệ", "  Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không có trường dữ liệu nào được chọn", "Thông báo");
            }
        }

        //Xóa - chỉ ẩn đi không được phép xóa dữ liệu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                sql = "SELECT id FROM public.tbd_nhansu WHERE manhansu = '" + txtMaNhanSu.Text + "'";
                int id = pgdatabase.getid(Class_connect.connection_pg, sql);
                if (id != 0)
                {
                    sql = string.Format("UPDATE public.tbd_nhansu SET ishienthi = FALSE WHERE id = '{0}';", id);

                    pgdatabase.Runsql(Class_connect.connection_pg, sql);
                    load_dsnhansu();
                }
                else
                {
                    MessageBox.Show("Không có nhân sự nào được chọn", "Thông báo");
                }
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

            //--
            valid_cccd = true;
            valid_sdt = true;
            valid_mst = true;
            valid_tdhv = true;

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
            string sql = "SELECT ns.* FROM public.tbd_nhansu AS ns INNER JOIN public.tbd_chitietphongvan AS ctpv ON ns.manhansu = ctpv.manhansu " +
                "WHERE ns.ishienthi AND ctpv.isnhanvien = false AND ctpv.ishoantatquatrinh = false AND ns.manhansu LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%' " +
                "OR ns.ishienthi AND ctpv.isnhanvien = false AND ctpv.ishoantatquatrinh = false AND ns.hoten LIKE '%" + txtTimMaNhanSu.Text.Trim() + "%'; ";
            DataTable datatable = new DataTable();
            pgdatabase = new Class_pgdatabase();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            if (datatable.Rows.Count > 0)
            {
                dGVNhanSu.DataSource = datatable;
                dGVNhanSu.AutoGenerateColumns = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Gán hình ảnh từ tệp cho PictureBox
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "image\\default_account_1024px.png");
            picAnhNhanSu.Image = System.Drawing.Image.FromFile(imagePath);
            picAnhNhanSu.SizeMode = PictureBoxSizeMode.StretchImage;

            txtMaNhanSu.ReadOnly = false;
            txtMaNhanSu.Text = "";
            txtHoTen.Text = "";
            cbbGioiTinh.SelectedValue = "NAM";
            dateTimePickerNgaySinh.Value = DateTime.Now;
            txtCCCD.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            cbbDanToc.SelectedValue = "DT01";
            cbbTonGiao.SelectedValue = "TG01";
            cbbQuocTich.SelectedValue = "QT001";
            txtNoiSinh.Text = "";
            cbbTinhTrangHonNhan.SelectedValue = "HN01";
            txtMaSoThue.Text = "";
            cbbTinhTrangViecLam.SelectedValue = "VL04";
            txtTrinhDoHocVan.Text = "";
            txtChuyenMon.Text = "";
            txtHocHam.Text = "";
            txtDCTamTru.Text = "";
            txtDCThuongTru.Text = "";
            txtGhiChu.Text = "";
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
    }
}
