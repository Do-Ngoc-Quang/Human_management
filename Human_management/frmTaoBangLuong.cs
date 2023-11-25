using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_management
{
    public partial class frmTaoBangLuong : Form
    {
        public frmTaoBangLuong()
        {
            InitializeComponent();
        }

        private void frmTaoBangLuong_Load(object sender, EventArgs e)
        {
            this.rpV_Bangluong.RefreshReport();
            show_report(@"C:\Do Ngoc Quang\HK1-Y3\HRM\Human_management\Human_management\ReportBangLuong.rdlc");
        }
        public void show_report(string path)
        {
            rpV_Bangluong.LocalReport.ReportPath = path;
            rpV_Bangluong.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpV_Bangluong.ZoomMode = ZoomMode.FullPage;
            rpV_Bangluong.ZoomPercent = 100;

        }
    }
}
