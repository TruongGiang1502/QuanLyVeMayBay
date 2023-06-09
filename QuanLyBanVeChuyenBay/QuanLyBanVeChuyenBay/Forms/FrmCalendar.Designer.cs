
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // buttonChon
            // 
            this.buttonChon.BackColor = System.Drawing.Color.White;
            this.buttonChon.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChon.ForeColor = System.Drawing.Color.Black;
            this.buttonChon.Location = new System.Drawing.Point(0, 0);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(152, 34);
            this.buttonChon.TabIndex = 1;
            this.buttonChon.Text = "Chọn";
            this.buttonChon.UseVisualStyleBackColor = false;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.White;
            this.buttonHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.Black;
            this.buttonHuy.Location = new System.Drawing.Point(152, 0);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(152, 34);
            this.buttonHuy.TabIndex = 2;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.buttonChon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 34);
            this.panel1.TabIndex = 3;
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 233);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalendar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Panel panel1;
    }
}