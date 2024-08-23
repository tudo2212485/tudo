using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Giới Tính Nam.", "Thông Báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Chọn Giới Tính Nữ. ", "Thông Báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rddo.Checked)
                txtHopMau.BackColor = Color.Red;
            if (rdxanh.Checked)
                txtHopMau.BackColor = Color.Blue;

        }
    }
}
