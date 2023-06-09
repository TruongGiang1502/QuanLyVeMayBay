using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
