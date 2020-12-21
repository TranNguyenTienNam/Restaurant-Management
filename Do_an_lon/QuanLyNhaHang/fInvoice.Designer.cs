namespace QuanLyNhaHang
{
    partial class fInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInvoice));
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpaymentcustomers = new System.Windows.Forms.TextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtIdTable = new System.Windows.Forms.TextBox();
            this.txtIdBill = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBill.Location = new System.Drawing.Point(11, 285);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersWidth = 62;
            this.dtgvBill.RowTemplate.Height = 28;
            this.dtgvBill.Size = new System.Drawing.Size(736, 218);
            this.dtgvBill.TabIndex = 1;
            this.dtgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellContentClick);
            this.dtgvBill.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvBill_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.txtCount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.txtFoodName);
            this.panel2.Location = new System.Drawing.Point(11, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 114);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel16.Location = new System.Drawing.Point(497, 39);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1, 14);
            this.panel16.TabIndex = 25;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel15.Location = new System.Drawing.Point(497, 75);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1, 14);
            this.panel15.TabIndex = 24;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel14.Location = new System.Drawing.Point(124, 75);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1, 14);
            this.panel14.TabIndex = 23;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel13.Location = new System.Drawing.Point(124, 39);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 14);
            this.panel13.TabIndex = 22;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel11.Location = new System.Drawing.Point(497, 88);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(156, 1);
            this.panel11.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel10.Location = new System.Drawing.Point(497, 52);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(156, 1);
            this.panel10.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Location = new System.Drawing.Point(125, 88);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(156, 1);
            this.panel7.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(125, 52);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(156, 1);
            this.panel6.TabIndex = 18;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCount.Location = new System.Drawing.Point(500, 39);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(156, 13);
            this.txtCount.TabIndex = 15;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(276, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Thông tin món ăn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(397, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Thành tiền:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(397, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên món ăn:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Location = new System.Drawing.Point(500, 75);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(156, 13);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnitPrice.Location = new System.Drawing.Point(127, 75);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(156, 13);
            this.txtUnitPrice.TabIndex = 2;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Location = new System.Drawing.Point(127, 38);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.ReadOnly = true;
            this.txtFoodName.Size = new System.Drawing.Size(156, 13);
            this.txtFoodName.TabIndex = 1;
            this.txtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.panel21);
            this.panel1.Controls.Add(this.panel22);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel20);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtpaymentcustomers);
            this.panel1.Controls.Add(this.panel19);
            this.panel1.Controls.Add(this.panel18);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtIdTable);
            this.panel1.Controls.Add(this.txtIdBill);
            this.panel1.Location = new System.Drawing.Point(11, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 131);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel21.Location = new System.Drawing.Point(497, 98);
            this.panel21.Margin = new System.Windows.Forms.Padding(2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(1, 14);
            this.panel21.TabIndex = 36;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel22.Location = new System.Drawing.Point(497, 111);
            this.panel22.Margin = new System.Windows.Forms.Padding(2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(156, 1);
            this.panel22.TabIndex = 35;
            this.panel22.Paint += new System.Windows.Forms.PaintEventHandler(this.panel22_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Thối lại:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChange.Location = new System.Drawing.Point(508, 93);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(156, 13);
            this.txtChange.TabIndex = 33;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(497, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 14);
            this.panel3.TabIndex = 32;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel20.Location = new System.Drawing.Point(497, 80);
            this.panel20.Margin = new System.Windows.Forms.Padding(2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(156, 1);
            this.panel20.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = " Khách thanh toán:";
            // 
            // txtpaymentcustomers
            // 
            this.txtpaymentcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtpaymentcustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpaymentcustomers.Location = new System.Drawing.Point(508, 62);
            this.txtpaymentcustomers.Name = "txtpaymentcustomers";
            this.txtpaymentcustomers.Size = new System.Drawing.Size(156, 13);
            this.txtpaymentcustomers.TabIndex = 29;
            this.txtpaymentcustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpaymentcustomers.TextChanged += new System.EventHandler(this.txtpaymentcustomers_TextChanged);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel19.Location = new System.Drawing.Point(124, 68);
            this.panel19.Margin = new System.Windows.Forms.Padding(2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1, 14);
            this.panel19.TabIndex = 28;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel18.Location = new System.Drawing.Point(497, 41);
            this.panel18.Margin = new System.Windows.Forms.Padding(2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1, 14);
            this.panel18.TabIndex = 27;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel17.Location = new System.Drawing.Point(124, 97);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1, 14);
            this.panel17.TabIndex = 26;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel12.Location = new System.Drawing.Point(124, 38);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 14);
            this.panel12.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel9.Location = new System.Drawing.Point(497, 54);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(156, 1);
            this.panel9.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel8.Location = new System.Drawing.Point(124, 111);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(156, 1);
            this.panel8.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(125, 81);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 1);
            this.panel5.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(125, 51);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 1);
            this.panel4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông tin chung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng cộng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã bàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(508, 36);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(156, 13);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(127, 97);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(156, 13);
            this.txtDate.TabIndex = 2;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdTable
            // 
            this.txtIdTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtIdTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdTable.Location = new System.Drawing.Point(127, 68);
            this.txtIdTable.Name = "txtIdTable";
            this.txtIdTable.ReadOnly = true;
            this.txtIdTable.Size = new System.Drawing.Size(156, 13);
            this.txtIdTable.TabIndex = 1;
            this.txtIdTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIdBill
            // 
            this.txtIdBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.txtIdBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdBill.Location = new System.Drawing.Point(127, 38);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.ReadOnly = true;
            this.txtIdBill.Size = new System.Drawing.Size(156, 13);
            this.txtIdBill.TabIndex = 0;
            this.txtIdBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::QuanLyNhaHang.Properties.Resources.cancel1;
            this.buttonClose.Location = new System.Drawing.Point(719, 4);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 20);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "\r\n";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Moccasin;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Image = global::QuanLyNhaHang.Properties.Resources.bill;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(538, 507);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(98, 34);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Violet;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(649, 507);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 34);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "      In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 569);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtgvBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(399, 110);
            this.Name = "fInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fInvoice";
            this.Load += new System.EventHandler(this.fInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIdTable;
        private System.Windows.Forms.TextBox txtIdBill;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpaymentcustomers;
        private System.Windows.Forms.Button buttonClose;
    }
}