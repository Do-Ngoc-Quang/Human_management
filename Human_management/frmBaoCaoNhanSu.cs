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
    public partial class frmBaoCaoNhanSu : Form
    {
        public frmBaoCaoNhanSu()
        {
            InitializeComponent();
        }

        private void frmBaoCaoNhanSu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
