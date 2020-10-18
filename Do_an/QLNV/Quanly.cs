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
    public partial class fQuanly : Form
    {
        fLogin parent1;
        fSignUp parent2;
        public fQuanly(fLogin parent1)
        {
            this.parent1 = parent1;
            InitializeComponent();
           
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

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
            //AddPersonBinding();
        }
       /*void AddPersonBinding()
        {
            txtNameInfor.DataBindings.Add(new Binding("Text", dtgvPerson.DataSource, "HOTEN",true,DataSourceUpdateMode.Never));
            txtId.DataBindings.Add(new Binding("Text", dtgvPerson.DataSource, "MANV" ,true, DataSourceUpdateMode.Never));
            txtdate.DataBindings.Add(new Binding("Text", dtgvPerson.DataSource, "NGSINH", true, DataSourceUpdateMode.Never));
            txtSex.DataBindings.Add(new Binding("Text", dtgvPerson.DataSource, "GIOITINH", true, DataSourceUpdateMode.Never));
            txtPosition.DataBindings.Add(new Binding("Text", dtgvPerson.DataSource, "CHUCVU", true, DataSourceUpdateMode.Never));

        }*/
        private void dtgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dtgvPerson.Rows[e.RowIndex];
                txtId.Text = row.Cells[1].Value.ToString();
                txtNameInfor.Text = row.Cells[2].Value.ToString();
                txtSex.Text = row.Cells[3].Value.ToString();
                txtdate.Text = row.Cells[4].Value.ToString();
                txtPosition.Text = row.Cells[5].Value.ToString();
            }    
        }

        private void tabPage5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        void InsertPerson(string id, string name, string ngsinh, string gioitinh, string chucvu)
        {
            PersonDAO.Instance.InsertPerson(id, name, ngsinh, gioitinh, chucvu);
        }
        void UpdatePerson(string id, string name, string chucvu,string gioitinh,string ngsinh)
        {
            PersonDAO.Instance.UpdatePerson(id, name, chucvu,gioitinh,ngsinh);
        }
        void DeletePerson(string id)
        {
            PersonDAO.Instance.DeletePerson(id);
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }


        private void fQuanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            fLogin f = new fLogin();
            f.Show();
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            InsertPerson(txtId.Text, txtNameInfor.Text, txtdate.Text, txtSex.Text, txtPosition.Text);
            MessageBox.Show("thêm nhân viên thành công !");
            PersonDAO.Instance.LoadPerson();
        }

        private void buttonFixPerson_Click(object sender, EventArgs e)
        {
            UpdatePerson(txtId.Text, txtNameInfor.Text, txtPosition.Text, txtSex.Text, txtdate.Text);
            MessageBox.Show("sửa thành công !");
            PersonDAO.Instance.LoadPerson();
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(txtId.Text);
            DeletePerson(id);
            MessageBox.Show("xóa thành công !");
            PersonDAO.Instance.LoadPerson();
        }

        private void buttonLoadPerson_Click_1(object sender, EventArgs e)
        {
            LoadPerson();
        }
    }
}
