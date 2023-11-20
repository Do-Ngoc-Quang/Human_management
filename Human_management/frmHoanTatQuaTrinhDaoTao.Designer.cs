
namespace Human_management
{
    partial class frmHoanTatQuaTrinhDaoTao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoanTatQuaTrinhDaoTao));
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.picAnhNhanSu = new System.Windows.Forms.PictureBox();
            this.txt_tendaotao = new System.Windows.Forms.TextBox();
            this.btn_hoantat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiAnh.Image")));
            this.btnTaiAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiAnh.Location = new System.Drawing.Point(782, 11);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(130, 35);
            this.btnTaiAnh.TabIndex = 45;
            this.btnTaiAnh.Text = "Tải ảnh lên";
            this.btnTaiAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // picAnhNhanSu
            // 
            this.picAnhNhanSu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhNhanSu.Location = new System.Drawing.Point(12, 51);
            this.picAnhNhanSu.Name = "picAnhNhanSu";
            this.picAnhNhanSu.Size = new System.Drawing.Size(900, 500);
            this.picAnhNhanSu.TabIndex = 44;
            this.picAnhNhanSu.TabStop = false;
            // 
            // txt_tendaotao
            // 
            this.txt_tendaotao.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tendaotao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tendaotao.Location = new System.Drawing.Point(12, 11);
            this.txt_tendaotao.Name = "txt_tendaotao";
            this.txt_tendaotao.ReadOnly = true;
            this.txt_tendaotao.Size = new System.Drawing.Size(701, 34);
            this.txt_tendaotao.TabIndex = 46;
            // 
            // btn_hoantat
            // 
            this.btn_hoantat.Image = ((System.Drawing.Image)(resources.GetObject("btn_hoantat.Image")));
            this.btn_hoantat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoantat.Location = new System.Drawing.Point(403, 557);
            this.btn_hoantat.Name = "btn_hoantat";
            this.btn_hoantat.Size = new System.Drawing.Size(121, 35);
            this.btn_hoantat.TabIndex = 47;
            this.btn_hoantat.Text = "HOÀN TẤT";
            this.btn_hoantat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hoantat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hoantat.UseVisualStyleBackColor = true;
            this.btn_hoantat.Click += new System.EventHandler(this.btn_hoantat_Click);
            // 
            // frmHoanTatQuaTrinhDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(926, 605);
            this.Controls.Add(this.btn_hoantat);
            this.Controls.Add(this.txt_tendaotao);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.picAnhNhanSu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHoanTatQuaTrinhDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOÀN TẤT QUÁ TRÌNH ĐÀO TẠO";
            this.Load += new System.EventHandler(this.frmHoanTatQuaTrinhDaoTao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNhanSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.PictureBox picAnhNhanSu;
        private System.Windows.Forms.TextBox txt_tendaotao;
        private System.Windows.Forms.Button btn_hoantat;
    }
}