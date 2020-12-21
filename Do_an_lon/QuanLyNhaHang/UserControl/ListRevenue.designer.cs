namespace QuanLyNhaHang
{
    partial class ListRevenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNxt = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbStatiticsMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.dtgvRevenue);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_From);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_To);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(790, 544);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFirst);
            this.groupBox2.Controls.Add(this.btnLast);
            this.groupBox2.Controls.Add(this.btnNxt);
            this.groupBox2.Controls.Add(this.btnPre);
            this.groupBox2.Controls.Add(this.txtPage);
            this.groupBox2.Location = new System.Drawing.Point(2, 515);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(398, 26);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(0, -1);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(52, 24);
            this.btnFirst.TabIndex = 29;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(292, -1);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(52, 24);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNxt
            // 
            this.btnNxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxt.Location = new System.Drawing.Point(231, -1);
            this.btnNxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(56, 24);
            this.btnNxt.TabIndex = 27;
            this.btnNxt.Text = "Sau";
            this.btnNxt.UseVisualStyleBackColor = true;
            this.btnNxt.Click += new System.EventHandler(this.btnNxt_Click);
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(57, -1);
            this.btnPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(56, 24);
            this.btnPre.TabIndex = 25;
            this.btnPre.Text = "Trước";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // txtPage
            // 
            this.txtPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.Location = new System.Drawing.Point(118, 0);
            this.txtPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPage.Name = "txtPage";
            this.txtPage.ReadOnly = true;
            this.txtPage.Size = new System.Drawing.Size(110, 26);
            this.txtPage.TabIndex = 28;
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.TextChanged += new System.EventHandler(this.txtPage_TextChanged);
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.AllowUserToAddRows = false;
            this.dtgvRevenue.AllowUserToDeleteRows = false;
            this.dtgvRevenue.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvRevenue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvRevenue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvRevenue.Location = new System.Drawing.Point(4, 53);
            this.dtgvRevenue.MultiSelect = false;
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.ReadOnly = true;
            this.dtgvRevenue.RowHeadersVisible = false;
            this.dtgvRevenue.RowHeadersWidth = 51;
            this.dtgvRevenue.RowTemplate.Height = 24;
            this.dtgvRevenue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvRevenue.Size = new System.Drawing.Size(344, 458);
            this.dtgvRevenue.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbStatiticsMode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // cbbStatiticsMode
            // 
            this.cbbStatiticsMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatiticsMode.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbbStatiticsMode.Location = new System.Drawing.Point(78, 14);
            this.cbbStatiticsMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbStatiticsMode.Name = "cbbStatiticsMode";
            this.cbbStatiticsMode.Size = new System.Drawing.Size(118, 25);
            this.cbbStatiticsMode.TabIndex = 7;
            this.cbbStatiticsMode.SelectedIndexChanged += new System.EventHandler(this.cbbStatiticsMode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn vị xem";
            // 
            // dtp_From
            // 
            this.dtp_From.CustomFormat = "dd/MM/yyyy";
            this.dtp_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_From.Location = new System.Drawing.Point(247, 5);
            this.dtp_From.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(101, 23);
            this.dtp_From.TabIndex = 11;
            this.dtp_From.ValueChanged += new System.EventHandler(this.dtp_From_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến:";
            // 
            // dtp_To
            // 
            this.dtp_To.CustomFormat = "dd/MM/yyyy";
            this.dtp_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_To.Location = new System.Drawing.Point(247, 29);
            this.dtp_To.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(102, 23);
            this.dtp_To.TabIndex = 13;
            this.dtp_To.ValueChanged += new System.EventHandler(this.dtp_To_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(2, 60);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(407, 451);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ListRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListRevenue";
            this.Size = new System.Drawing.Size(795, 549);
            this.Load += new System.EventHandler(this.ListRevenue_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbStatiticsMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
