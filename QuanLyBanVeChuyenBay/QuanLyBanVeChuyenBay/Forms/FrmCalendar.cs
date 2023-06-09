using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmCalendar : Form
    {
        public delegate void OnSelectDateTime(DateTime sender);
        public event OnSelectDateTime DateTimeHandler;

        public FrmCalendar()
        {
            InitializeComponent();
        }

        public FrmCalendar(DateTime sender)
        {
            InitializeComponent();
            monthCalendar1.SetDate(sender);
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            DateTimeHandler?.Invoke(monthCalendar1.SelectionRange.Start);
            this.Close();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
