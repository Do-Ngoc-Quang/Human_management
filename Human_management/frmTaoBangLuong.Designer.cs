
namespace Human_management
{
    partial class frmTaoBangLuong
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
            this.rpV_Bangluong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpV_Bangluong
            // 
            this.rpV_Bangluong.Location = new System.Drawing.Point(10, 12);
            this.rpV_Bangluong.Name = "rpV_Bangluong";
            this.rpV_Bangluong.ServerReport.BearerToken = null;
            this.rpV_Bangluong.Size = new System.Drawing.Size(1508, 726);
            this.rpV_Bangluong.TabIndex = 0;
            // 
            // frmTaoBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1530, 750);
            this.Controls.Add(this.rpV_Bangluong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTaoBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG LƯƠNG";
            this.Load += new System.EventHandler(this.frmTaoBangLuong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpV_Bangluong;
    }
}