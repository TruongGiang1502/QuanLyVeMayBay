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
    public partial class FrmThongTinDatVe : Form
    {
        public FrmThongTinDatVe()
        {
            InitializeComponent();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            ChangeReadOnly(groupBox1);
            ChangeReadOnly(groupBox2);
            comboBoxGio.Visible = true;
        }

        private void ChangeReadOnly(GroupBox x)
        {
            foreach (Control btns in x.Controls)
            {
                if (btns.GetType() == typeof(TextBox) && !btns.Name.Equals("textBoxGiaTien") && !btns.Name.Equals("textBoxMaKhachHang"))
                {
                    TextBox txb = (TextBox)btns;
                    txb.ReadOnly = false;
                }
                if (btns.GetType() == typeof(PictureBox))
                {
                    PictureBox pic = (PictureBox)btns;
                    pic.Visible = true;
                }
            }
        }

        private void ChangeText(GroupBox x)
        {
            foreach (Control btns in x.Controls)
            {
                if (btns.GetType() == typeof(TextBox))
                {
                    TextBox txb = (TextBox)btns;
                    txb.Text = "";
                }
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            ChangeText(groupBox1);
            ChangeText(groupBox2);
        }

        private void pictureBoxNgayBay_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgay.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgayBay;
                calendarForm.ShowDialog();

            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgayBay;
                calendarForm.Dispose();
            }
        }

        private void CalendarFormOnDateTimeHandlerNgayBay(DateTime sender)
        {
            textBoxNgay.Text = $"{sender.ToString("dd-MM-yyyy")}";
        }
    }
}
