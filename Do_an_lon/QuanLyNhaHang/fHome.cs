﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

namespace QuanLyNhaHang
{
    public partial class fHome : Form
    {
        int PanelWidth;
        

        public fHome()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            panelMove.Height = buttonHome.Height;
            panelMove.Top = buttonHome.Top;
            buttonHome.BackColor = Color.FromArgb(5, 242, 199);
            
        }





        private void buttonFood_Click(object sender, EventArgs e)
        {
            //PanelLeft hiển thị theo từng tab
            panelMove.Height = buttonFood.Height;
            panelMove.Top = buttonFood.Top;
            buttonFood.BackColor = Color.FromArgb(5, 242, 199);
            //LoadData lên form
            ListFood f = new ListFood();
            this.panelLoadData.Controls.Add(f);
            f.BringToFront();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonTable.Height;
            panelMove.Top = buttonTable.Top;
            buttonTable.BackColor = Color.FromArgb(5, 242, 199);
            //LoadData lên form
            ListTable f = new ListTable();
            this.panelLoadData.Controls.Add(f);
            f.BringToFront();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonStaff.Height;
            panelMove.Top = buttonStaff.Top;
            buttonStaff.BackColor = Color.FromArgb(5, 242, 199);
            //LoadData lên form
            ListStaff f = new ListStaff();
            this.panelLoadData.Controls.Add(f);
            f.BringToFront();
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonBill.Height;
            panelMove.Top = buttonBill.Top;
            buttonBill.BackColor = Color.FromArgb(5, 242, 199);

        }



        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonHome.Height;
            panelMove.Top = buttonHome.Top;
            buttonHome.BackColor = Color.FromArgb(5, 242, 199);
            //LoadData lên form
            ListHome fh = new ListHome();
            this.panelLoadData.Controls.Add(fh);
            fh.BringToFront();
            
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new fLogin().Show();
        }



        private void buttonRevenue_Click(object sender, EventArgs e)
        {
            panelMove.Height = buttonRevenue.Height;
            panelMove.Top = buttonRevenue.Top;
            buttonRevenue.BackColor = Color.FromArgb(5, 242, 199);

        }


        private void fHome_Load(object sender, EventArgs e)
        {
            this.Height = 880;
            this.Width = 1400;

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLoadData_Paint(object sender, PaintEventArgs e)
        {

        }
        // Đổi màu button theo từng form của nó
        private void buttonFood_Leave(object sender, EventArgs e)
        {
            buttonFood.BackColor = Color.FromArgb(4, 191, 148);
        }

        private void buttonHome_Leave(object sender, EventArgs e)
        {
            buttonHome.BackColor = Color.FromArgb(4, 191, 148);
        }

        private void buttonTable_Leave(object sender, EventArgs e)
        {
            buttonTable.BackColor = Color.FromArgb(4, 191, 148);
        }

        private void buttonStaff_Leave(object sender, EventArgs e)
        {
            buttonStaff.BackColor = Color.FromArgb(4, 191, 148);
        }

        private void buttonBill_Leave(object sender, EventArgs e)
        {
            buttonBill.BackColor = Color.FromArgb(4, 191, 148);
        }

        private void buttonRevenue_Leave(object sender, EventArgs e)
        {
            buttonRevenue.BackColor = Color.FromArgb(4, 191, 148);
        }
    }
}
