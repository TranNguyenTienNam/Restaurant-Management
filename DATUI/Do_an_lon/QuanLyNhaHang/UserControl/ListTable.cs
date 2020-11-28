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
    public partial class ListTable : UserControl
    {
        public ListTable()
        {
            InitializeComponent();
            LoadTable();
        }

        void LoadTable()
        {
            this.flowLayoutPanel1.Controls.Clear();
            List<Table> tabeList = TableDAO.Instance.GetListTable();
            foreach (Table table in tabeList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = table.Tenban + "\n" + table.Trangthai;
                btn.Tag = table;

                btn.Click += btn_Click;
                this.flowLayoutPanel1.Controls.Add(btn);

                if (table.Trangthai == "Trống")
                    btn.BackColor = Color.Lavender;
                else
                {
                    btn.BackColor = Color.Red;
                }

            }
        }
        private void btn_Click(object sender, EventArgs e)
        {

            int MABAN = ((Table)(sender as Button).Tag).Maban;
            dtgvFoodbyId.Tag = (sender as Button).Tag;
            LoadBill(MABAN);

        }

        void LoadBill(int MABAN)
        {

            List<Menu> menus = MenuDAO.Instance.GetListMenusById(MABAN);
            dtgvFoodbyId.DataSource = menus;
            dtgvFoodbyId.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int tongtien = 0;
            foreach (var i in menus)
            {
                tongtien += i.Thanhtien;
            }
            txtTongTien.Text = tongtien.ToString();

        }


        private void dtgvFoodbyId_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPayMonney_Click(object sender, EventArgs e)
        {
            
          
                Table table = (dtgvFoodbyId.Tag as Table);
                if(table==null)
                {
                    MessageBox.Show("Vui lòng chọn bàn để thanh toán");
                }
                
                if (table != null)
                {
                    if(BillDAO.Instance.IsExistBill(table.Maban)==false)
                    {
                       MessageBox.Show("Bàn này chưa lưu hoá đơn, không thể thanh toán");
                        return;
                    }    
                    int mahoadon = BillDAO.Instance.GetIdBillByCheckStatusTable(table.Maban);
                    if(mahoadon==-1)
                    {
                        MessageBox.Show("Bàn này không có món ăn");
                    }    
                    if (mahoadon != -1)
                    {
                        if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn "
                            + table.Tenban, "Thông báo", MessageBoxButtons.OKCancel)
                            == System.Windows.Forms.DialogResult.OK)
                        {
                            BillDAO.Instance.Checkout(mahoadon);
                            LoadBill(table.Maban);
                            TableDAO.Instance.ResetStatusById(table.Maban);
                           MessageBox.Show("Thanh toán thành công");
                            LoadTable();
                        }
                    }
                }    
                
            
          

           
            
        }

        private void dtgvFoodbyId_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            fOrder f = new fOrder();
            f.ShowDialog();
            LoadTable();
            this.Show();

        }

        private void dtgvFoodbyId_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        
}
