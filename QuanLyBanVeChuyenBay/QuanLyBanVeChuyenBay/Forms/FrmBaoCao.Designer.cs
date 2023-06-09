
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDTT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBCT = new System.Windows.Forms.DataGridView();
            this.panelTitle1 = new System.Windows.Forms.Panel();
            this.tracuu = new System.Windows.Forms.Button();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDTN = new System.Windows.Forms.TextBox();
            this.dgvBCN = new System.Windows.Forms.DataGridView();
            this.panelTitle2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCT)).BeginInit();
            this.panelTitle1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCN)).BeginInit();
            this.panelTitle2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo doanh thu theo tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Báo cáo doanh thu theo năm";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbDTT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvBCT);
            this.panel1.Controls.Add(this.panelTitle1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 682);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1095, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "đồng";
            // 
            // tbDTT
            // 
            this.tbDTT.Location = new System.Drawing.Point(920, 318);
            this.tbDTT.Name = "tbDTT";
            this.tbDTT.Size = new System.Drawing.Size(169, 22);
            this.tbDTT.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(659, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "TỔNG DOANH THU THÁNG:";
            // 
            // dgvBCT
            // 
            this.dgvBCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCT.Location = new System.Drawing.Point(3, 41);
            this.dgvBCT.Name = "dgvBCT";
            this.dgvBCT.RowHeadersWidth = 51;
            this.dgvBCT.RowTemplate.Height = 24;
            this.dgvBCT.Size = new System.Drawing.Size(1241, 269);
            this.dgvBCT.TabIndex = 2;
            // 
            // panelTitle1
            // 
            this.panelTitle1.Controls.Add(this.tracuu);
            this.panelTitle1.Controls.Add(this.cbxNam);
            this.panelTitle1.Controls.Add(this.label4);
            this.panelTitle1.Controls.Add(this.cbxThang);
            this.panelTitle1.Controls.Add(this.label3);
            this.panelTitle1.Controls.Add(this.label1);
            this.panelTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle1.Location = new System.Drawing.Point(0, 0);
            this.panelTitle1.Name = "panelTitle1";
            this.panelTitle1.Size = new System.Drawing.Size(1247, 45);
            this.panelTitle1.TabIndex = 1;
            // 
            // tracuu
            // 
            this.tracuu.BackColor = System.Drawing.Color.LightGray;
            this.tracuu.Location = new System.Drawing.Point(1129, 7);
            this.tracuu.Name = "tracuu";
            this.tracuu.Size = new System.Drawing.Size(75, 31);
            this.tracuu.TabIndex = 5;
            this.tracuu.Text = "Tra cứu";
            this.tracuu.UseVisualStyleBackColor = false;
            this.tracuu.Click += new System.EventHandler(this.tracuu_Click);
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Items.AddRange(new object[] {
            "",
            "2022"});
            this.cbxNam.Location = new System.Drawing.Point(980, 11);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(121, 24);
            this.cbxNam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(930, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm";
            // 
            // cbxThang
            // 
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxThang.Location = new System.Drawing.Point(803, 11);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(121, 24);
            this.cbxThang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(742, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbDTN);
            this.panel2.Controls.Add(this.dgvBCN);
            this.panel2.Controls.Add(this.panelTitle2);
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 330);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(681, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "TỔNG DOANH THU NĂM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1095, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "đồng";
            // 
            // tbDTN
            // 
            this.tbDTN.Location = new System.Drawing.Point(920, 295);
            this.tbDTN.Name = "tbDTN";
            this.tbDTN.Size = new System.Drawing.Size(169, 22);
            this.tbDTN.TabIndex = 5;
            // 
            // dgvBCN
            // 
            this.dgvBCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCN.Location = new System.Drawing.Point(3, 38);
            this.dgvBCN.Name = "dgvBCN";
            this.dgvBCN.RowHeadersWidth = 51;
            this.dgvBCN.RowTemplate.Height = 24;
            this.dgvBCN.Size = new System.Drawing.Size(1241, 251);
            this.dgvBCN.TabIndex = 3;
            // 
            // panelTitle2
            // 
            this.panelTitle2.Controls.Add(this.label2);
            this.panelTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle2.Name = "panelTitle2";
            this.panelTitle2.Size = new System.Drawing.Size(1247, 45);
            this.panelTitle2.TabIndex = 2;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmBaoCao";
            this.Text = "BÁO CÁO DOANH THU";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCT)).EndInit();
            this.panelTitle1.ResumeLayout(false);
            this.panelTitle1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCN)).EndInit();
            this.panelTitle2.ResumeLayout(false);
            this.panelTitle2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitle1;
        private System.Windows.Forms.Panel panelTitle2;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDTT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDTN;
        private System.Windows.Forms.DataGridView dgvBCN;
        private System.Windows.Forms.Button tracuu;
    }
}