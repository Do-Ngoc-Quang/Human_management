
namespace Human_management
{
    partial class frmBaoCaoNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoNhanSu));
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Taobaocao = new System.Windows.Forms.Button();
            this.cbb_phongban = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Location = new System.Drawing.Point(20, 113);
            this.rpvBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(1499, 715);
            this.rpvBaoCao.TabIndex = 0;
            // 
            // btn_Taobaocao
            // 
            this.btn_Taobaocao.Image = ((System.Drawing.Image)(resources.GetObject("btn_Taobaocao.Image")));
            this.btn_Taobaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Taobaocao.Location = new System.Drawing.Point(856, 30);
            this.btn_Taobaocao.Name = "btn_Taobaocao";
            this.btn_Taobaocao.Size = new System.Drawing.Size(174, 35);
            this.btn_Taobaocao.TabIndex = 1;
            this.btn_Taobaocao.Text = "TẠO BÁO CÁO";
            this.btn_Taobaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Taobaocao.UseVisualStyleBackColor = true;
            this.btn_Taobaocao.Click += new System.EventHandler(this.btn_Taobaocao_Click);
            // 
            // cbb_phongban
            // 
            this.cbb_phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_phongban.FormattingEnabled = true;
            this.cbb_phongban.Location = new System.Drawing.Point(576, 29);
            this.cbb_phongban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_phongban.Name = "cbb_phongban";
            this.cbb_phongban.Size = new System.Drawing.Size(260, 36);
            this.cbb_phongban.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 28);
            this.label9.TabIndex = 35;
            this.label9.Text = "PHÒNG BAN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Taobaocao);
            this.groupBox1.Controls.Add(this.cbb_phongban);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1499, 81);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LỌC THÔNG TIN";
            // 
            // frmBaoCaoNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1557, 845);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rpvBaoCao);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBaoCaoNhanSu";
            this.Text = "BÁO CÁO NHÂN SỰ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoNhanSu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.Button btn_Taobaocao;
        private System.Windows.Forms.ComboBox cbb_phongban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}