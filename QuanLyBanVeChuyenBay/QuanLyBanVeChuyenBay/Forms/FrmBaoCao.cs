using System;
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
    public partial class FrmBaoCao : Form
    {
        SqlConnection connection;


        string str = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog=QUANLYBANVECHUYENBAY;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table1 = new DataTable();

        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        string getstring(string lenhgsql)
        {
            string str;
            SqlCommand cmd1 = new SqlCommand();
            cmd1 = connection.CreateCommand();
            cmd1.CommandText = lenhgsql;
            return cmd1.ExecuteScalar().ToString();

        }
        void loaddgv(string s, DataGridView dgv)
        {
            SqlCommand command;
            DataTable table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = s;
            //command.CommandText = "Select *from CHUYENBAY";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
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

        private void tracuu_Click(object sender, EventArgs e)
        {
            if (cbxThang.Text == "")
            {
                MessageBox.Show("Chưa chọn tháng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (cbxNam.Text == "")
            {
                MessageBox.Show("Chưa chọn năm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                if (int.Parse(dinhdangtiente(getstring("Select Sum(Dthuthang) " +
                    "from BAOCAOTHANG left join CHITIETBAOCAOTHANG on BAOCAOTHANG.MaBaoCaoThang = CHITIETBAOCAOTHANG.Mabaocaothang " +
                    "where Thang = '"+cbxThang.Text+"' and Nam = '"+cbxNam.Text+"'"))) == 0)
                {
                    loaddgv("Select MaCBay 'Mã chuyến bay', Sove 'Số vé', Dthuthang 'Doanh thu tháng', (select Sum(Dthuthang) " +
                    "from BAOCAOTHANG left join CHITIETBAOCAOTHANG on BAOCAOTHANG.MaBaoCaoThang = CHITIETBAOCAOTHANG.Mabaocaothang where Thang = '" + cbxThang.Text + "' and Nam = '" + cbxNam.Text + "') 'Tỉ lệ (%)' " +
                    "from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang " +
                    "where Thang = '" + cbxThang.Text + "' and Nam = '" + cbxNam.Text + "' " +
                    "Group by MaCBay, Sove, Dthuthang, Nam", dgvBCT);
                }

                else
                {
                    loaddgv("Select MaCBay 'Mã chuyến bay', Sove 'Số vé', Dthuthang 'Doanh thu tháng', (Dthuthang / (select Sum(Dthuthang) " +
                        "from BAOCAOTHANG left join CHITIETBAOCAOTHANG on BAOCAOTHANG.MaBaoCaoThang = CHITIETBAOCAOTHANG.Mabaocaothang where Thang = '" + cbxThang.Text + "' and Nam = '" + cbxNam.Text + "')) *100 'Tỉ lệ (%)' " +
                        "from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang " +
                        "where Thang = '" + cbxThang.Text + "' and Nam = '" + cbxNam.Text + "' " +
                        "Group by MaCBay, Sove, Dthuthang, Nam", dgvBCT);
                }

                tbDTT.Text = getstring("Select Sum(Dthuthang) 'Tong doanh thu thang'from BAOCAOTHANG bct " +
                    "left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang " +
                    "where Thang='" + cbxThang.Text + "' and Nam = '" + cbxNam.Text + "'");

                if (int.Parse(dinhdangtiente(getstring("select Sum(Dthuthang) " +
                    "from CHITIETBAOCAOTHANG"))) == 0)
                {
                    loaddgv("Select Thang 'Tháng', Count(MaCBay) 'Số chuyến bay', Sum(Dthuthang) 'Doanh thu', (select Sum(Dthuthang) " +
                   "from CHITIETBAOCAOTHANG)'Tỉ lệ (%)' from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang " +
                   "where Nam = '" + cbxNam.Text + "' group by  Thang", dgvBCN);
                }

                else
                {

                    loaddgv("Select Thang 'Tháng', Count(MaCBay) 'Số chuyến bay', Sum(Dthuthang) 'Doanh thu', (Sum(Dthuthang)/(select Sum(Dthuthang) " +
                        "from CHITIETBAOCAOTHANG))*100 'Tỉ lệ (%)' from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang " +
                        "where Nam = '" + cbxNam.Text + "' group by  Thang", dgvBCN);
                }

                tbDTN.Text = getstring("Select Sum(Dthuthang) 'Tong doanh thu nam' " +
                    "from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang " +
                    "where Nam = '" + cbxNam.Text + "'");

                dgvBCN.ReadOnly = true;
                dgvBCT.ReadOnly = true;

                tbDTT.Enabled = false;
                tbDTN.Enabled = false;
            }
        }
    }
}
