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
        fLogin parent3;
        public fSignUp(fLogin parent3)
        {
            this.parent3 = parent3;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Close();
            f.Show();
        }
        void InsertAccout(string newuser, string newpass)
        {
            AccountDAO.Instance.InsertAccout(newuser, newpass);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string newusername = txtNewUser.Text;
            string newpass = txtNewPassWord.Text;
            string repass = txtRePass.Text;
            if (newpass != repass)
            {
                MessageBox.Show("Mật khẩu không khớp !");
                txtRePass.Focus();
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
                AccountDAO.Instance.InsertAccout(newusername,newpass);
                MessageBox.Show("thêm tài khoản thành công !");
                this.Close();
                fQuanly f = new fQuanly(parent3);
                f.Show();   
            }
        }
    }
}
