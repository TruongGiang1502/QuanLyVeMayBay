using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmTraCuu : Form
    {
      
        public FrmTraCuu()
        {
            InitializeComponent();
        }

        FrmDatCho frm = new FrmDatCho();

        private void pictureBoxNgayBay_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgayBay.Text, out var currentDateTime) ?
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
            textBoxNgayBay.Text = $"{sender.ToString("yyyy/MM/dd")}";
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            if (!String.IsNullOrEmpty(comboBoxSanBayDi.Text) && !String.IsNullOrEmpty(comboBoxSanBayDen.Text))
            {
                var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
                var sqlConn = new SqlConnection(strConn);
                sqlConn.Open();
                string sql = "SELECT CB.MaCBay 'Mã chuyến bay', CB.KhoiHanh 'Ngày khởi hành', CB.GioKhoiHanh 'Giờ khởi hành' ,SB2.Tensb 'Tên sân bay đi', " +
                             "SB1.Tensb 'Tên sân bay đến', SB.Tensb 'Tên sân bay trung gian', " +
                             "(SELECT(SUM(S1.SoLuongGhe) - SUM(S1.SoGheDat)) FROM SOLUONGHANGVE S1 WHERE S1.MaCBay = CB.MaCBay) 'Số ghế trống', CB.Dongia 'Đơn giá' " +
                             "FROM CHUYENBAY CB LEFT JOIN THONGTINSANBAYTRUNGGIAN TT ON CB.MaCBay = TT.MaCBay " +
                             "LEFT JOIN SANBAY SB2 ON CB.MaSanBayDi = SB2.MaSBay " +
                             "LEFT JOIN SANBAY SB1 ON CB.MaSanBayDen = SB1.MaSBay " +
                             "LEFT JOIN SANBAY SB ON TT.MaSBayTrungGian = SB.MaSBay " +
                             "WHERE SB2.Tensb = '" + comboBoxSanBayDi.Text + "' AND SB1.Tensb = '" + comboBoxSanBayDen.Text + "' AND CB.KHOIHANH = '"+textBoxNgayBay.Text+ "'";// lay het du lieu trong bang sinh vien
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu 
                SqlCommand com = new SqlCommand(sql, sqlConn); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                da.Fill(dt);  // đổ dữ liệu vào kho
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.FlatStyle = FlatStyle.Popup;
                btn.CellTemplate.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#49CC9A");
                btn.Text = "Đặt vé";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                sqlConn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        string dinhdangngaythang(string s)
        {
            string ngaythang = "";
            string re = "";
            for (int i = 0; i < 10; i++)
            {
                ngaythang += s[i];
            }
            for (int i = 6; i < 10; i++)
            {
                re += ngaythang[i];
            }
            re += ("/" + s[3] + s[4] + "/" + s[0] + s[1]);
            return re;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                string MaCB = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string SBDi = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string Ngay = dinhdangngaythang(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                string SBDen = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string gio = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.Controls.Add(panelShow);
                panelShow.Size = this.Size;
                panelShow.Location = new Point(0, 0);
                panelShow.Visible = true;
                frm.SetData(MaCB, SBDi, Ngay, SBDen, gio);
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.Visible = true;
                panelShow.Controls.Add(frm);
                panelShow.BringToFront();
                frm.pictureBox2.Click += Click;
                frm.buttonDatCho.Click += Click2;
                frm.buttonThanhToan.Click += Click1;
            }
        }

        public void Click(object sender, EventArgs e)
        {
            panelShow.Visible = false;
            frm.ResetData();
        }

      
    

        public void Click1(object sender, EventArgs e)
        {
            
               MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               panelShow.Visible = false;
               frm.ResetData();
               frm.AddKHToDB();
               frm.AddVeToDB(1);
            
        }
        public void Click2(object sender, EventArgs e)
        {
           
                MessageBox.Show("Đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelShow.Visible = false;
                frm.ResetData();
                frm.AddKHToDB();
                frm.AddVeToDB(0);
            
        }

        private void FrmTraCuu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet6.SANBAY' table. You can move, or remove it, as needed.
            this.sANBAYTableAdapter1.Fill(this.qUANLYBANVECHUYENBAYDataSet6.SANBAY);
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet5.SANBAY' table. You can move, or remove it, as needed.
            this.sANBAYTableAdapter.Fill(this.qUANLYBANVECHUYENBAYDataSet5.SANBAY);

        }
    }
}
