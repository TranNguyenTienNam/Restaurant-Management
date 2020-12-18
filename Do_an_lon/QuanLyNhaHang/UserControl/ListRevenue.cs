using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using PagedList;

namespace QuanLyNhaHang
{
    public partial class ListRevenue : UserControl
    {
        public ListRevenue()
        {
            InitializeComponent();

            LoadRevenue();
            LoadChart();

            //InitializeChart();
        }

        int sumRecord;
        int maxPage;
        int currentPage = 1;
        int pageSize = 1;
        int UpdateMaxPage()
        {
            string fromDate, toDate;

            switch (cbbStatiticsMode.SelectedIndex)
            {
                case 0:
                    fromDate = dtp_From.Value.ToShortDateString();
                    toDate = dtp_To.Value.ToShortDateString();
                    sumRecord = RevenueDAO.Instance.GetNumBillList_ByDay(fromDate, toDate);
                    break;
                case 1:
                    fromDate = dtp_From.Value.Month.ToString();
                    toDate = dtp_To.Value.Month.ToString();
                    sumRecord = RevenueDAO.Instance.GetNumBillList_ByMonth(fromDate, toDate);
                    break;
                case 2:
                    fromDate = dtp_From.Value.Year.ToString();
                    toDate = dtp_To.Value.Year.ToString();
                    sumRecord = RevenueDAO.Instance.GetNumBillList_ByYear(fromDate, toDate);
                    break;
                default: break;
            }
            maxPage = sumRecord / pageSize;
            if (sumRecord % pageSize != 0) { maxPage++; } 
            return maxPage;
        }

        void LoadRevenue()
        {
            string fromDate, toDate;
            int selectRows = pageSize * currentPage;
            int exceptRows = (currentPage - 1) * pageSize;

            switch (cbbStatiticsMode.SelectedIndex)
            {
                case 0:
                    fromDate = dtp_From.Value.ToShortDateString();
                    toDate = dtp_To.Value.ToShortDateString();
                    dtgvRevenue.DataSource = RevenueDAO.Instance.LoadRevenue_ByDay(fromDate, toDate, selectRows, exceptRows);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvRevenue.Columns["Ngày"].DisplayIndex = 0;
                    dtgvRevenue.Columns["Tháng"].DisplayIndex = 1;
                    dtgvRevenue.Columns["Năm"].DisplayIndex = 2;
                    dtgvRevenue.Columns["Doanh thu"].DisplayIndex = 3;
                    break;
                case 1:
                    fromDate = dtp_From.Value.Month.ToString();
                    toDate = dtp_To.Value.Month.ToString();
                    dtgvRevenue.DataSource = RevenueDAO.Instance.LoadRevenue_ByMonth(fromDate, toDate, selectRows, exceptRows);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvRevenue.Columns["Tháng"].DisplayIndex = 0;
                    dtgvRevenue.Columns["Năm"].DisplayIndex = 1;
                    dtgvRevenue.Columns["Doanh thu"].DisplayIndex = 2;
                    break;
                case 2:
                    fromDate = dtp_From.Value.Year.ToString();
                    toDate = dtp_To.Value.Year.ToString();
                    dtgvRevenue.DataSource = RevenueDAO.Instance.LoadRevenue_ByYear(fromDate, toDate, selectRows, exceptRows);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvRevenue.Columns["Năm"].DisplayIndex = 0;
                    dtgvRevenue.Columns["Doanh thu"].DisplayIndex = 1;
                    break;
                default: break;
            }
            maxPage = UpdateMaxPage();
        }

        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenue();
            LoadChart();
            //maxPage = UpdateMaxPage();
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenue();
            LoadChart();
            //maxPage = UpdateMaxPage();
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void cbbStatiticsMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenue();
            LoadChart();
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }

        private void ListRevenue_Load(object sender, EventArgs e)
        {
            currentPage = 1;
            maxPage = UpdateMaxPage();
            dtp_From.Value = new DateTime(2020, 1, 1);
            cbbStatiticsMode.SelectedItem = "Ngày";
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);
        }             

        void LoadChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Title = "Thời gian";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu";

            for (int i = 0; i < dtgvRevenue.Rows.Count; i++)
            {
                Series S = chart1.Series.Add(dtgvRevenue[0, i].Value.ToString());
                S.ChartType = SeriesChartType.Column;
                S.Color = Color.Blue;
            }

            if (cbbStatiticsMode.SelectedIndex != 2)
            {
                string x_axis_format = "{0}/{1}";

                // and fill in all the values from the dgv to the chart:
                for (int i = 0; i < dtgvRevenue.Rows.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(string.Format(x_axis_format, dtgvRevenue[0, i].Value, dtgvRevenue[1, i].Value),
                                dtgvRevenue[dtgvRevenue.Columns.Count - 1, i].Value);
                    chart1.Series[0]["PointWidth"] = "0.2";
                    chart1.Series[0].IsValueShownAsLabel = true;
                }
            }
            else
            {
                string x_axis_format = "{0}";

                // and fill in all the values from the dgv to the chart:
                for (int i = 0; i < dtgvRevenue.Rows.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(string.Format(x_axis_format, dtgvRevenue[0, i].Value),
                                dtgvRevenue[dtgvRevenue.Columns.Count - 1, i].Value);
                    chart1.Series[0]["PointWidth"] = "0.5";
                    chart1.Series[0].IsValueShownAsLabel = true;
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            maxPage = UpdateMaxPage();
            currentPage = 1;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);

            LoadRevenue();
            LoadChart();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            maxPage = UpdateMaxPage();
            currentPage = maxPage;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);

            LoadRevenue();
            LoadChart();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            maxPage = UpdateMaxPage();
            if (currentPage > 1) currentPage--;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);

            LoadRevenue();
            LoadChart();
        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
            maxPage = UpdateMaxPage();
            if (currentPage < maxPage) currentPage++;
            txtPage.Text = string.Format("{0}/{1}", currentPage, maxPage);

            LoadRevenue();
            LoadChart();
        }
    }
}
