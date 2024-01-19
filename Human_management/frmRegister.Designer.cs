
namespace Human_management
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtComfimPassword = new System.Windows.Forms.TextBox();
            this.btnDangky = new System.Windows.Forms.Button();
            this.erPRegister = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.returnLogin = new System.Windows.Forms.PictureBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linklblDangNhap = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.dTP_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.erP_thongbaoloi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erPRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnLogin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erP_thongbaoloi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(159, 39);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(281, 34);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(199, 37);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 34);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(199, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 34);
            this.txtPassword.TabIndex = 2;
            // 
            // txtComfimPassword
            // 
            this.txtComfimPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComfimPassword.Location = new System.Drawing.Point(199, 115);
            this.txtComfimPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComfimPassword.Name = "txtComfimPassword";
            this.txtComfimPassword.PasswordChar = '*';
            this.txtComfimPassword.Size = new System.Drawing.Size(232, 34);
            this.txtComfimPassword.TabIndex = 3;
            this.txtComfimPassword.Leave += new System.EventHandler(this.txtComfimPassword_Leave);
            // 
            // btnDangky
            // 
            this.btnDangky.Location = new System.Drawing.Point(126, 157);
            this.btnDangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(250, 63);
            this.btnDangky.TabIndex = 4;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // erPRegister
            // 
            this.erPRegister.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // returnLogin
            // 
            this.returnLogin.Image = ((System.Drawing.Image)(resources.GetObject("returnLogin.Image")));
            this.returnLogin.Location = new System.Drawing.Point(184, 234);
            this.returnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.returnLogin.Name = "returnLogin";
            this.returnLogin.Size = new System.Drawing.Size(32, 31);
            this.returnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnLogin.TabIndex = 19;
            this.returnLogin.TabStop = false;
            this.returnLogin.Click += new System.EventHandler(this.returnLogin_Click);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(557, 37);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(83, 36);
            this.cbbGioiTinh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới tính";
            // 
            // linklblDangNhap
            // 
            this.linklblDangNhap.AutoSize = true;
            this.linklblDangNhap.LinkColor = System.Drawing.Color.DarkCyan;
            this.linklblDangNhap.Location = new System.Drawing.Point(217, 232);
            this.linklblDangNhap.Name = "linklblDangNhap";
            this.linklblDangNhap.Size = new System.Drawing.Size(108, 28);
            this.linklblDangNhap.TabIndex = 5;
            this.linklblDangNhap.TabStop = true;
            this.linklblDangNhap.Text = "Đăng nhập";
            this.linklblDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDangNhap_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày sinh";
            // 
            // dTP_ngaysinh
            // 
            this.dTP_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_ngaysinh.Location = new System.Drawing.Point(771, 39);
            this.dTP_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dTP_ngaysinh.Name = "dTP_ngaysinh";
            this.dTP_ngaysinh.Size = new System.Drawing.Size(136, 34);
            this.dTP_ngaysinh.TabIndex = 3;
            this.dTP_ngaysinh.Value = new System.DateTime(2023, 10, 14, 10, 41, 9, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(159, 120);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(748, 34);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(515, 80);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Location = new System.Drawing.Point(159, 80);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(205, 34);
            this.txtSoDienThoai.TabIndex = 4;
            this.txtSoDienThoai.Leave += new System.EventHandler(this.txtSoDienThoai_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComfimPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnDangky);
            this.groupBox1.Controls.Add(this.returnLogin);
            this.groupBox1.Controls.Add(this.linklblDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(250, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(461, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TẠO TÀI KHOẢN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.cbbGioiTinh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dTP_ngaysinh);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(927, 164);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // erP_thongbaoloi
            // 
            this.erP_thongbaoloi.ContainerControl = this;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(961, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erPRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnLogin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erP_thongbaoloi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtComfimPassword;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.ErrorProvider erPRegister;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox returnLogin;
        private System.Windows.Forms.LinkLabel linklblDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTP_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider erP_thongbaoloi;
    }
}