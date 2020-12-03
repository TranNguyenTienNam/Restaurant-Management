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
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new fLogin().Show();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string newusername = txtUsername.Text;
            string newpass = txtPassword.Text;
            string repass = txtRePassword.Text;

            if (newpass != repass)
            {
                MessageBox.Show("Mật khẩu không khớp !");
               
            }
         
            else if (newpass == ""||newusername==""||repass=="")
            {
                MessageBox.Show("Không được để trống thông tin  !");
                
            }
            else
            {
                try
                {
                    AccountDAO.Instance.InsertAccout(newusername, newpass);
                    MessageBox.Show("thêm tài khoản thành công !");
                    this.Close();
                    fHome f = new fHome();
                    f.ShowDialog();
                    this.Show();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Đăng ký không thành công");
                }
               
            }
        }
    }
}
