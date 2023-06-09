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
    public partial class FrmThemNhanVien : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int RightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public FrmThemNhanVien()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void pictureBoxNgaySinh_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgaySinh.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgaySinh;
                calendarForm.ShowDialog();

            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgaySinh;
                calendarForm.Dispose();
            }
        }

        private void CalendarFormOnDateTimeHandlerNgaySinh(DateTime sender)
        {
            textBoxNgaySinh.Text = $"{sender.ToString("dd-MM-yyyy")}";
        }

        private void buttonHoanTat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxNgayBatDau_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgayBatDau.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgayBatDau;
                calendarForm.ShowDialog();

            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgayBatDau;
                calendarForm.Dispose();
            }
        }

        private void CalendarFormOnDateTimeHandlerNgayBatDau(DateTime sender)
        {
            textBoxNgayBatDau.Text = $"{sender.ToString("dd-MM-yyyy")}";
        }
    }
}
