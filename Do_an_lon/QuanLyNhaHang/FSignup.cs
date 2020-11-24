using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class FSignup : Form
    {
        public FSignup()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new fLogin().Show();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Close();
            fHome f = new fHome();
            f.Show();
        }
    }
}
