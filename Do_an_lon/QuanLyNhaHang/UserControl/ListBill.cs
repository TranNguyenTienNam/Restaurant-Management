using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QuanLyNhaHang
{
    public partial class ListBill : UserControl
    {
        public ListBill()
        {
            InitializeComponent();
            LoadComboboxTenBan();
        }
        void LoadComboboxTenBan()
        {
            List<Table> tables = TableDAO.Instance.GetListTable();

            cbbTableName.DataSource = tables;
            cbbTableName.DisplayMember = "Tenban";
        }
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int TongTien(int MABAN)
        {

            List<Menu> menus = MenuDAO.Instance.GetListMenusById(MABAN);
            
           
            int tongtien = 0;
            foreach (var i in menus)
            {
                tongtien += i.Thanhtien;
            }
            return tongtien;
           

        }
        private void cbbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Table table = cb.SelectedItem as Table;
            int maban = table.Maban;
            dtgvBill.DataSource = MenuDAO.Instance.LoadBillByIdTable(maban);
            DataRow row = BillDAO.Instance.GetInforBillByIdTable(maban);
           if(row!=null)
            {
                txtIdBill.Text = ((int)row["MAHOADON"]).ToString();
                txtIdTable.Text = ((int)row["MABAN"]).ToString();
                DateTime now = DateTime.Now;
                txtDate.Text = now.ToString();
                txtTotal.Text = TongTien(maban).ToString();
            }

            

            
            
            


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvBill.Rows[e.RowIndex];
                txtFoodName.Text = row.Cells["Tên món ăn"].Value.ToString();
                txtUnitPrice.Text = row.Cells["Giá"].Value.ToString();
                txtCount.Text = row.Cells["Số lượng"].Value.ToString();
                txtPrice.Text = row.Cells["Thành tiền"].Value.ToString();



                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int mahoadon = Convert.ToInt32(txtIdBill.Text);
                int tongtien = Convert.ToInt32(txtTotal.Text);
                DateTime ngaythanhtoan = Convert.ToDateTime(txtDate.Text);
                if (BillDAO.Instance.UpdateBill(mahoadon, ngaythanhtoan, tongtien) == true)
                {
                    MessageBox.Show("Lưu thông tin hoá đơn thành công");

                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Thông tin trống");
            }


        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if(dtgvBill.Rows.Count>0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                           
                            PdfPTable pdfTable = new PdfPTable(dtgvBill.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                           
                            foreach (DataGridViewColumn column in dtgvBill.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dtgvBill.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if(cell.Value!=null)
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("In thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }

        private void ListBill_Load(object sender, EventArgs e)
        {

        }
    }
}
