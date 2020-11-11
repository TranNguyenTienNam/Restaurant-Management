using QLNV.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class fThemDanhmucMon : Form
    {
        public fThemDanhmucMon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenloai = txtTenloai.Text;
            try
            {
                if (FoodCategoryDAO.Instance.InsertFoodCateGory(tenloai) == true)
                {
                    MessageBox.Show("Thêm thành công ");
                }
            }
           
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
