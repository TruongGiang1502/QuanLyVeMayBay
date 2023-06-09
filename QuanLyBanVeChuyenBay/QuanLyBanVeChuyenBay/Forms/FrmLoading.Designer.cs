
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBarLoad = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(117, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading...";
            // 
            // ProgressBarLoad
            // 
            this.ProgressBarLoad.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("ProgressBarLoad.AnimationFunction")));
            this.ProgressBarLoad.AnimationSpeed = 500;
            this.ProgressBarLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ProgressBarLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.ProgressBarLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProgressBarLoad.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ProgressBarLoad.InnerMargin = 2;
            this.ProgressBarLoad.InnerWidth = -1;
            this.ProgressBarLoad.Location = new System.Drawing.Point(72, 156);
            this.ProgressBarLoad.MarqueeAnimationSpeed = 2000;
            this.ProgressBarLoad.Name = "ProgressBarLoad";
            this.ProgressBarLoad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.ProgressBarLoad.OuterMargin = -25;
            this.ProgressBarLoad.OuterWidth = 26;
            this.ProgressBarLoad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProgressBarLoad.ProgressWidth = 6;
            this.ProgressBarLoad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgressBarLoad.Size = new System.Drawing.Size(206, 206);
            this.ProgressBarLoad.StartAngle = 270;
            this.ProgressBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarLoad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBarLoad.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBarLoad.SubscriptText = "";
            this.ProgressBarLoad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBarLoad.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBarLoad.SuperscriptText = "";
            this.ProgressBarLoad.TabIndex = 4;
            this.ProgressBarLoad.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBarLoad.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.label3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(115, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(66, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book flight ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.LogoApp;
            this.pictureBox1.Location = new System.Drawing.Point(100, 437);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(350, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProgressBarLoad);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar ProgressBarLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}