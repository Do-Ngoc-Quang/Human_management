
namespace Human_management
{
    partial class frmNhanSuNghiPhep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanSuNghiPhep));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNhanSu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_nghiphep = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_songaynghi = new System.Windows.Forms.TextBox();
            this.btn_capnhatnghiphep = new System.Windows.Forms.Button();
            this.dTP_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTP_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTP_ngayketthuc);
            this.groupBox1.Controls.Add(this.dTP_ngaybatdau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_capnhatnghiphep);
            this.groupBox1.Controls.Add(this.cbb_nghiphep);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_songaynghi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNhanSu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(-10, -22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtMaNhanSu
            // 
            this.txtMaNhanSu.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNhanSu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhanSu.Location = new System.Drawing.Point(77, 46);
            this.txtMaNhanSu.Name = "txtMaNhanSu";
            this.txtMaNhanSu.ReadOnly = true;
            this.txtMaNhanSu.Size = new System.Drawing.Size(103, 34);
            this.txtMaNhanSu.TabIndex = 3;
            this.txtMaNhanSu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã";
            // 
            // cbb_nghiphep
            // 
            this.cbb_nghiphep.BackColor = System.Drawing.SystemColors.Window;
            this.cbb_nghiphep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nghiphep.FormattingEnabled = true;
            this.cbb_nghiphep.Location = new System.Drawing.Point(325, 44);
            this.cbb_nghiphep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_nghiphep.Name = "cbb_nghiphep";
            this.cbb_nghiphep.Size = new System.Drawing.Size(411, 36);
            this.cbb_nghiphep.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(205, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 28);
            this.label17.TabIndex = 15;
            this.label17.Text = "Loại nghỉ phép";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số ngày nghỉ";
            // 
            // txt_songaynghi
            // 
            this.txt_songaynghi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_songaynghi.Location = new System.Drawing.Point(675, 101);
            this.txt_songaynghi.Name = "txt_songaynghi";
            this.txt_songaynghi.Size = new System.Drawing.Size(61, 34);
            this.txt_songaynghi.TabIndex = 3;
            this.txt_songaynghi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_capnhatnghiphep
            // 
            this.btn_capnhatnghiphep.Image = ((System.Drawing.Image)(resources.GetObject("btn_capnhatnghiphep.Image")));
            this.btn_capnhatnghiphep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhatnghiphep.Location = new System.Drawing.Point(286, 162);
            this.btn_capnhatnghiphep.Name = "btn_capnhatnghiphep";
            this.btn_capnhatnghiphep.Size = new System.Drawing.Size(214, 35);
            this.btn_capnhatnghiphep.TabIndex = 22;
            this.btn_capnhatnghiphep.Text = "CẬP NHẬT NGHỈ PHÉP";
            this.btn_capnhatnghiphep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhatnghiphep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_capnhatnghiphep.UseVisualStyleBackColor = true;
            this.btn_capnhatnghiphep.Click += new System.EventHandler(this.btn_capnhatnghiphep_Click);
            // 
            // dTP_ngaybatdau
            // 
            this.dTP_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_ngaybatdau.Location = new System.Drawing.Point(99, 101);
            this.dTP_ngaybatdau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dTP_ngaybatdau.Name = "dTP_ngaybatdau";
            this.dTP_ngaybatdau.Size = new System.Drawing.Size(151, 34);
            this.dTP_ngaybatdau.TabIndex = 26;
            this.dTP_ngaybatdau.Value = new System.DateTime(2023, 10, 14, 10, 41, 9, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đến ngày";
            // 
            // dTP_ngayketthuc
            // 
            this.dTP_ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_ngayketthuc.Location = new System.Drawing.Point(370, 101);
            this.dTP_ngayketthuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dTP_ngayketthuc.Name = "dTP_ngayketthuc";
            this.dTP_ngayketthuc.Size = new System.Drawing.Size(151, 34);
            this.dTP_ngayketthuc.TabIndex = 26;
            this.dTP_ngayketthuc.Value = new System.DateTime(2023, 10, 14, 10, 41, 9, 0);
            // 
            // frmNhanSuNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(767, 204);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanSuNghiPhep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẢO NGHỈ PHÉP CHO NHÂN SỰ";
            this.Load += new System.EventHandler(this.frmNhanSuNghiPhep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNhanSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_nghiphep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_songaynghi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_capnhatnghiphep;
        private System.Windows.Forms.DateTimePicker dTP_ngayketthuc;
        private System.Windows.Forms.DateTimePicker dTP_ngaybatdau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}