
namespace Human_management
{
    partial class frmPhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGV_vaitro = new System.Windows.Forms.DataGridView();
            this.id_phanquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username_ctpq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isxulynhaplieu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isxulyquatrinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iscapnhatthongtin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.istheodoi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_chucdanh = new System.Windows.Forms.TextBox();
            this.dGV_nguoidung = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._isadmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_timnguoidung = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_vaitro)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_nguoidung)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGV_vaitro);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(23, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1504, 171);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PHÂN QUYỀN THEO VAI TRÒ";
            // 
            // dGV_vaitro
            // 
            this.dGV_vaitro.AllowUserToAddRows = false;
            this.dGV_vaitro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGV_vaitro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_vaitro.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_vaitro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_vaitro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_vaitro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_phanquyen,
            this.username_ctpq,
            this.isxulynhaplieu,
            this.isxulyquatrinh,
            this.iscapnhatthongtin,
            this.istheodoi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_vaitro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_vaitro.Location = new System.Drawing.Point(6, 68);
            this.dGV_vaitro.Name = "dGV_vaitro";
            this.dGV_vaitro.RowHeadersWidth = 51;
            this.dGV_vaitro.RowTemplate.Height = 24;
            this.dGV_vaitro.Size = new System.Drawing.Size(1492, 97);
            this.dGV_vaitro.TabIndex = 0;
            this.dGV_vaitro.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_vaitro_CellValueChanged);
            // 
            // id_phanquyen
            // 
            this.id_phanquyen.DataPropertyName = "id_phanquyen";
            this.id_phanquyen.HeaderText = "id_phanquyen";
            this.id_phanquyen.MinimumWidth = 6;
            this.id_phanquyen.Name = "id_phanquyen";
            this.id_phanquyen.Visible = false;
            this.id_phanquyen.Width = 125;
            // 
            // username_ctpq
            // 
            this.username_ctpq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username_ctpq.DataPropertyName = "username_ctpq";
            this.username_ctpq.HeaderText = "username";
            this.username_ctpq.MinimumWidth = 6;
            this.username_ctpq.Name = "username_ctpq";
            // 
            // isxulynhaplieu
            // 
            this.isxulynhaplieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isxulynhaplieu.DataPropertyName = "isxulynhaplieu";
            this.isxulynhaplieu.HeaderText = "Xử lý nhập liệu";
            this.isxulynhaplieu.MinimumWidth = 6;
            this.isxulynhaplieu.Name = "isxulynhaplieu";
            // 
            // isxulyquatrinh
            // 
            this.isxulyquatrinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isxulyquatrinh.DataPropertyName = "isxulyquatrinh";
            this.isxulyquatrinh.HeaderText = "Xử lý quá trình tuyển dụng";
            this.isxulyquatrinh.MinimumWidth = 6;
            this.isxulyquatrinh.Name = "isxulyquatrinh";
            // 
            // iscapnhatthongtin
            // 
            this.iscapnhatthongtin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iscapnhatthongtin.DataPropertyName = "iscapnhatthongtin";
            this.iscapnhatthongtin.HeaderText = "Được phép cập nhật thông tin";
            this.iscapnhatthongtin.MinimumWidth = 6;
            this.iscapnhatthongtin.Name = "iscapnhatthongtin";
            // 
            // istheodoi
            // 
            this.istheodoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.istheodoi.DataPropertyName = "istheodoi";
            this.istheodoi.HeaderText = "Xem KPI, đào tạo, bảng lương";
            this.istheodoi.MinimumWidth = 6;
            this.istheodoi.Name = "istheodoi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_chucdanh);
            this.panel2.Location = new System.Drawing.Point(6, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1492, 47);
            this.panel2.TabIndex = 41;
            // 
            // txt_chucdanh
            // 
            this.txt_chucdanh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_chucdanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_chucdanh.Location = new System.Drawing.Point(1320, 5);
            this.txt_chucdanh.Name = "txt_chucdanh";
            this.txt_chucdanh.ReadOnly = true;
            this.txt_chucdanh.Size = new System.Drawing.Size(167, 34);
            this.txt_chucdanh.TabIndex = 18;
            this.txt_chucdanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dGV_nguoidung
            // 
            this.dGV_nguoidung.AllowUserToAddRows = false;
            this.dGV_nguoidung.AllowUserToDeleteRows = false;
            this.dGV_nguoidung.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_nguoidung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_nguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_nguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.password,
            this.hovaten,
            this.gioitinh,
            this.ngaysinh,
            this.sodienthoai,
            this.email,
            this.diachi,
            this._isadmin,
            this.avatar,
            this.cccd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_nguoidung.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_nguoidung.Location = new System.Drawing.Point(45, 74);
            this.dGV_nguoidung.Name = "dGV_nguoidung";
            this.dGV_nguoidung.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_nguoidung.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGV_nguoidung.RowHeadersWidth = 51;
            this.dGV_nguoidung.RowTemplate.Height = 24;
            this.dGV_nguoidung.Size = new System.Drawing.Size(1455, 399);
            this.dGV_nguoidung.TabIndex = 43;
            this.dGV_nguoidung.Click += new System.EventHandler(this.dGV_nguoidung_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            this.username.Width = 125;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            this.password.Width = 125;
            // 
            // hovaten
            // 
            this.hovaten.DataPropertyName = "hovaten";
            this.hovaten.HeaderText = "Tên";
            this.hovaten.MinimumWidth = 6;
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            this.hovaten.Width = 250;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Visible = false;
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Visible = false;
            this.ngaysinh.Width = 125;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.MinimumWidth = 6;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.ReadOnly = true;
            this.sodienthoai.Width = 175;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 300;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // _isadmin
            // 
            this._isadmin.DataPropertyName = "isadmin";
            this._isadmin.HeaderText = "_isadmin";
            this._isadmin.MinimumWidth = 6;
            this._isadmin.Name = "_isadmin";
            this._isadmin.ReadOnly = true;
            this._isadmin.Visible = false;
            this._isadmin.Width = 125;
            // 
            // avatar
            // 
            this.avatar.DataPropertyName = "avatar";
            this.avatar.HeaderText = "avatar";
            this.avatar.MinimumWidth = 6;
            this.avatar.Name = "avatar";
            this.avatar.ReadOnly = true;
            this.avatar.Visible = false;
            this.avatar.Width = 125;
            // 
            // cccd
            // 
            this.cccd.DataPropertyName = "cccd";
            this.cccd.HeaderText = "cccd";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            this.cccd.ReadOnly = true;
            this.cccd.Visible = false;
            this.cccd.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txt_timnguoidung);
            this.panel1.Location = new System.Drawing.Point(45, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 52);
            this.panel1.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(253, 28);
            this.label21.TabIndex = 0;
            this.label21.Text = "DANH SÁCH NGƯỜI DÙNG";
            // 
            // txt_timnguoidung
            // 
            this.txt_timnguoidung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timnguoidung.Location = new System.Drawing.Point(1194, 3);
            this.txt_timnguoidung.Name = "txt_timnguoidung";
            this.txt_timnguoidung.Size = new System.Drawing.Size(256, 34);
            this.txt_timnguoidung.TabIndex = 1;
            this.txt_timnguoidung.TextChanged += new System.EventHandler(this.txt_timnguoidung_TextChanged);
            this.txt_timnguoidung.Enter += new System.EventHandler(this.txt_timnguoidung_Enter);
            this.txt_timnguoidung.Leave += new System.EventHandler(this.txt_timnguoidung_Leave);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1550, 750);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dGV_nguoidung);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhanQuyen";
            this.Text = "PHÂN QUYỀN";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_vaitro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_nguoidung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGV_vaitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_phanquyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn username_ctpq;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isxulynhaplieu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isxulyquatrinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iscapnhatthongtin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn istheodoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_chucdanh;
        private System.Windows.Forms.DataGridView dGV_nguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn _isadmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_timnguoidung;
    }
}