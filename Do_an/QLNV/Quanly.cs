using QLNV.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class fQuanly : Form
    {
        
        public fQuanly()
        {
            
            InitializeComponent();
            LoadTable();
           
        }

       

     

        private void Quanly_Load(object sender, EventArgs e)
        {
            LoadPerson();
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        void LoadPerson()
        {
            dtgvPerson.DataSource = PersonDAO.Instance.LoadPerson();
            dtgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
      

     
        void InsertPerson(string name, DateTime ngsinh, string gioitinh, string chucvu)
        {
            PersonDAO.Instance.InsertPerson( name, ngsinh, gioitinh, chucvu);
        }

        void UpdatePerson(string id, string name, string chucvu,string gioitinh,string ngsinh)
        {
            PersonDAO.Instance.UpdatePerson(id, name, chucvu,gioitinh,ngsinh);
        }
        void DeletePerson(int id)
        {
            PersonDAO.Instance.DeletePerson(id);
        }


       
        private void fQuanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            fLogin f = new fLogin();
            f.Show();
        }

      

        private void buttonFixPerson_Click(object sender, EventArgs e)
        {
            UpdatePerson(txtId.Text, txtNameInfor.Text, txtPosition.Text, txtSex.Text, txtdate.Text);
            MessageBox.Show("sửa thành công !");
            PersonDAO.Instance.LoadPerson();
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            DeletePerson(id);
            MessageBox.Show("xóa thành công !");
            PersonDAO.Instance.LoadPerson();
        }


      

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void Addbutton_Click(object sender, EventArgs e)
        {
            
                InsertPerson(txtNameInfor.Text, DateTime.Parse(txtdate.Text), txtSex.Text, txtPosition.Text);
                MessageBox.Show("thêm nhân viên thành công !");
                PersonDAO.Instance.LoadPerson();
                Quanly_Load(sender, e);
                   
        }

        private void btnLoadPerSon_Click(object sender, EventArgs e)
        {
            LoadPerson();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
       
  
           void LoadTable()
            {
                List<Table> tabeList = TableDAO.Instance.GetListTable();
                foreach (Table table in tabeList)
                {
                    Button btn = new Button() { Width = 100, Height = 100 };
                    btn.Text = table.Tenban+ "\n" + table.Trangthai;
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
            List<DTO.Menu> menus = MenuDAO.Instance.GetListMenus(MABAN);
            dataGridView1.DataSource = menus;
            int tongtien = 0;
            foreach(var i in menus)
            {
                tongtien +=i.Thanhtien;
            }
            txtTongtien.Text = tongtien.ToString();
            
            
        }
        private void dtgvfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectMonan.SelectedIndex == 0)
            {
                this.dtgvfood.DataSource=FoodCategoryDAO.Instance.LoadFoodCategory(); 
            }
            else
            {
                this.dtgvfood.DataSource=FoodDAO.Instance.LoadFood();
            }
              
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cmbSelectMonan.SelectedIndex==0)
            {
                this.Hide();
                fThemDanhmucMon f = new fThemDanhmucMon();
                f.ShowDialog();
                this.dtgvfood.DataSource = FoodCategoryDAO.Instance.LoadFoodCategory();
                this.Show();
            }
            if(cmbSelectMonan.SelectedIndex==1)
            {
                this.Hide();
                fThemMon f = new fThemMon();
                f.ShowDialog();
                this.dtgvfood.DataSource = FoodDAO.Instance.LoadFood();
                this.Show();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(cmbSelectMonan.SelectedIndex==0)
            {
                this.Hide();
                fCapNhatDanhmucMon f = new fCapNhatDanhmucMon();
                f.ShowDialog();
                this.dtgvfood.DataSource = FoodCategoryDAO.Instance.LoadFoodCategory();
                this.Show();
            }
            else
            {
                this.Hide();
                fCapNhatMon f = new fCapNhatMon();
                f.ShowDialog();
                this.dtgvfood.DataSource = FoodDAO.Instance.LoadFood();
                this.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(cmbSelectMonan.SelectedIndex==0)
            {
                this.Hide();
                fXoaDanhMucMon f = new fXoaDanhMucMon();
                f.ShowDialog();
                this.dtgvfood.DataSource = FoodCategoryDAO.Instance.LoadFoodCategory();
                this.Show();
            }
            else
            {
                this.Hide();
                fXoaMon f = new fXoaMon();
                f.ShowDialog();
                this.dtgvfood.DataSource = FoodDAO.Instance.LoadFood();
                this.Show();
            }    
        }
    }
}
