using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmDatCho : Form
    {
        SqlConnection connection;

        string str = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();

        public FrmDatCho()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        List<KhachHang> dataList = new List<KhachHang>();
        List<Ve> listVe = new List<Ve>();

        void xulysql(string slstr)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = slstr;
            cmd1.ExecuteNonQuery();
        }

        private void pictureBoxNgayDatVe_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgayDatVe.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgayDatVe;
                calendarForm.ShowDialog();
            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgayDatVe;
                calendarForm.Dispose();
            }
        }

        public void AddKHToDB()
        {
            string a, d, e;
            string b, c;
            for(int i=0;i<dataList.Count;++i)
            {
                a = dataList[i].getTenKH;
                b = dataList[i].getCMND;
                c = dataList[i].getSDT;
                d = dataList[i].getEmail;
                e = dataList[i].getNgaySinh;
                // viet ham them khach hang vao database voi các data tren (abcde)
                xulysql("insert into HANHKHACH values ('"+b+"', '"+a+"', '"+c+"', '"+e+"', '"+d+"')");
            }
        }

        int setthamso(string lenhgsql)
        {
            int thamso;
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = lenhgsql;
            thamso = int.Parse(cmd1.ExecuteScalar().ToString());
            return thamso;
        }
        public void AddVeToDB(int x)
        {
         
                string a, b, c, d, e;
                for (int i = 0; i < dataList.Count; ++i)
                {
                    a = listVe[i].getTenHK;
                    b = listVe[i].getMaCB;
                    c = listVe[i].getNgayBan;

                    string getstring(string lenhgsql)
                    {
                        string str;
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1 = connection.CreateCommand();
                        cmd1.CommandText = lenhgsql;
                        str = cmd1.ExecuteScalar().ToString();
                        return cmd1.ExecuteScalar().ToString();

                    }

                    d = getstring("select MaHangVe from HANGVE where TenHangVe = '" + listVe[i].getHangVe + "'");
                    e = listVe[i].getGiaVe;
                    // viet ham them ve chuyen bay vao database voi các data tren (abcde)
                    if (x == 0)
                    {
                        xulysql("insert into VECHUYENBAY values ( '','" + a + "', '" + b + "', '" + d + "', '" + c + "', '" + e + "', 'Chua thanh toan')");
                        //tinh trang ve = dat cho
                    }
                    else
                    {
                        xulysql("insert into VECHUYENBAY values ('','" + a + "', '" + b + "', '" + d + "', '" + c + "', '" + e + "', 'Da thanh toan')");
                        //tinh trang ve = thanh toan
                    }
                }
            
            

            
        }

        private void CalendarFormOnDateTimeHandlerNgayDatVe(DateTime sender)
        {
            textBoxNgayDatVe.Text = $"{sender.ToString("yyyy/MM/dd")}";
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(TextBox))
                {
                    TextBox txb = (TextBox)btns;
                    txb.Text = "";
                }
            }
        }

        private void pictureBoxNgayBay_Click(object sender, EventArgs e)
        {
            //FrmCalendar calendarForm = null;

            //try
            //{
            //    // decide to pass a date time or not
            //    calendarForm = DateTime.TryParse(textBoxNgay.Text, out var currentDateTime) ?
            //        new FrmCalendar(currentDateTime) :
            //        new FrmCalendar();

            //    // reposition to be next to calendar button
            //    calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

            //    calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgayBay;
            //    calendarForm.ShowDialog();

            //}
            //finally
            //{
            //    calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgayBay;
            //    calendarForm.Dispose();
            //}
        }

        private void CalendarFormOnDateTimeHandlerNgayBay(DateTime sender)
        {
            textBoxNgay.Text = $"{sender.ToString("yyyy/MM/dd")}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            textBoxNgaySinh.Text = $"{sender.ToString("yyyy/MM/dd")}";
        }

        public void SetData(string MaCB, string SBDi, string Ngay, string SBDen, string gio)
        {
            textBoxMaChuyenBay.Text = MaCB;
            textBoxSanBayDi.Text = SBDi;
            textBoxSanBayDen.Text = SBDen;
            textBoxNgay.Text = Ngay;
            textBoxNgayDatVe.Text = DateTime.Now.ToString("yyyy/MM/dd");
            comboBoxGio.Text = gio;
        }

        public void ResetData()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(TextBox))
                {
                    TextBox txb = (TextBox)btns;
                    txb.Text = "";
                }
            }
        }
        private bool checkDataNull()
        {
            if (comboBoxHangVe.Text.Equals("") || textBoxNgayDatVe.Text.Equals("") || textBoxCMND.Text.Equals("") || textBoxDienThoai.Text.Equals("") || textBoxEmail.Text.Equals("") || textBoxTenHanhKhach.Text.Equals("") || textBoxNgaySinh.Text.Equals(""))
                return true;
            return false;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (checkDataNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                table.Rows.Add(textBoxMaChuyenBay.Text, textBoxTenHanhKhach.Text, textBoxNgay.Text, textBoxSanBayDi.Text, textBoxSanBayDen.Text);
                KhachHang k = new KhachHang(textBoxTenHanhKhach.Text, textBoxCMND.Text, textBoxDienThoai.Text, textBoxEmail.Text, textBoxNgaySinh.Text);
                dataList.Add(k);
                Ve v = new Ve(textBoxTenHanhKhach.Text, textBoxMaChuyenBay.Text, comboBoxHangVe.Text, textBoxNgayDatVe.Text, textBoxGiaTien.Text);
                listVe.Add(v);
                dataGridViewPhieuDatCho.DataSource = table;
            }
        }

        private void FrmDatCho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet7.HANGVE' table. You can move, or remove it, as needed.
            this.hANGVETableAdapter.Fill(this.qUANLYBANVECHUYENBAYDataSet7.HANGVE);

            connection = new SqlConnection(str);
            connection.Open();
            table.Columns.Add("Mã chuyến bay", typeof(string));
            table.Columns.Add("Tên hành khách", typeof(string));
            table.Columns.Add("Ngày - giờ", typeof(string));
            table.Columns.Add("Sân bay đi", typeof(string));
            table.Columns.Add("Sân bay đến", typeof(string));
            dataGridViewPhieuDatCho.DataSource = table;
            double dongia = double.Parse(dinhdangtiente(getstring("Select Dongia from CHUYENBAY where MaCBay = '" + textBoxMaChuyenBay.Text + "'")));
            double tile = settile("Select TiLe from HANGVE where TenHangVe = '" + comboBoxHangVe.Text + "'");
            double giave = dongia * tile;
            textBoxGiaTien.Text = giave.ToString();
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDatCho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt chỗ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuDatCho.SelectedRows.Count > 0)
            {
                int index = dataGridViewPhieuDatCho.SelectedRows[0].Index;
                dataGridViewPhieuDatCho.Rows.RemoveAt(index);
                dataList.RemoveAt(index);
                listVe.RemoveAt(index);
            }
        }

        double settile(string lenhgsql)
        {
            double thamso;
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = lenhgsql;
            thamso = double.Parse(cmd1.ExecuteScalar().ToString());
            return thamso;
        }

        string getstring(string lenhgsql)
        {
            string str;
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = lenhgsql;
            str = cmd1.ExecuteScalar().ToString();
            return cmd1.ExecuteScalar().ToString();

        }

        string dinhdangtiente(string s)
        {
            string tiente = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ',')
                {
                    tiente += s[i];
                }
                else
                    break;
            }
            return tiente;
        }

        private void textBoxGiaTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHangVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxMaChuyenBay.Text != "" || comboBoxHangVe.Text != "")
            {
                double dongia = double.Parse(dinhdangtiente(getstring("Select Dongia from CHUYENBAY where MaCBay = '" + textBoxMaChuyenBay.Text + "'")));
                double tile = settile("Select TiLe from HANGVE where TenHangVe = '" + comboBoxHangVe.Text + "'");
                double giave = dongia * tile;
                textBoxGiaTien.Text = giave.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}