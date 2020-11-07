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
    public partial class fSignUp : Form
    {
     
        public fSignUp()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Close();
            f.Show();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            string newusername = txtNewUser.Text;
            string newpass = txtNewPassWord.Text;
            string repass = txtRePass.Text;
            string tenhienthi = txtTenHienThi.Text;
            string gioitinh = txtGioiTinh.Text;
            DateTime ngaysinh = Convert.ToDateTime(txtNgaySinh.Text);
            string chucvu = txtChucVu.Text;

            if (newpass != repass)
            {
                MessageBox.Show("Mật khẩu không khớp !");
                txtTenHienThi.Focus();
            }
            else if (txtNewUser.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin  !");
                txtNewUser.Focus();
            }
            else if (txtNewPassWord.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin  !");
                txtNewPassWord.Focus();
            }
            else
            {
                AccountDAO.Instance.InsertAccout(newusername,newpass,tenhienthi,chucvu,gioitinh,ngaysinh);
                MessageBox.Show("thêm tài khoản thành công !");
                this.Close();
                fQuanly f = new fQuanly();
                f.ShowDialog();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
