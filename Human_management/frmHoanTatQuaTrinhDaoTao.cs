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
    public partial class frmHoanTatQuaTrinhDaoTao : Form
    {
        private Class_pgdatabase pgdatabase;
        private string sql = "";

        private string _manhansu;
        private string _madaotao;
        private string _tendaotao;
        private string _maphongban;


        //Khai báo biến toàn cục cho mục đích upload image to cloudinary
        protected string fullPath_imageUpload = "";

        //Thiết lập hình ảnh mặc định khi thêm mới một nhân sự
        protected string imageName = "student-certificate";

        //Cloudinary
        public Cloudinary cloudinary = null;
        Account account = new Account("hrmcloudinary", "336624331362197", "HR8ln3AxXVA05sAmpMi7pBLDAHA");

        public frmHoanTatQuaTrinhDaoTao(string mns, string mdt, string tendaotao, string maphongban)
        {
            InitializeComponent();
            _manhansu = mns;
            _madaotao = mdt;
            _tendaotao = tendaotao;
            _maphongban = maphongban;

        }

        private void frmHoanTatQuaTrinhDaoTao_Load(object sender, EventArgs e)
        {
            txt_tendaotao.Text = _tendaotao;
            pgdatabase = new Class_pgdatabase();
        }

        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            // - nếu manhansu_ctdt is not null and madaotao_ctdt is null thì update
            sql = "SELECT id_ctdt FROM public.tbd_chitietdaotao " +
                "WHERE manhansu_ctdt IS NOT NULL AND manhansu_ctdt = '"+ _manhansu + "' AND madaotao_ctdt IS NULL";
            int id_ctdt = pgdatabase.getid(Class_connect.connection_pg, sql);
            if (id_ctdt != 0)
            {
                //Xử lý upload hình ảnh nhân sự lên cloudinary
                if (fullPath_imageUpload != "")
                {
                    UploadImageTo_Cloudinary(fullPath_imageUpload, imageName);
                }

                sql = string.Format("UPDATE public.tbd_chitietdaotao SET madaotao_ctdt='{0}', ketqua='{1}', chungnhan='{2}' " +
                    "WHERE id_ctdt = '"+ id_ctdt + "';", _madaotao, true, imageName.ToString());
                bool kqua = pgdatabase.Runsql(Class_connect.connection_pg, sql);
                if (kqua)
                {
                    updateKeHoachDaoTao(_manhansu, _maphongban);
                    this.Close();
                }
            }            
        }
        
        public void updateKeHoachDaoTao(string mns, string mpb)
        {
            //Cập nhật kế hoạch đào tạo cho nhân sự
            sql = string.Format("INSERT INTO public.tbd_chitietdaotao(manhansu_ctdt, ketqua, maphongban_ctdt) " +
                "VALUES ('{0}', '{1}', '{2}');;", mns, false, mpb);
            pgdatabase.Runsql(Class_connect.connection_pg, sql);
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


    }
}
