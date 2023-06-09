
namespace QuanLyBanVeChuyenBay
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonQuanLyNhanSu = new System.Windows.Forms.Button();
            this.buttonBaoCao = new System.Windows.Forms.Button();
            this.buttonQuyDinh = new System.Windows.Forms.Button();
            this.buttonDatVeChuyenBay = new System.Windows.Forms.Button();
            this.buttonLichChuyenBay = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.buttonQuanLyNhanSu);
            this.panelMenu.Controls.Add(this.buttonBaoCao);
            this.panelMenu.Controls.Add(this.buttonQuyDinh);
            this.panelMenu.Controls.Add(this.buttonDatVeChuyenBay);
            this.panelMenu.Controls.Add(this.buttonLichChuyenBay);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(325, 853);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(325, 130);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.panelTitle.Controls.Add(this.buttonMin);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.buttonMax);
            this.panelTitle.Controls.Add(this.buttonClose);
            this.panelTitle.Controls.Add(this.buttonCloseChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(325, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1257, 100);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Location = new System.Drawing.Point(1147, 3);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(35, 35);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.Text = "O";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(100, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1035, 100);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ BÁN VÉ MÁY BAY";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMax.ForeColor = System.Drawing.Color.White;
            this.buttonMax.Location = new System.Drawing.Point(1183, 3);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(35, 35);
            this.buttonMax.TabIndex = 3;
            this.buttonMax.Text = "O";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1219, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 35);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "O";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCloseChildForm
            // 
            this.buttonCloseChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.buttonCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.buttonCloseChildForm.MaximumSize = new System.Drawing.Size(112, 100);
            this.buttonCloseChildForm.MinimumSize = new System.Drawing.Size(112, 100);
            this.buttonCloseChildForm.Name = "buttonCloseChildForm";
            this.buttonCloseChildForm.Size = new System.Drawing.Size(112, 100);
            this.buttonCloseChildForm.TabIndex = 1;
            this.buttonCloseChildForm.Text = "X";
            this.buttonCloseChildForm.UseVisualStyleBackColor = false;
            this.buttonCloseChildForm.Click += new System.EventHandler(this.buttonCloseChildForm_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(325, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1257, 753);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.planeAPP;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1257, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(12, 791);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buttonQuanLyNhanSu
            // 
            this.buttonQuanLyNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuanLyNhanSu.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyNhanSu.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonQuanLyNhanSu.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.icons8_admin_settings_male_401;
            this.buttonQuanLyNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLyNhanSu.Location = new System.Drawing.Point(0, 390);
            this.buttonQuanLyNhanSu.Name = "buttonQuanLyNhanSu";
            this.buttonQuanLyNhanSu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonQuanLyNhanSu.Size = new System.Drawing.Size(325, 65);
            this.buttonQuanLyNhanSu.TabIndex = 8;
            this.buttonQuanLyNhanSu.Text = "  Quản lý nhân sự";
            this.buttonQuanLyNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLyNhanSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuanLyNhanSu.UseVisualStyleBackColor = true;
            this.buttonQuanLyNhanSu.Click += new System.EventHandler(this.buttonQuanLyNhanSu_Click);
            // 
            // buttonBaoCao
            // 
            this.buttonBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBaoCao.FlatAppearance.BorderSize = 0;
            this.buttonBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaoCao.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBaoCao.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.icons8_profit_report_40;
            this.buttonBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBaoCao.Location = new System.Drawing.Point(0, 325);
            this.buttonBaoCao.Name = "buttonBaoCao";
            this.buttonBaoCao.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonBaoCao.Size = new System.Drawing.Size(325, 65);
            this.buttonBaoCao.TabIndex = 6;
            this.buttonBaoCao.Text = "  Báo cáo doanh thu";
            this.buttonBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBaoCao.UseVisualStyleBackColor = true;
            this.buttonBaoCao.Click += new System.EventHandler(this.buttonBaoCao_Click);
            // 
            // buttonQuyDinh
            // 
            this.buttonQuyDinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuyDinh.FlatAppearance.BorderSize = 0;
            this.buttonQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuyDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuyDinh.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonQuyDinh.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.icons8_gear_35;
            this.buttonQuyDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuyDinh.Location = new System.Drawing.Point(0, 260);
            this.buttonQuyDinh.Name = "buttonQuyDinh";
            this.buttonQuyDinh.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonQuyDinh.Size = new System.Drawing.Size(325, 65);
            this.buttonQuyDinh.TabIndex = 5;
            this.buttonQuyDinh.Text = "  Quy định chuyến bay";
            this.buttonQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuyDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuyDinh.UseVisualStyleBackColor = true;
            this.buttonQuyDinh.Click += new System.EventHandler(this.buttonQuyDinh_Click);
            // 
            // buttonDatVeChuyenBay
            // 
            this.buttonDatVeChuyenBay.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDatVeChuyenBay.FlatAppearance.BorderSize = 0;
            this.buttonDatVeChuyenBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatVeChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDatVeChuyenBay.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDatVeChuyenBay.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.icons8_airport_35;
            this.buttonDatVeChuyenBay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDatVeChuyenBay.Location = new System.Drawing.Point(0, 195);
            this.buttonDatVeChuyenBay.Name = "buttonDatVeChuyenBay";
            this.buttonDatVeChuyenBay.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonDatVeChuyenBay.Size = new System.Drawing.Size(325, 65);
            this.buttonDatVeChuyenBay.TabIndex = 3;
            this.buttonDatVeChuyenBay.Text = "  Đặt vé chuyến bay";
            this.buttonDatVeChuyenBay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDatVeChuyenBay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDatVeChuyenBay.UseVisualStyleBackColor = true;
            this.buttonDatVeChuyenBay.Click += new System.EventHandler(this.buttonDatVeChuyenBay_Click);
            // 
            // buttonLichChuyenBay
            // 
            this.buttonLichChuyenBay.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLichChuyenBay.FlatAppearance.BorderSize = 0;
            this.buttonLichChuyenBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLichChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLichChuyenBay.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLichChuyenBay.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.icons8_add_property_35;
            this.buttonLichChuyenBay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLichChuyenBay.Location = new System.Drawing.Point(0, 130);
            this.buttonLichChuyenBay.Name = "buttonLichChuyenBay";
            this.buttonLichChuyenBay.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonLichChuyenBay.Size = new System.Drawing.Size(325, 65);
            this.buttonLichChuyenBay.TabIndex = 2;
            this.buttonLichChuyenBay.Text = "  Nhận lịch chuyến bay";
            this.buttonLichChuyenBay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLichChuyenBay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLichChuyenBay.UseVisualStyleBackColor = true;
            this.buttonLichChuyenBay.Click += new System.EventHandler(this.buttonLichChuyenBay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(68)))), ((int)(((byte)(86)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.LogoApp;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonQuyDinh;
        private System.Windows.Forms.Button buttonDatVeChuyenBay;
        private System.Windows.Forms.Button buttonLichChuyenBay;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBaoCao;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonQuanLyNhanSu;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

