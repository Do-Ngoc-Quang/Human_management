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
    public partial class frmTaiKhoan : Form
    {
        Class_pgdatabase pgdatabase;
        public string sql = "";

        //Khai báo biến toàn cục cho mục đích upload image to cloudinary
        protected string fullPath_imageUpload = "";
        private string imageName = "";
        private string current_avatar;
        //Cloudinary
        public Cloudinary cloudinary = null;
        Account account = new Account("hrmcloudinary", "336624331362197", "HR8ln3AxXVA05sAmpMi7pBLDAHA");

        private string _id_user;

        public frmTaiKhoan(string id_user)
        {
            InitializeComponent();
            _id_user = id_user;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            load_gioitinh();

            load_thongtintaikhoan();
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

        public void load_thongtintaikhoan()
        {
            string sql = "SELECT DISTINCT * FROM public.tbl_users WHERE id = '" + _id_user + "'";
            DataTable datatable = new DataTable();
            datatable = pgdatabase.getDataTable(Class_connect.connection_pg, sql);

            // Kiểm tra xem có dòng dữ liệu không
            if (datatable.Rows.Count > 0)
            {
                DataRow row = datatable.Rows[0]; // Lấy dòng đầu tiên

                // Truy cập các trường dữ liệu trong dòng đó - row["TênCột"]
                txt_username.Text = row["username"].ToString();
                txtHoTen.Text = row["hovaten"].ToString();
                // gioitinh
                cbbGioiTinh.Text = pgdatabase.getValue(Class_connect.connection_pg, "SELECT tengioitinh FROM " +
                "public.tbl_gioitinh WHERE magioitinh = '" + row["gioitinh"].ToString() + "'");
                dateTimePickerNgaySinh.Text = row["ngaysinh"].ToString();
                txtCCCD.Text = row["cccd"].ToString();
                txtEmail.Text = row["email"].ToString();
                txtSoDienThoai.Text = row["sodienthoai"].ToString();
                txt_diachi.Text = row["diachi"].ToString();

                current_avatar = row["avatar"].ToString();

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

            //Ảnh nhân sự
            Cloudinary cloudinary = new Cloudinary(account);

            var getResourceParams = new GetResourceParams(string.Format("{0}/{1}", "hrmcloudinary_serve_uploadimage", current_avatar.ToString()))
            {
                QualityAnalysis = true
            };
            var getResourceResult = cloudinary.GetResource(getResourceParams);

            picAnhNhanSu.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhNhanSu.Load(getResourceResult.Url);
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            pgdatabase = new Class_pgdatabase();

            sql = "SELECT id FROM public.tbl_users WHERE username = '" + txt_username.Text + "';";
            int id = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id != 0)
            {
                //Xử lý upload hình ảnh nhân sự lên cloudinary
                if (fullPath_imageUpload != "")
                {
                    UploadImageTo_Cloudinary(fullPath_imageUpload, imageName);

                    //Xử lý chỉ cập nhật ảnh đại diện
                    sql = string.Format("UPDATE public.tbl_users SET avatar='" + imageName.ToString() + "' WHERE id = '" + id + "';");
                    pgdatabase.Runsql(Class_connect.connection_pg, sql);
                }
            }

            sql = string.Format("UPDATE public.tbl_users SET hovaten='{0}', gioitinh='{1}', ngaysinh='{2}', sodienthoai='{3}', email='{4}'," +
                " diachi='{5}', cccd='{6}' WHERE id = '"+ id +"';", txtHoTen.Text, cbbGioiTinh.SelectedValue.ToString(),
                dateTimePickerNgaySinh.Value, txtSoDienThoai.Text, txtEmail.Text, txt_diachi.Text, txtCCCD.Text);
            bool kqua = pgdatabase.Runsql(Class_connect.connection_pg, sql);
            if (kqua)
            {
                MessageBox.Show("Cập nhật thành công");
            }
        } 

    }
}
