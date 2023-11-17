
namespace Human_management
{
    partial class frmQuatrinhlamviec
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
            this.dGV_quatrinhlamviec = new System.Windows.Forms.DataGridView();
            this.manhansu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchucdanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_quatrinhlamviec)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_quatrinhlamviec
            // 
            this.dGV_quatrinhlamviec.AllowUserToAddRows = false;
            this.dGV_quatrinhlamviec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_quatrinhlamviec.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_quatrinhlamviec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_quatrinhlamviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_quatrinhlamviec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhansu,
            this.hoten,
            this.tenchucdanh,
            this.tenphongban,
            this.ngaybatdau,
            this.ngayketthuc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_quatrinhlamviec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_quatrinhlamviec.Location = new System.Drawing.Point(12, 12);
            this.dGV_quatrinhlamviec.Name = "dGV_quatrinhlamviec";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_quatrinhlamviec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_quatrinhlamviec.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGV_quatrinhlamviec.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGV_quatrinhlamviec.RowTemplate.Height = 24;
            this.dGV_quatrinhlamviec.Size = new System.Drawing.Size(1313, 327);
            this.dGV_quatrinhlamviec.TabIndex = 0;
            // 
            // manhansu
            // 
            this.manhansu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.manhansu.DataPropertyName = "manhansu";
            this.manhansu.FillWeight = 503.7433F;
            this.manhansu.Frozen = true;
            this.manhansu.HeaderText = "Mã nhân sự";
            this.manhansu.MinimumWidth = 6;
            this.manhansu.Name = "manhansu";
            this.manhansu.Width = 140;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.FillWeight = 19.25134F;
            this.hoten.HeaderText = "Họ và tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            // 
            // tenchucdanh
            // 
            this.tenchucdanh.DataPropertyName = "tenchucdanh";
            this.tenchucdanh.FillWeight = 19.25134F;
            this.tenchucdanh.HeaderText = "Chức danh";
            this.tenchucdanh.MinimumWidth = 6;
            this.tenchucdanh.Name = "tenchucdanh";
            // 
            // tenphongban
            // 
            this.tenphongban.DataPropertyName = "tenphongban";
            this.tenphongban.FillWeight = 19.25134F;
            this.tenphongban.HeaderText = "Phòng ban";
            this.tenphongban.MinimumWidth = 6;
            this.tenphongban.Name = "tenphongban";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.FillWeight = 19.25134F;
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.MinimumWidth = 6;
            this.ngaybatdau.Name = "ngaybatdau";
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "ngayketthuc";
            this.ngayketthuc.FillWeight = 19.25134F;
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            // 
            // frmQuatrinhlamviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1337, 351);
            this.Controls.Add(this.dGV_quatrinhlamviec);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuatrinhlamviec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUÁ TRÌNH LÀM VIỆC";
            this.Load += new System.EventHandler(this.frmQuatrinhlamviec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_quatrinhlamviec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_quatrinhlamviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhansu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchucdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
    }
}