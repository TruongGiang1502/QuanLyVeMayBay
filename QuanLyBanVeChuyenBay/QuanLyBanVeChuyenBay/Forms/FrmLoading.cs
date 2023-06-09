using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmLoading : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int RightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public FrmLoading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            ProgressBarLoad.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBarLoad.Value += 4;
            ProgressBarLoad.Text = ProgressBarLoad.Value.ToString() + "%";
            ProgressBarLoad.Increment(2);

            if (ProgressBarLoad.Value == 100)
            {
                timer1.Enabled = false;
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }
    }
}
