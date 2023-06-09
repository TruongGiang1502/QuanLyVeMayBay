using QuanLyBanVeChuyenBay.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay
{
    public partial class FormMain : Form
    {
        private Button currentButton;
        Form activeForm;

        public String User;

        public void SetData(String x)
        {
            User = x;
        }

        public FormMain()
        {
            InitializeComponent();
            buttonCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(27, 105, 134); ;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = Color.FromArgb(27, 105, 134);
                    labelTitle.BackColor = Color.FromArgb(27, 105, 134);
                    buttonCloseChildForm.BackColor = Color.FromArgb(27, 105, 134);
                    buttonCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(11, 68, 86);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenchildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void buttonLichChuyenBay_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmLichChuyenBay(), sender);
        }

        private void buttonDatVeChuyenBay_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmTraCuu(), sender);
        }

        private void buttonQuyDinh_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmQuyDinh(), sender);
        }

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmBaoCao(), sender);
        }

        private void buttonThongTin_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmThongTinDatVe(), sender);
        }

        private void buttonQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmQuanLyNhanSu(), sender);
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "QUẢN LÝ BÁN VÉ MÁY BAY";
            panelTitle.BackColor = Color.FromArgb(27, 105, 134);
            currentButton = null;
            buttonCloseChildForm.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckAccountManager()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            var sqlCommand = new SqlCommand("SELECT * FROM [dbo].[NHANSU]", sqlConn);
            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(7).Equals("Quan ly") && reader.GetString(0) == User)
                {
                    reader.Close();
                    sqlCommand.Dispose();
                    return true;
                }
            }
            reader.Close();
            sqlCommand.Dispose();
            return false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!CheckAccountManager())
            {
                buttonQuyDinh.Visible = false;
                buttonBaoCao.Visible = false;
                buttonQuanLyNhanSu.Visible = false;
            }
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }
    }
}