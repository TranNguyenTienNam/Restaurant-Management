using QLNV.DAO;
using QLNV.DTO;
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
    public partial class fXoaDanhMucMon : Form
    {
        public fXoaDanhMucMon()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fXoaDanhMucMon_Load(object sender, EventArgs e)
        {
            List<FoodCategory> categories = FoodCategoryDAO.Instance.GetListFoodCategories();
            cmbXoa.DataSource = categories;
            cmbXoa.DisplayMember = "TENLOAI";

        


            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string tenloai = cmbXoa.GetItemText(cmbXoa.SelectedItem);
            try
            {

                if (FoodCategoryDAO.Instance.DeleteFoodCategory(tenloai))
                {
                    MessageBox.Show("Xoá danh mục thành công");
                }
                
            }
            catch
            {
                MessageBox.Show("Tồn tại tên thức ăn trong danh mục, không thể xoá");
            }
            
                
             fXoaDanhMucMon_Load(sender, e);
            
          
        }
    }
}
