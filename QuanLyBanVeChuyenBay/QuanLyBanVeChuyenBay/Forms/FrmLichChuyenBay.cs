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

    public partial class FrmLichChuyenBay : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private DataTable table2 = new DataTable();
        private DataTable table3 = new DataTable();

        public FrmLichChuyenBay()
        {
            InitializeComponent();
            LoadDataGridView2();
            LoadDataGridView3();

        }

        private void FrmLichChuyenBay_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet4.HANGVE' table. You can move, or remove it, as needed.
            this.hANGVETableAdapter1.Fill(this.qUANLYBANVECHUYENBAYDataSet4.HANGVE);
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet3.HANGVE' table. You can move, or remove it, as needed.
            this.hANGVETableAdapter.Fill(this.qUANLYBANVECHUYENBAYDataSet3.HANGVE);
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet2.SANBAY' table. You can move, or remove it, as needed.
            this.sANBAYTableAdapter2.Fill(this.qUANLYBANVECHUYENBAYDataSet2.SANBAY);
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet1.SANBAY' table. You can move, or remove it, as needed.
            this.sANBAYTableAdapter1.Fill(this.qUANLYBANVECHUYENBAYDataSet1.SANBAY);
            // TODO: This line of code loads data into the 'qUANLYBANVECHUYENBAYDataSet.SANBAY' table. You can move, or remove it, as needed.
            this.sANBAYTableAdapter.Fill(this.qUANLYBANVECHUYENBAYDataSet.SANBAY);

            connection = new SqlConnection(str);
            connection.Open();
            dataGridView3.DataSource = null;
            dataGridView2.DataSource = null;
            loaddata();
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
        string getstring(string lenhgsql)
        {
            string str;
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = lenhgsql;
            str = cmd1.ExecuteScalar().ToString();
            return cmd1.ExecuteScalar().ToString();

        }

        void Xoa(string x)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = x;
            //adapter.SelectCommand = cmd1;
            cmd1.ExecuteNonQuery();
        }

        void Sua(string x)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = x;
            //adapter.SelectCommand = cmd1;
            cmd1.ExecuteNonQuery();
        }

        int laythang(string s)
        {
            string rt = "";
            int i = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == '/')
                {
                    i += 1;
                    break;
                }
            }
            for (int j = i; s[j] != '/'; j++)
            {
                rt += s[j];
            }
            return int.Parse(rt);
        }

        int laynam(string s)
        {
            string rt = "";
            for (int i = 0; s[i] != '/'; i++)
            {
                rt += s[i];
            }
            return int.Parse(rt);
        }

        string setmabaocaothang(int thang, int nam)
        {
            if (thang < 10)
            {
                return "B0" + thang.ToString() + nam.ToString();
            }

            else
            {
                return "B" + thang.ToString() + nam.ToString();
            }
        }

        void themdgv(string slstr)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = slstr;
            cmd1.ExecuteNonQuery();
        }

        string dinhdangtiente(string s)
        {
            string tiente = "";
            for(int i=0; i<s.Length; i++)
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

        string dinhdangngaythang(string s)
        {
            string ngaythang = "";
            string re = "";
            for (int i=0; i<10; i++)
            {
                ngaythang += s[i];
            }
            for (int i = 6; i <10; i++)
            {
                re += ngaythang[i];
            }
            re += ("/" + s[3] + s[4] + "/" + s[0] + s[1]);
            return re;
        }

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select cb.MaCBay 'Mã chuyến bay',  sb2.Tensb 'Sân bay đi', sb1.Tensb 'Sân bay đến', cb.KhoiHanh 'Ngày khởi hành', cb.GioKhoiHanh 'Giờ khởi hành', cb.TgianBay " +
                "'Thời gian bay', cb.Dongia 'Don gia' " +
                "from CHUYENBAY cb left join SANBAY sb2 on cb.MaSanBayDi = sb2.MaSBay " +
                "left join SANBAY sb1 on cb.MaSanBayDen = sb1.MaSBay";
            //command.CommandText = "Select *from CHUYENBAY";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
        }

        private void LoadDataGridView2()
        {
            table2.Columns.Add("Hạng vé", typeof(string));
            table2.Columns.Add("Số lượng ghế", typeof(int));

            dataGridView2.DataSource = table2;
        }

        private void LoadDataGridView3()
        {
            table3.Columns.Add("Tên SBTG", typeof(string));
            table3.Columns.Add("Thời gian dừng", typeof(string));
            table3.Columns.Add("Ghi chú", typeof(string));

            dataGridView3.DataSource = table3;
        }

        private void LoadDataGridView23(string s, DataGridView dgv)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = s;
            adapter.SelectCommand = cmd1;
            DataTable table1 = new DataTable();
            table1.Clear();
            adapter.Fill(table1);
            //adapter.SelectCommand = cmd1;
            dgv.DataSource = table1;
        }

        void loaddata2()
        {
            table2.Columns.Add("Hạng vé", typeof(string));
            table2.Columns.Add("Số lượng ghế", typeof(int));
        }

        

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaChuyenBay.Text == "" || textBoxNgayGio.Text == "" || textBoxGioBay.Text == "" || textBoxGio.Text == "" || textBoxDonGia.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Chuyến bay chưa có ghế", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                int checkvalue = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBoxMaChuyenBay.Text)
                    {
                        checkvalue += 1;
                        break;
                    }
                }

                if (checkvalue != 0)
                {
                    MessageBox.Show("Mã chuyến bay bị trùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkvalue = 0;
                }

                else if (comboBoxSBDi.Text == comboBoxSBDen.Text)
                {
                    MessageBox.Show("Mã sân bay đi trùng mã sân bay đến", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (int.Parse(textBoxDonGia.Text) < 0)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (int.Parse(textBoxGio.Text) * 60 + int.Parse(textBoxphut.Text) < setthamso("Select Thoigianbaytt from THAMSO"))
                    {
                        MessageBox.Show("Thời gian bay nhỏ hơn thời gian bay tối thiểu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        command = connection.CreateCommand();
                        int tgianbay = int.Parse(textBoxGio.Text) * 60 + int.Parse(textBoxphut.Text);
                        command.CommandText =
                            "insert into  CHUYENBAY values " +
                            "('" + textBoxMaChuyenBay.Text + "', '" + getstring("Select MaSBay from SANBAY where Tensb = '" + comboBoxSBDi.Text + "'") + "', '" + getstring("Select MaSBay from SANBAY where Tensb = '" + comboBoxSBDen.Text + "'") + "', '" + textBoxNgayGio.Text + "', '" + textBoxGioBay.Text + "', '" + textBoxDonGia.Text + "', '" + tgianbay.ToString() + "')";
                        command.ExecuteNonQuery();
                        for (int i = 0; i < dataGridView2.Rows.Count ; i++)
                        {
                            themdgv("insert into SOLUONGHANGVE values ('" +getstring( "select MaHangVe from HANGVE where TenHangVe = '"+ dataGridView2.Rows[i].Cells["Hạng vé"].Value +"'")+ "', '" + textBoxMaChuyenBay.Text + "','" + dataGridView2.Rows[i].Cells["Số lượng ghế"].Value + "', '')");
                        }

                        for (int i = 0; i < dataGridView3.Rows.Count ; i++)
                        {
                            themdgv("insert into THONGTINSANBAYTRUNGGIAN values ('" + textBoxMaChuyenBay.Text + "','" + getstring("Select MaSBay from SANBAY where Tensb = '" + dataGridView3.Rows[i].Cells["Tên SBTG"].Value + "'") + "', '" + dataGridView3.Rows[i].Cells["Thời gian dừng"].Value + "', '" + dataGridView3.Rows[i].Cells["Ghi chú"].Value + "')");
                        }

                        string mabaocao = setmabaocaothang(laythang(textBoxNgayGio.Text), laynam(textBoxNgayGio.Text));
                        themdgv("insert into CHITIETBAOCAOTHANG values ('" + textBoxMaChuyenBay.Text + "', '" + mabaocao + "', '', '')");

                        loaddata();
                    }
                }

            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa dữ liệu về chuyến bay này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                DialogResult dlr1 = MessageBox.Show("Thao tác này sẽ xóa toàn bộ dữ liệu về chuyến bay, hãy chắc chắn rằng bạn đã sao lưu những dữ liệu cần thiết!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlr1 == DialogResult.OK)
                {
                    Xoa("delete CHITIETBAOCAOTHANG where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                    Xoa("delete SOLUONGHANGVE where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                    Xoa("delete THONGTINSANBAYTRUNGGIAN where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                    Xoa("delete VECHUYENBAY where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                    Xoa("delete VITRIGHE where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                    Xoa("delete CHUYENBAY where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                    loaddata();
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn cập nhật thông tin chuyến bay? Lưu ý số ghế của chuyến bay không thể sửa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                Sua("Update CHUYENBAY set KhoiHanh = '" + textBoxNgayGio.Text + "' where MaCBay = '"+textBoxMaChuyenBay.Text+"'");
                Sua("Update CHUYENBAY set GioKhoiHanh = '" + textBoxGioBay.Text + "' where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                Sua("Update CHUYENBAY set Dongia = '" + textBoxDonGia.Text + "' where MaCBay = '" + textBoxMaChuyenBay.Text + "'");
                int tgianbay = int.Parse(textBoxGio.Text) * 60 + int.Parse(textBoxphut.Text);
                Sua("Update CHUYENBAY set TgianBay = '" + tgianbay.ToString() + "'");
                Xoa("delete THONGTINSANBAYTRUNGGIAN where MaCBay = '" + textBoxMaChuyenBay.Text + "'");

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    themdgv("insert into THONGTINSANBAYTRUNGGIAN values ('" + textBoxMaChuyenBay.Text + "','" + getstring("Select MaSBay from SANBAY where Tensb = '" + dataGridView3.Rows[i].Cells["Tên SBTG"].Value + "'") + "', '" + dataGridView3.Rows[i].Cells["Thời gian dừng"].Value + "', '" + dataGridView3.Rows[i].Cells["Ghi chú"].Value + "')");
                }
                loaddata();
            }
        }

        private void buttonAddSanBayTG_Click(object sender, EventArgs e)
        {
            if (MaSbTG.Text == comboBoxSBDi.Text)
            {
                MessageBox.Show("Sân bay trung gian trùng sân bay đi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (MaSbTG.Text == comboBoxSBDen.Text)
            {
                MessageBox.Show("Sân bay trung gian trùng sân bay đến", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TgianDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thời gian dừng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (int.Parse(TgianDung.Text) < setthamso("Select Tgiandungtoithieu from thamso"))
            {
                MessageBox.Show("Thời gian dừng nhỏ hơn thời gian dừng tối thiểu", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (int.Parse(TgianDung.Text) > setthamso("Select Tgiandungtoida from thamso"))
            {
                MessageBox.Show("Thời gian dừng lớn hơn thời gian dừng tối đa", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (dataGridView3.Rows.Count == setthamso("Select SLSbayTGtoida from THAMSO") )
            {
                MessageBox.Show("Số lượng sân bay trung gian đã đạt tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                bool k = false;
                if (dataGridView3.DataSource == null)
                {
                    table3.Rows.Add(MaSbTG.Text, TgianDung.Text, tbGhiChu.Text);
                    dataGridView3.DataSource = table3;
                }

                else
                {
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        if (dataGridView3.Rows[i].Cells[0].Value != null && MaSbTG.Text == dataGridView3.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Sân bay trung gian này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            k = true;
                            break;
                        }
                    }
                    if (k == false)
                    {
                        table3.Rows.Add(MaSbTG.Text, TgianDung.Text, tbGhiChu.Text);
                        dataGridView3.DataSource = table3;
                    }
                }

            }
        }

        private void btaddHangVe_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số ghế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(textBox2.Text) <= 0)
            {
                MessageBox.Show("Số ghế phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                bool k = false;
                if (dataGridView2.DataSource == null)
                {
                    table2.Rows.Add(comboBoxHangVe.Text, textBox2.Text);
                    dataGridView2.DataSource = table2;
                }
                else
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value != null && comboBoxHangVe.Text == dataGridView2.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Hạng ghế đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            k = true;
                            break;
                        }
                    }
                    if (k == false)
                    {
                        table2.Rows.Add(comboBoxHangVe.Text, textBox2.Text);
                        dataGridView2.DataSource = table2;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxMaChuyenBay.Text = string.Empty;
            textBoxNgayGio.Text = string.Empty;
            textBoxGioBay.Text = string.Empty;
            textBoxGio.Text = string.Empty;
            textBoxphut.Text = string.Empty;
            textBoxDonGia.Text = string.Empty;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;

            textBoxMaChuyenBay.Enabled = true;
            comboBoxSBDi.Enabled = true;
            comboBoxSBDen.Enabled = true;
        }

        private void pictureBoxNgayBay_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgayGio.Text, out var currentDateTime) ?
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxMaChuyenBay.Text = row.Cells[0].Value.ToString();
                comboBoxSBDi.Text = row.Cells[1].Value.ToString();
                comboBoxSBDen.Text = row.Cells[2].Value.ToString();
                textBoxNgayGio.Text = dinhdangngaythang (row.Cells[3].Value.ToString());
                textBoxGioBay.Text = row.Cells[4].Value.ToString();
                textBoxDonGia.Text = dinhdangtiente (row.Cells[6].Value.ToString());
                int gio = int.Parse(row.Cells[5].Value.ToString()) / 60;
                int phut = int.Parse(row.Cells[5].Value.ToString()) % 60;
                textBoxGio.Text = gio.ToString();
                textBoxphut.Text = phut.ToString();
                LoadDataGridView23("Select TenHangVe 'Hạng Vé', SoLuongGhe 'Số lượng ghế' " +
                    "from SOLUONGHANGVE sl left join HANGVE hv on sl.MaHangVe = hv.MaHangVe" +
                    " where MaCBay = '" + textBoxMaChuyenBay.Text + "'", dataGridView2);
                LoadDataGridView23("Select TenSb 'Tên SBTG', ThoiGianDung 'Thời gian dừng', GhiChu 'Ghi chú' " +
                    "from THONGTINSANBAYTRUNGGIAN tt left join SANBAY sb on tt.MaSBayTrungGian = sb.MaSBay  where MaCBay = '" + textBoxMaChuyenBay.Text + "'", dataGridView3);
                dataGridView2.ReadOnly = true;
                textBoxMaChuyenBay.Enabled = false;
                comboBoxSBDi.Enabled = false;
                comboBoxSBDen.Enabled = false;
                
            }
        }

        private void CalendarFormOnDateTimeHandlerNgayBay(DateTime sender)
        {
            textBoxNgayGio.Text = $"{sender.ToString("yyyy/MM/dd")}";
        }

        private void textBoxGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxphut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TgianDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonxoaSBTG_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView3.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView3.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void btdlthangve_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}
