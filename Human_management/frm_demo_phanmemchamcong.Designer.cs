
namespace Human_management
{
    partial class frm_demo_phanmemchamcong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_demo_phanmemchamcong));
            this.txt_timnhansu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTP_ngay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ghinhanchamcong = new System.Windows.Forms.Button();
            this.dTP_giora = new System.Windows.Forms.DateTimePicker();
            this.dTP_giovao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manhansu = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timnhansu
            // 
            this.txt_timnhansu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timnhansu.Location = new System.Drawing.Point(62, 33);
            this.txt_timnhansu.Name = "txt_timnhansu";
            this.txt_timnhansu.Size = new System.Drawing.Size(116, 34);
            this.txt_timnhansu.TabIndex = 2;
            this.txt_timnhansu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_timnhansu.TextChanged += new System.EventHandler(this.txt_timnhansu_TextChanged);
            this.txt_timnhansu.Enter += new System.EventHandler(this.txt_timnhansu_Enter);
            this.txt_timnhansu.Leave += new System.EventHandler(this.txt_timnhansu_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTP_ngay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_ghinhanchamcong);
            this.groupBox1.Controls.Add(this.dTP_giora);
            this.groupBox1.Controls.Add(this.dTP_giovao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_manhansu);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_timnhansu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(-10, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dTP_ngay
            // 
            this.dTP_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_ngay.Location = new System.Drawing.Point(510, 75);
            this.dTP_ngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dTP_ngay.Name = "dTP_ngay";
            this.dTP_ngay.Size = new System.Drawing.Size(189, 34);
            this.dTP_ngay.TabIndex = 26;
            this.dTP_ngay.Value = new System.DateTime(2023, 10, 14, 10, 41, 9, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ngày";
            // 
            // btn_ghinhanchamcong
            // 
            this.btn_ghinhanchamcong.Image = ((System.Drawing.Image)(resources.GetObject("btn_ghinhanchamcong.Image")));
            this.btn_ghinhanchamcong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ghinhanchamcong.Location = new System.Drawing.Point(252, 138);
            this.btn_ghinhanchamcong.Name = "btn_ghinhanchamcong";
            this.btn_ghinhanchamcong.Size = new System.Drawing.Size(225, 35);
            this.btn_ghinhanchamcong.TabIndex = 22;
            this.btn_ghinhanchamcong.Text = "GHI NHẬN CHẤM CÔNG";
            this.btn_ghinhanchamcong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghinhanchamcong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ghinhanchamcong.UseVisualStyleBackColor = true;
            this.btn_ghinhanchamcong.Click += new System.EventHandler(this.btn_ghinhanchamcong_Click);
            // 
            // dTP_giora
            // 
            this.dTP_giora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTP_giora.Location = new System.Drawing.Point(308, 75);
            this.dTP_giora.Name = "dTP_giora";
            this.dTP_giora.Size = new System.Drawing.Size(140, 34);
            this.dTP_giora.TabIndex = 5;
            // 
            // dTP_giovao
            // 
            this.dTP_giovao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTP_giovao.Location = new System.Drawing.Point(93, 75);
            this.dTP_giovao.Name = "dTP_giovao";
            this.dTP_giovao.Size = new System.Drawing.Size(140, 34);
            this.dTP_giovao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giờ ra";
            // 
            // txt_manhansu
            // 
            this.txt_manhansu.BackColor = System.Drawing.SystemColors.Window;
            this.txt_manhansu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_manhansu.Location = new System.Drawing.Point(70, 138);
            this.txt_manhansu.Name = "txt_manhansu";
            this.txt_manhansu.ReadOnly = true;
            this.txt_manhansu.Size = new System.Drawing.Size(108, 34);
            this.txt_manhansu.TabIndex = 4;
            this.txt_manhansu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_manhansu.Visible = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(252, 33);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(447, 34);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giờ vào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã";
            // 
            // frm_demo_phanmemchamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(716, 177);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_demo_phanmemchamcong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm giả lập ghi nhận chấm công";
            this.Load += new System.EventHandler(this.frm_demo_phanmemchamcong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_timnhansu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTP_giovao;
        private System.Windows.Forms.DateTimePicker dTP_giora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ghinhanchamcong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_manhansu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTP_ngay;
        private System.Windows.Forms.Label label6;
    }
}