﻿using System;
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
            LoadComboboxTenBan();
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
            dtgvFoodbyId.DataSource = MenuDAO.Instance.LoadBillByIdTable(MABAN);
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
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán");
            }
            else
            {
                int mahoadon = BillDAO.Instance.GetIdBillByCheckStatusTable(table.Maban);
                if (mahoadon == -1)
                {
                    MessageBox.Show("Bàn này không có món ăn");
                }
                if (mahoadon != -1)
                {

                        this.Hide();
                        fInvoice f = new fInvoice(table.Maban);
                    f.Show();
                         LoadTable();
                       LoadBill(table.Maban);
                        this.Show();
                       // if (MessageBox.Show("Bạn muốn thanh toán hoá đơn cho "
                       // + table.Tenban, "Thông báo", MessageBoxButtons.YesNo)
                       // == System.Windows.Forms.DialogResult.Yes)
                       // BillDAO.Instance.Checkout(mahoadon);
                       // LoadBill(table.Maban);
                       // TableDAO.Instance.ResetStatusById(table.Maban);
                       // MessageBox.Show("Thanh toán thành công");
                       // LoadTable();
                    
                }
            }
                
            /**
             * 
          
                
                
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
                
            
          

           
            
             * 
             * 
             * 
             */
        }

        private void dtgvFoodbyId_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            
            fOrder f = new fOrder();
            f.ShowDialog();
            LoadTable();
            this.Show();

        }

        void LoadComboboxTenBan()
        {
            cbbSwichTable.DataSource = TableDAO.Instance.GetListTable();
            cbbSwichTable.DisplayMember = "TENBAN";
            cbbMergeTable.DataSource = TableDAO.Instance.GetListTable();
            cbbMergeTable.DisplayMember = "TENBAN";
        }



        private void dtgvFoodbyId_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvFoodbyId_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        private void btn_SwitchTable(object sender, EventArgs e)
        {
            Table table1 = dtgvFoodbyId.Tag as Table;
            Table table2 = (cbbSwichTable.SelectedItem as Table);
            if (table1.Trangthai == "Trống")
            {
                MessageBox.Show("Bàn này hiện tai đang trống");
            }
            else if (table1.Maban!=table2.Maban)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn chuyển từ bàn " +
                table1.Maban + " sang bàn " +
                table2.Maban
                , "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TableDAO.Instance.SwitchTable(table1.Maban, table2.Maban);
                }
                LoadTable();
            }  
            
            else
            {
                MessageBox.Show("Bạn đang ở bàn hiện tại");
                return;
            }    
           

        }

        private void btnMergeTable_Click(object sender, EventArgs e)
        {
           
            Table table1 = dtgvFoodbyId.Tag as Table;
            Table table2 = cbbMergeTable.SelectedItem as Table;
         
            if(table1.Trangthai=="Trống")
            {
                MessageBox.Show(table1.Tenban+" đang trống, không thể gộp");
               
            }    
           
            else if(table1.Maban==table2.Maban)
            {
                MessageBox.Show("Bạn đang ở bàn hiện tại");
            }    
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn gộp từ bàn " +
               table1.Maban + " sang bàn " +
               table2.Maban
               , "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TableDAO.Instance.MergeTable(table1.Maban, table2.Maban);
                    LoadTable();
                }
               
            }
           
        }
    }
        
}
