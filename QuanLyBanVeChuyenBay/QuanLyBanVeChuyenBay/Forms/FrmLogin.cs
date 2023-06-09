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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBoxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool EmptyTextBoxes()
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text) || string.IsNullOrEmpty(textBoxPassWord.Text))
            {
                return true;
            }
            return false;
        }

        public string tempt;

        private void Login()
        {
            if (this.EmptyTextBoxes())
            {
                if (EmptyTextBoxes())
                {
                    MessageBox.Show("Something is missing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (!CorrectPassword())
                {
                    MessageBox.Show("User name or Password is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var frm = new FormMain();
                frm.FormClosing += delegate { this.Show(); };
                this.ResetTexts();
                this.Hide();
                frm.SetData(tempt);
                frm.Show();
            }
            
  
        }

        private bool CorrectPassword()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            //@"Data Source=NBIN17\NBIN17;Initial Catalog=QUANLYBANVECHUYENBAY;Persist Security Info=True;User=sa;Password=12345"
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            var sqlCommand = new SqlCommand("SELECT * FROM [dbo].[NHANSU]", sqlConn);
            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                if (textBoxUserName.Text == reader.GetString(0) | textBoxPassWord.Text == reader.GetString(1))
                {
                    tempt = textBoxUserName.Text;
                    reader.Close();
                    sqlCommand.Dispose();
                    return true;
                }
            }
            reader.Close();
            sqlCommand.Dispose();
            return false;
        }

        private void ResetTexts()
        {
            textBoxUserName.Text = "";
            textBoxPassWord.Text = "";
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
