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
    public partial class fCapNhatDanhmucMon : Form
    {
        public fCapNhatDanhmucMon()
        {
            InitializeComponent();
            LoadDanhMuc();
        }
        void LoadDanhMuc()
        {
            
           List < DTO.FoodCategory> categories= 
                  FoodCategoryDAO.Instance.GetListFoodCategories();
            cmbTenLoai.DataSource = categories;
            cmbTenLoai.DisplayMember = "TenLoai";
            

        }
        private void txtTenMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            

            string tencu = this.cmbTenLoai.GetItemText(cmbTenLoai.SelectedItem);
            string tenmoi = txtTenMoi.Text;
            try
            {
                if (FoodCategoryDAO.Instance.UpdateFoodCateGory(tenmoi, tencu) == true)
                {
                    MessageBox.Show("Cập nhật danh mục thành công");
                    LoadDanhMuc();

                }
            }
             
             catch
            {
                MessageBox.Show("Tên danh mục đã tồn tại");
            }    



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
