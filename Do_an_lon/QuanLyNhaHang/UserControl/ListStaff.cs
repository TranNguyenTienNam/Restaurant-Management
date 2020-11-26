using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class ListStaff : UserControl
    {
        public ListStaff()
        {
            InitializeComponent();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.ShowDialog();
            
        }

        private void ListStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
