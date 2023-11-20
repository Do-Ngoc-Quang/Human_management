
namespace Human_management
{
    partial class frmGhiNhanDaoTao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_dsdaotao = new System.Windows.Forms.DataGridView();
            this.id_daotao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendaotao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_dsdaotao)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_dsdaotao
            // 
            this.dGV_dsdaotao.AllowUserToAddRows = false;
            this.dGV_dsdaotao.AllowUserToDeleteRows = false;
            this.dGV_dsdaotao.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_dsdaotao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_dsdaotao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_dsdaotao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_daotao,
            this.mns,
            this.mdt,
            this.tendaotao,
            this.ketqua});
            this.dGV_dsdaotao.Location = new System.Drawing.Point(13, 14);
            this.dGV_dsdaotao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGV_dsdaotao.Name = "dGV_dsdaotao";
            this.dGV_dsdaotao.RowHeadersWidth = 51;
            this.dGV_dsdaotao.RowTemplate.Height = 24;
            this.dGV_dsdaotao.Size = new System.Drawing.Size(985, 312);
            this.dGV_dsdaotao.TabIndex = 1;
            this.dGV_dsdaotao.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_dsdaotao_CellValueChanged);
            // 
            // id_daotao
            // 
            this.id_daotao.DataPropertyName = "id_daotao";
            this.id_daotao.HeaderText = "id_daotao";
            this.id_daotao.MinimumWidth = 6;
            this.id_daotao.Name = "id_daotao";
            this.id_daotao.Visible = false;
            this.id_daotao.Width = 125;
            // 
            // mns
            // 
            this.mns.DataPropertyName = "mns";
            this.mns.HeaderText = "mns";
            this.mns.MinimumWidth = 6;
            this.mns.Name = "mns";
            this.mns.Visible = false;
            this.mns.Width = 125;
            // 
            // mdt
            // 
            this.mdt.DataPropertyName = "mdt";
            this.mdt.HeaderText = "mdt";
            this.mdt.MinimumWidth = 6;
            this.mdt.Name = "mdt";
            this.mdt.Visible = false;
            this.mdt.Width = 125;
            // 
            // tendaotao
            // 
            this.tendaotao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tendaotao.DataPropertyName = "tendaotao";
            this.tendaotao.HeaderText = "Khóa học";
            this.tendaotao.MinimumWidth = 6;
            this.tendaotao.Name = "tendaotao";
            // 
            // ketqua
            // 
            this.ketqua.DataPropertyName = "ketqua";
            this.ketqua.HeaderText = "Hoàn thành";
            this.ketqua.MinimumWidth = 6;
            this.ketqua.Name = "ketqua";
            this.ketqua.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "GHI NHẬN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmGhiNhanDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1014, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGV_dsdaotao);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGhiNhanDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GHI NHẬN THÔNG TIN ĐÀO TẠO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGhiNhanDaoTao_FormClosed);
            this.Load += new System.EventHandler(this.frmGhiNhanDaoTao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_dsdaotao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_dsdaotao;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_daotao;
        private System.Windows.Forms.DataGridViewTextBoxColumn mns;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendaotao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ketqua;
        private System.Windows.Forms.Button button1;
    }
}