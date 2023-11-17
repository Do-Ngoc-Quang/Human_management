
namespace Human_management
{
    partial class frmTiepNhanVaBanGiaoCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiepNhanVaBanGiaoCV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_chucdanh = new System.Windows.Forms.ComboBox();
            this.cbb_phongban = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_bangiaonhansu = new System.Windows.Forms.Button();
            this.txtMaNhanSu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNhanSu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_bangiaonhansu);
            this.groupBox1.Controls.Add(this.cbb_chucdanh);
            this.groupBox1.Controls.Add(this.cbb_phongban);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 243);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "CHỨC DANH";
            // 
            // cbb_chucdanh
            // 
            this.cbb_chucdanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chucdanh.FormattingEnabled = true;
            this.cbb_chucdanh.Location = new System.Drawing.Point(119, 134);
            this.cbb_chucdanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_chucdanh.Name = "cbb_chucdanh";
            this.cbb_chucdanh.Size = new System.Drawing.Size(260, 36);
            this.cbb_chucdanh.TabIndex = 32;
            // 
            // cbb_phongban
            // 
            this.cbb_phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_phongban.FormattingEnabled = true;
            this.cbb_phongban.Location = new System.Drawing.Point(119, 95);
            this.cbb_phongban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_phongban.Name = "cbb_phongban";
            this.cbb_phongban.Size = new System.Drawing.Size(260, 36);
            this.cbb_phongban.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 28);
            this.label9.TabIndex = 33;
            this.label9.Text = "PHÒNG BAN";
            // 
            // btn_bangiaonhansu
            // 
            this.btn_bangiaonhansu.Image = ((System.Drawing.Image)(resources.GetObject("btn_bangiaonhansu.Image")));
            this.btn_bangiaonhansu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bangiaonhansu.Location = new System.Drawing.Point(90, 191);
            this.btn_bangiaonhansu.Name = "btn_bangiaonhansu";
            this.btn_bangiaonhansu.Size = new System.Drawing.Size(228, 35);
            this.btn_bangiaonhansu.TabIndex = 34;
            this.btn_bangiaonhansu.Text = "THỰC HIỆN BÀN GIAO";
            this.btn_bangiaonhansu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_bangiaonhansu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bangiaonhansu.UseVisualStyleBackColor = true;
            this.btn_bangiaonhansu.Click += new System.EventHandler(this.btn_bangiaonhansu_Click);
            // 
            // txtMaNhanSu
            // 
            this.txtMaNhanSu.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNhanSu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhanSu.Location = new System.Drawing.Point(119, 21);
            this.txtMaNhanSu.Name = "txtMaNhanSu";
            this.txtMaNhanSu.ReadOnly = true;
            this.txtMaNhanSu.Size = new System.Drawing.Size(260, 34);
            this.txtMaNhanSu.TabIndex = 36;
            this.txtMaNhanSu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "MÃ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(119, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(260, 34);
            this.txtHoTen.TabIndex = 38;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "HỌ TÊN";
            // 
            // frmTiepNhanVaBanGiaoCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(418, 254);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTiepNhanVaBanGiaoCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀN GIAO NHÂN SỰ";
            this.Load += new System.EventHandler(this.frmTiepNhanVaBanGiaoCV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_chucdanh;
        private System.Windows.Forms.ComboBox cbb_phongban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_bangiaonhansu;
        private System.Windows.Forms.TextBox txtMaNhanSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
    }
}