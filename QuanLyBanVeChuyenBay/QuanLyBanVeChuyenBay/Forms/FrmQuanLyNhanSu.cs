using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmQuanLyNhanSu : Form
    {
        public FrmQuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            new FrmThemNhanVien().ShowDialog();
        }
    }
}
