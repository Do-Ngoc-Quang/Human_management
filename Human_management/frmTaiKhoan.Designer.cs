
namespace Human_management
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.tabP_doimatkhau = new System.Windows.Forms.TabPage();
            this.tabP_thongtincanhan = new System.Windows.Forms.TabPage();
            this.btnHienThiAnh = new System.Windows.Forms.Button();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picAnhNhanSu = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabP_thongtincanhan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanSu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabP_doimatkhau
            // 
            this.tabP_doimatkhau.BackColor = System.Drawing.SystemColors.Window;
            this.tabP_doimatkhau.Location = new System.Drawing.Point(4, 37);
            this.tabP_doimatkhau.Name = "tabP_doimatkhau";
            this.tabP_doimatkhau.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_doimatkhau.Size = new System.Drawing.Size(1505, 363);
            this.tabP_doimatkhau.TabIndex = 1;
            this.tabP_doimatkhau.Text = "Đổi mật khẩu";
            // 
            // tabP_thongtincanhan
            // 
            this.tabP_thongtincanhan.BackColor = System.Drawing.SystemColors.Window;
            this.tabP_thongtincanhan.Controls.Add(this.btnHienThiAnh);
            this.tabP_thongtincanhan.Controls.Add(this.btnTaiAnh);
            this.tabP_thongtincanhan.Controls.Add(this.groupBox2);
            this.tabP_thongtincanhan.Controls.Add(this.picAnhNhanSu);
            this.tabP_thongtincanhan.Location = new System.Drawing.Point(4, 37);
            this.tabP_thongtincanhan.Name = "tabP_thongtincanhan";
            this.tabP_thongtincanhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_thongtincanhan.Size = new System.Drawing.Size(1505, 363);
            this.tabP_thongtincanhan.TabIndex = 0;
            this.tabP_thongtincanhan.Text = "Thông tin tài khoản";
            // 
            // btnHienThiAnh
            // 
            this.btnHienThiAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiAnh.Image")));
            this.btnHienThiAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienThiAnh.Location = new System.Drawing.Point(68, 286);
            this.btnHienThiAnh.Name = "btnHienThiAnh";
            this.btnHienThiAnh.Size = new System.Drawing.Size(130, 35);
            this.btnHienThiAnh.TabIndex = 2;
            this.btnHienThiAnh.Text = "Hiển thị ảnh";
            this.btnHienThiAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienThiAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThiAnh.UseVisualStyleBackColor = true;
            this.btnHienThiAnh.Click += new System.EventHandler(this.btnHienThiAnh_Click);
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiAnh.Image")));
            this.btnTaiAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiAnh.Location = new System.Drawing.Point(68, 250);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(130, 35);
            this.btnTaiAnh.TabIndex = 1;
            this.btnTaiAnh.Text = "Tải ảnh lên   ";
            this.btnTaiAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBox2.Controls.Add(this.cbbGioiTinh);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_diachi);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txt_username);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(238, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1226, 212);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(550, 160);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 35);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Location = new System.Drawing.Point(1014, 71);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(189, 34);
            this.txtSoDienThoai.TabIndex = 6;
            this.txtSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(904, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 28);
            this.label10.TabIndex = 32;
            this.label10.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(448, 71);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 34);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Email";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(1014, 34);
            this.dateTimePickerNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(189, 34);
            this.dateTimePickerNgaySinh.TabIndex = 3;
            this.dateTimePickerNgaySinh.Value = new System.DateTime(2023, 10, 14, 10, 41, 9, 0);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(803, 33);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(83, 36);
            this.cbbGioiTinh.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(374, 34);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(316, 34);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // txtCCCD
            // 
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCD.Location = new System.Drawing.Point(101, 71);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(245, 34);
            this.txtCCCD.TabIndex = 4;
            this.txtCCCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "CCCD";
            // 
            // txt_diachi
            // 
            this.txt_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_diachi.Location = new System.Drawing.Point(101, 107);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(1102, 34);
            this.txt_diachi.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 28);
            this.label18.TabIndex = 0;
            this.label18.Text = "Địa chỉ";
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Location = new System.Drawing.Point(101, 34);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(169, 34);
            this.txt_username.TabIndex = 1;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(927, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày sinh";
            // 
            // picAnhNhanSu
            // 
            this.picAnhNhanSu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhNhanSu.Location = new System.Drawing.Point(45, 40);
            this.picAnhNhanSu.Name = "picAnhNhanSu";
            this.picAnhNhanSu.Size = new System.Drawing.Size(175, 200);
            this.picAnhNhanSu.TabIndex = 39;
            this.picAnhNhanSu.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabP_thongtincanhan);
            this.tabControl1.Controls.Add(this.tabP_doimatkhau);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1513, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1530, 750);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmTaiKhoan";
            this.Tag = "";
            this.Text = "TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.tabP_thongtincanhan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanSu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabP_doimatkhau;
        private System.Windows.Forms.TabPage tabP_thongtincanhan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnHienThiAnh;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picAnhNhanSu;
    }
}