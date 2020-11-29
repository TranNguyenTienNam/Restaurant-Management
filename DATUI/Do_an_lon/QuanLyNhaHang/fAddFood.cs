using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class fAddFood : Form
    {
        public fAddFood()
        {
            InitializeComponent();
        }

        private void buttonClosefAf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAddFood_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(txtFoodID.Text==""||txtFoodName.Text==""||
                txtPrice.Text==""||txtTypeID.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }    
           try
            {
                int mathucan = Convert.ToInt32(txtFoodID.Text);
                string tenthucan = txtFoodName.Text;
                int gia = Convert.ToInt32(txtPrice.Text);
                int maloai = Convert.ToInt32(txtTypeID.Text);
                if (FoodDAO.Instance.InsertFood(mathucan, tenthucan, gia, maloai) == true)
                {
                    MessageBox.Show("Thêm món ăn thành công");

                }
            }
            catch(SqlException ex)
            {
               switch(ex.Number)
                {
                    case 2627: //Mã lỗi này show ra vi phạm khoá chính
                        MessageBox.Show("Mã món ăn đã tồn tại hoặc tên món ăn bị trùng");
                        break;
                    case 547:
                        MessageBox.Show("Mã loại không tồn tại ");
                        break;
                    default:
                        throw;
                }    
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Lỗi định dạng");
            }
           
            
        }
    }
}
