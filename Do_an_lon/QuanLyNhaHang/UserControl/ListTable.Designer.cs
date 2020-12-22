namespace QuanLyNhaHang
{
    partial class ListTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListTable));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvFoodbyId = new System.Windows.Forms.DataGridView();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPayMonney = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMergeTable = new System.Windows.Forms.ComboBox();
            this.btnMergeTable = new System.Windows.Forms.Button();
            this.cbbSwichTable = new System.Windows.Forms.ComboBox();
            this.btnSwichTable = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvFoodbyId);
            this.panel2.Location = new System.Drawing.Point(528, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 691);
            this.panel2.TabIndex = 21;
            // 
            // dtgvFoodbyId
            // 
            this.dtgvFoodbyId.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvFoodbyId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFoodbyId.Location = new System.Drawing.Point(0, 5);
            this.dtgvFoodbyId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvFoodbyId.Name = "dtgvFoodbyId";
            this.dtgvFoodbyId.RowHeadersWidth = 62;
            this.dtgvFoodbyId.Size = new System.Drawing.Size(600, 687);
            this.dtgvFoodbyId.TabIndex = 0;
            this.dtgvFoodbyId.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFoodbyId_CellContentClick_3);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Yellow;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(4, 5);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(233, 97);
            this.buttonOrder.TabIndex = 28;
            this.buttonOrder.Text = "Gọi món";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonPayMonney);
            this.panel3.Controls.Add(this.buttonOrder);
            this.panel3.Location = new System.Drawing.Point(21, 718);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 122);
            this.panel3.TabIndex = 28;
            // 
            // buttonPayMonney
            // 
            this.buttonPayMonney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPayMonney.FlatAppearance.BorderSize = 0;
            this.buttonPayMonney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayMonney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayMonney.Location = new System.Drawing.Point(271, 5);
            this.buttonPayMonney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPayMonney.Name = "buttonPayMonney";
            this.buttonPayMonney.Size = new System.Drawing.Size(224, 97);
            this.buttonPayMonney.TabIndex = 29;
            this.buttonPayMonney.Text = "Thanh toán";
            this.buttonPayMonney.UseVisualStyleBackColor = false;
            this.buttonPayMonney.Click += new System.EventHandler(this.buttonPayMonney_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbbMergeTable);
            this.panel1.Controls.Add(this.btnMergeTable);
            this.panel1.Controls.Add(this.cbbSwichTable);
            this.panel1.Controls.Add(this.btnSwichTable);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(532, 718);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 122);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbbMergeTable
            // 
            this.cbbMergeTable.FormattingEnabled = true;
            this.cbbMergeTable.Location = new System.Drawing.Point(17, 74);
            this.cbbMergeTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMergeTable.Name = "cbbMergeTable";
            this.cbbMergeTable.Size = new System.Drawing.Size(189, 28);
            this.cbbMergeTable.TabIndex = 33;
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMergeTable.FlatAppearance.BorderSize = 0;
            this.btnMergeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMergeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMergeTable.Image = ((System.Drawing.Image)(resources.GetObject("btnMergeTable.Image")));
            this.btnMergeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMergeTable.Location = new System.Drawing.Point(214, 62);
            this.btnMergeTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.Size = new System.Drawing.Size(147, 45);
            this.btnMergeTable.TabIndex = 32;
            this.btnMergeTable.Text = "  Gộp";
            this.btnMergeTable.UseVisualStyleBackColor = false;
            this.btnMergeTable.Click += new System.EventHandler(this.btnMergeTable_Click);
            // 
            // cbbSwichTable
            // 
            this.cbbSwichTable.FormattingEnabled = true;
            this.cbbSwichTable.Location = new System.Drawing.Point(17, 20);
            this.cbbSwichTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbSwichTable.Name = "cbbSwichTable";
            this.cbbSwichTable.Size = new System.Drawing.Size(189, 28);
            this.cbbSwichTable.TabIndex = 31;
            this.cbbSwichTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSwichTable
            // 
            this.btnSwichTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSwichTable.FlatAppearance.BorderSize = 0;
            this.btnSwichTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwichTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwichTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSwichTable.Image")));
            this.btnSwichTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwichTable.Location = new System.Drawing.Point(214, 8);
            this.btnSwichTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwichTable.Name = "btnSwichTable";
            this.btnSwichTable.Size = new System.Drawing.Size(147, 45);
            this.btnSwichTable.TabIndex = 30;
            this.btnSwichTable.Text = "    Chuyển";
            this.btnSwichTable.UseVisualStyleBackColor = false;
            this.btnSwichTable.Click += new System.EventHandler(this.btn_SwitchTable);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(420, 59);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(157, 26);
            this.txtTongTien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 691);
            this.flowLayoutPanel1.TabIndex = 30;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ListTable";
            this.Size = new System.Drawing.Size(1132, 845);
            this.Load += new System.EventHandler(this.ListTable_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFoodbyId)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonPayMonney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvFoodbyId;
        private System.Windows.Forms.ComboBox cbbMergeTable;
        private System.Windows.Forms.Button btnMergeTable;
        private System.Windows.Forms.ComboBox cbbSwichTable;
        private System.Windows.Forms.Button btnSwichTable;
    }
}
