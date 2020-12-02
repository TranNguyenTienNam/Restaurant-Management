using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;
using Bunifu;
using BunifuAnimatorNS;

namespace QuanLyNhaHang
{
    public partial class ListFood : UserControl
    {
        public ListFood()
        {
            InitializeComponent();
            
            
        }

       
        private void ListFood_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSelect.SelectedIndex == 0)
            {
                this.dtgvFood.DataSource = FoodCategoryDAO.Instance.LoadFoodCategory();
                dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                txtTypeID.ReadOnly = true;
                txtFoodID.ReadOnly = true;
                txtFoodName.ReadOnly = true;
                txtPrice.ReadOnly = true;
                txtTypeName.ReadOnly = true;
            }
            else
            {
                this.dtgvFood.DataSource = FoodDAO.Instance.LoadFood();
                dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                txtTypeID.ReadOnly = false;
                txtFoodID.ReadOnly = false;
                txtFoodName.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtTypeName.ReadOnly = false;
                
               
            }
        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood();
            f.ShowDialog();
            this.dtgvFood.DataSource = FoodDAO.Instance.LoadFood();
        }

       

        private void dtgvFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if(cbbSelect.SelectedIndex==1&&e.RowIndex>=0)
            {
                DataGridViewRow row = dtgvFood.Rows[e.RowIndex];
                txtFoodID.Text = row.Cells["MATHUCAN"].Value.ToString();
                txtFoodName.Text = row.Cells["TENTHUCAN"].Value.ToString();
                txtPrice.Text = row.Cells["GIA"].Value.ToString();
                txtTypeID.Text = row.Cells["MALOAI"].Value.ToString();
                txtTypeName.Text = row.Cells["TENLOAI"].Value.ToString();
            }



            
            
        }

        private void buttonUpdateFood_Click(object sender, EventArgs e)
        {
            if (txtFoodID.Text == "" || txtFoodName.Text == "" ||
                txtPrice.Text == "" || txtTypeID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
               try
                {
                    int mathucan = Convert.ToInt32(txtFoodID.Text);
                    string tenthucan = txtFoodName.Text;
                    int gia = Convert.ToInt32(txtPrice.Text);
                    int maloai = Convert.ToInt32(txtTypeID.Text);
                    if (FoodDAO.Instance.UpdateFood(mathucan, tenthucan, gia, maloai) == true)
                    {
                        MessageBox.Show("Cập nhật món ăn thành công");
                        dtgvFood.DataSource = FoodDAO.Instance.LoadFood();
                    }
                    else
                    {
                        MessageBox.Show("Mã món ăn không tồn tại");
                    }
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Một số thông tin không hợp lệ");
                }
            }    
           

        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            if(txtFoodID.Text=="")
            {
                MessageBox.Show("Không được để trống thông tin");
            }    
           else
            {
                int mathucan = Convert.ToInt32(txtFoodID.Text);
                if (FoodDAO.Instance.DeleteFood(mathucan) == true)
                {
                    MessageBox.Show("Xoá món ăn thành công");
                    dtgvFood.DataSource = FoodDAO.Instance.LoadFood();
                }
            }    
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tenthucan = txtSearch.Text;
            DataTable data = FoodDAO.Instance.SearchFoodByName(tenthucan);
            if(data.Rows.Count==0)
            {
                MessageBox.Show("Không có món ăn cần tìm kiếm");
            }    
            else
            {
                txtFoodID.Text = ((int)data.Rows[0]["MATHUCAN"]).ToString();
                txtFoodName.Text = (string)data.Rows[0]["TENTHUCAN"];
                txtPrice.Text = ((int)data.Rows[0]["GIA"]).ToString();
                txtTypeID.Text = ((int)data.Rows[0]["MALOAI"]).ToString();



            }    
        }

        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
