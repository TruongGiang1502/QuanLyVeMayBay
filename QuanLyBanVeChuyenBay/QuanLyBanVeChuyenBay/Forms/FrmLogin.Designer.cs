
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.linkLabelForgotPass = new System.Windows.Forms.LinkLabel();
            this.labelWarning = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(131, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(30, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(30, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 1);
            this.panel2.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(30, 572);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(340, 45);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.White;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.textBoxUserName.ForeColor = System.Drawing.Color.Black;
            this.textBoxUserName.Location = new System.Drawing.Point(90, 239);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(280, 35);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserName_KeyDown);
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.BackColor = System.Drawing.Color.White;
            this.textBoxPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassWord.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15F);
            this.textBoxPassWord.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassWord.Location = new System.Drawing.Point(90, 319);
            this.textBoxPassWord.Multiline = true;
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.PasswordChar = '*';
            this.textBoxPassWord.Size = new System.Drawing.Size(280, 35);
            this.textBoxPassWord.TabIndex = 2;
            this.textBoxPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassWord_KeyDown);
            // 
            // linkLabelForgotPass
            // 
            this.linkLabelForgotPass.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelForgotPass.AutoSize = true;
            this.linkLabelForgotPass.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.linkLabelForgotPass.Location = new System.Drawing.Point(222, 369);
            this.linkLabelForgotPass.Name = "linkLabelForgotPass";
            this.linkLabelForgotPass.Size = new System.Drawing.Size(148, 24);
            this.linkLabelForgotPass.TabIndex = 6;
            this.linkLabelForgotPass.TabStop = true;
            this.linkLabelForgotPass.Text = "Forgot Password?";
            // 
            // labelWarning
            // 
            this.labelWarning.BackColor = System.Drawing.Color.White;
            this.labelWarning.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold);
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(0, 412);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(400, 138);
            this.labelWarning.TabIndex = 8;
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Icon_Pass;
            this.pictureBox3.Location = new System.Drawing.Point(30, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.Icon_Name1;
            this.pictureBox2.Location = new System.Drawing.Point(30, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.LogoApp;
            this.pictureBox1.Location = new System.Drawing.Point(100, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 630);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.linkLabelForgotPass);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán vé chuyến bay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.LinkLabel linkLabelForgotPass;
        private System.Windows.Forms.Label labelWarning;
    }
}