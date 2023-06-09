
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmTraCuu
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
            this.components = new System.ComponentModel.Container();
            this.panelFill = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxSanBayDen = new System.Windows.Forms.ComboBox();
            this.sANBAYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYBANVECHUYENBAYDataSet6 = new QuanLyBanVeChuyenBay.QUANLYBANVECHUYENBAYDataSet6();
            this.comboBoxSanBayDi = new System.Windows.Forms.ComboBox();
            this.sANBAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYBANVECHUYENBAYDataSet5 = new QuanLyBanVeChuyenBay.QUANLYBANVECHUYENBAYDataSet5();
            this.panelShow = new System.Windows.Forms.Panel();
            this.pictureBoxNgayBay = new System.Windows.Forms.PictureBox();
            this.textBoxNgayBay = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelNgayGio = new System.Windows.Forms.Label();
            this.panelSanBayDen = new System.Windows.Forms.Panel();
            this.panelSanBayDi = new System.Windows.Forms.Panel();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sANBAYTableAdapter = new QuanLyBanVeChuyenBay.QUANLYBANVECHUYENBAYDataSet5TableAdapters.SANBAYTableAdapter();
            this.sANBAYTableAdapter1 = new QuanLyBanVeChuyenBay.QUANLYBANVECHUYENBAYDataSet6TableAdapters.SANBAYTableAdapter();
            this.panelFill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANBAYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANVECHUYENBAYDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANBAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANVECHUYENBAYDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNgayBay)).BeginInit();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.White;
            this.panelFill.Controls.Add(this.panel1);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFill.ForeColor = System.Drawing.Color.Black;
            this.panelFill.Location = new System.Drawing.Point(0, 0);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1182, 381);
            this.panelFill.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 379);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(612, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 379);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.planecenter;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxSanBayDen);
            this.panel2.Controls.Add(this.comboBoxSanBayDi);
            this.panel2.Controls.Add(this.panelShow);
            this.panel2.Controls.Add(this.pictureBoxNgayBay);
            this.panel2.Controls.Add(this.textBoxNgayBay);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.labelNgayGio);
            this.panel2.Controls.Add(this.panelSanBayDen);
            this.panel2.Controls.Add(this.panelSanBayDi);
            this.panel2.Controls.Add(this.buttonTimKiem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 379);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxSanBayDen
            // 
            this.comboBoxSanBayDen.DataSource = this.sANBAYBindingSource1;
            this.comboBoxSanBayDen.DisplayMember = "Tensb";
            this.comboBoxSanBayDen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxSanBayDen.FormattingEnabled = true;
            this.comboBoxSanBayDen.Location = new System.Drawing.Point(257, 130);
            this.comboBoxSanBayDen.Name = "comboBoxSanBayDen";
            this.comboBoxSanBayDen.Size = new System.Drawing.Size(260, 28);
            this.comboBoxSanBayDen.TabIndex = 135;
            this.comboBoxSanBayDen.ValueMember = "Tensb";
            // 
            // sANBAYBindingSource1
            // 
            this.sANBAYBindingSource1.DataMember = "SANBAY";
            this.sANBAYBindingSource1.DataSource = this.qUANLYBANVECHUYENBAYDataSet6;
            // 
            // qUANLYBANVECHUYENBAYDataSet6
            // 
            this.qUANLYBANVECHUYENBAYDataSet6.DataSetName = "QUANLYBANVECHUYENBAYDataSet6";
            this.qUANLYBANVECHUYENBAYDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSanBayDi
            // 
            this.comboBoxSanBayDi.DataSource = this.sANBAYBindingSource;
            this.comboBoxSanBayDi.DisplayMember = "Tensb";
            this.comboBoxSanBayDi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxSanBayDi.FormattingEnabled = true;
            this.comboBoxSanBayDi.Location = new System.Drawing.Point(257, 73);
            this.comboBoxSanBayDi.Name = "comboBoxSanBayDi";
            this.comboBoxSanBayDi.Size = new System.Drawing.Size(260, 28);
            this.comboBoxSanBayDi.TabIndex = 134;
            this.comboBoxSanBayDi.ValueMember = "Tensb";
            // 
            // sANBAYBindingSource
            // 
            this.sANBAYBindingSource.DataMember = "SANBAY";
            this.sANBAYBindingSource.DataSource = this.qUANLYBANVECHUYENBAYDataSet5;
            // 
            // qUANLYBANVECHUYENBAYDataSet5
            // 
            this.qUANLYBANVECHUYENBAYDataSet5.DataSetName = "QUANLYBANVECHUYENBAYDataSet5";
            this.qUANLYBANVECHUYENBAYDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelShow
            // 
            this.panelShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShow.Location = new System.Drawing.Point(34, 244);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(109, 95);
            this.panelShow.TabIndex = 133;
            this.panelShow.Visible = false;
            // 
            // pictureBoxNgayBay
            // 
            this.pictureBoxNgayBay.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.calendar_check_regular1;
            this.pictureBoxNgayBay.Location = new System.Drawing.Point(492, 195);
            this.pictureBoxNgayBay.Name = "pictureBoxNgayBay";
            this.pictureBoxNgayBay.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxNgayBay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNgayBay.TabIndex = 132;
            this.pictureBoxNgayBay.TabStop = false;
            this.pictureBoxNgayBay.Click += new System.EventHandler(this.pictureBoxNgayBay_Click);
            // 
            // textBoxNgayBay
            // 
            this.textBoxNgayBay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNgayBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayBay.Location = new System.Drawing.Point(257, 197);
            this.textBoxNgayBay.Multiline = true;
            this.textBoxNgayBay.Name = "textBoxNgayBay";
            this.textBoxNgayBay.Size = new System.Drawing.Size(235, 25);
            this.textBoxNgayBay.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(257, 222);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(260, 1);
            this.panel10.TabIndex = 0;
            // 
            // labelNgayGio
            // 
            this.labelNgayGio.AutoSize = true;
            this.labelNgayGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayGio.Location = new System.Drawing.Point(122, 198);
            this.labelNgayGio.Name = "labelNgayGio";
            this.labelNgayGio.Size = new System.Drawing.Size(92, 20);
            this.labelNgayGio.TabIndex = 0;
            this.labelNgayGio.Text = "Ngày bay:";
            // 
            // panelSanBayDen
            // 
            this.panelSanBayDen.BackColor = System.Drawing.Color.Black;
            this.panelSanBayDen.Location = new System.Drawing.Point(257, 164);
            this.panelSanBayDen.Name = "panelSanBayDen";
            this.panelSanBayDen.Size = new System.Drawing.Size(260, 1);
            this.panelSanBayDen.TabIndex = 0;
            // 
            // panelSanBayDi
            // 
            this.panelSanBayDi.BackColor = System.Drawing.Color.Black;
            this.panelSanBayDi.Location = new System.Drawing.Point(257, 103);
            this.panelSanBayDi.Name = "panelSanBayDi";
            this.panelSanBayDi.Size = new System.Drawing.Size(260, 1);
            this.panelSanBayDi.TabIndex = 0;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(367, 260);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(150, 40);
            this.buttonTimKiem.TabIndex = 4;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sân bay đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sân bay đi:";
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.dataGridView1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 381);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1182, 272);
            this.panelView.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sANBAYTableAdapter
            // 
            this.sANBAYTableAdapter.ClearBeforeFill = true;
            // 
            // sANBAYTableAdapter1
            // 
            this.sANBAYTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelFill);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmTraCuu";
            this.Text = "ĐẶT VÉ CHUYẾN BAY";
            this.Load += new System.EventHandler(this.FrmTraCuu_Load);
            this.panelFill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sANBAYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANVECHUYENBAYDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANBAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANVECHUYENBAYDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNgayBay)).EndInit();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNgayGio;
        private System.Windows.Forms.Panel panelSanBayDen;
        private System.Windows.Forms.Panel panelSanBayDi;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxNgayBay;
        private System.Windows.Forms.TextBox textBoxNgayBay;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.ComboBox comboBoxSanBayDen;
        private System.Windows.Forms.ComboBox comboBoxSanBayDi;
        private QUANLYBANVECHUYENBAYDataSet5 qUANLYBANVECHUYENBAYDataSet5;
        private System.Windows.Forms.BindingSource sANBAYBindingSource;
        private QUANLYBANVECHUYENBAYDataSet5TableAdapters.SANBAYTableAdapter sANBAYTableAdapter;
        private QUANLYBANVECHUYENBAYDataSet6 qUANLYBANVECHUYENBAYDataSet6;
        private System.Windows.Forms.BindingSource sANBAYBindingSource1;
        private QUANLYBANVECHUYENBAYDataSet6TableAdapters.SANBAYTableAdapter sANBAYTableAdapter1;
    }
}