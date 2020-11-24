namespace QuanLyNhaHang
{
    partial class ListFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListFood));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDeleteFood = new System.Windows.Forms.Button();
            this.buttonUpdateFood = new System.Windows.Forms.Button();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(331, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox4.Location = new System.Drawing.Point(35, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(290, 26);
            this.textBox4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(242)))), ((int)(((byte)(213)))));
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.txtFoodName);
            this.panel3.Controls.Add(this.txtTypeID);
            this.panel3.Controls.Add(this.txtFoodID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(35, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 274);
            this.panel3.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(200, 208);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(234, 37);
            this.txtAmount.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số lượng:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(633, 122);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(234, 37);
            this.txtPrice.TabIndex = 10;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(633, 36);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(234, 37);
            this.txtFoodName.TabIndex = 9;
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(200, 122);
            this.txtTypeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(234, 37);
            this.txtTypeID.TabIndex = 7;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(200, 36);
            this.txtFoodID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(234, 37);
            this.txtFoodID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên món ăn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã món ăn :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(35, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 418);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(242)))), ((int)(((byte)(213)))));
            this.panel4.Controls.Add(this.buttonDeleteFood);
            this.panel4.Controls.Add(this.buttonUpdateFood);
            this.panel4.Controls.Add(this.buttonAddFood);
            this.panel4.Location = new System.Drawing.Point(939, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 274);
            this.panel4.TabIndex = 5;
            // 
            // buttonDeleteFood
            // 
            this.buttonDeleteFood.FlatAppearance.BorderSize = 0;
            this.buttonDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFood.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteFood.Image")));
            this.buttonDeleteFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteFood.Location = new System.Drawing.Point(4, 200);
            this.buttonDeleteFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteFood.Name = "buttonDeleteFood";
            this.buttonDeleteFood.Size = new System.Drawing.Size(158, 69);
            this.buttonDeleteFood.TabIndex = 2;
            this.buttonDeleteFood.Text = "Xóa";
            this.buttonDeleteFood.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateFood
            // 
            this.buttonUpdateFood.FlatAppearance.BorderSize = 0;
            this.buttonUpdateFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateFood.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateFood.Image")));
            this.buttonUpdateFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateFood.Location = new System.Drawing.Point(4, 105);
            this.buttonUpdateFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUpdateFood.Name = "buttonUpdateFood";
            this.buttonUpdateFood.Size = new System.Drawing.Size(158, 69);
            this.buttonUpdateFood.TabIndex = 1;
            this.buttonUpdateFood.Text = "Sửa";
            this.buttonUpdateFood.UseVisualStyleBackColor = true;
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.FlatAppearance.BorderSize = 0;
            this.buttonAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddFood.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFood.Image")));
            this.buttonAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddFood.Location = new System.Drawing.Point(4, 5);
            this.buttonAddFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(158, 69);
            this.buttonAddFood.TabIndex = 0;
            this.buttonAddFood.Text = "   Thêm";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            // 
            // ListFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(242)))), ((int)(((byte)(199)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel3);
            this.Name = "ListFood";
            this.Size = new System.Drawing.Size(1132, 844);
            this.Load += new System.EventHandler(this.ListFood_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDeleteFood;
        private System.Windows.Forms.Button buttonUpdateFood;
        private System.Windows.Forms.Button buttonAddFood;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
