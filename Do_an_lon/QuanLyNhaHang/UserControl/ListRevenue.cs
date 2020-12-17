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
using LiveCharts;
using LiveCharts.Wpf;

namespace QuanLyNhaHang
{
    public partial class ListRevenue : UserControl
    {
        public ListRevenue()
        {
            InitializeComponent();

            LoadRevenue();

            //InitializeChart();
        }
        void LoadRevenue()
        {
            string fromDate, toDate;
            switch (cbbStatiticsMode.SelectedIndex)
            {
                case 0:
                    fromDate = dtp_From.Value.ToShortDateString();
                    toDate = dtp_To.Value.ToShortDateString();
                    dtgvRevenue.DataSource = RevenueDAO.Instance.LoadRevenue_ByDay(fromDate, toDate);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case 1:
                    fromDate = dtp_From.Value.Month.ToString(); 
                    toDate = dtp_To.Value.Month.ToString(); 
                    dtgvRevenue.DataSource = RevenueDAO.Instance.LoadRevenue_ByMonth(fromDate, toDate);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                case 2:
                    fromDate = dtp_From.Value.Year.ToString();
                    toDate = dtp_To.Value.Year.ToString();
                    dtgvRevenue.DataSource = RevenueDAO.Instance.LoadRevenue_ByYear(fromDate, toDate);
                    dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
                default: break;
            }
        }

        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenue();
        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            LoadRevenue();
        }

        private void cbbStatiticsMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRevenue();
        }

        //void InitializeChart()
        //{
        //    cartesianChart1.Series = new SeriesCollection
        //    {
        //        new ColumnSeries
        //        {
        //            Title = "2015",
        //            Values = new ChartValues<double> { 10, 50, 39, 50 }
        //        }
        //    };

        //    //adding series will update and animate the chart automatically
        //    cartesianChart1.Series.Add(new ColumnSeries
        //    {
        //        Title = "2016",
        //        Values = new ChartValues<double> { 11, 56, 42 }
        //    });

        //    //also adding values updates and animates the chart automatically
        //    cartesianChart1.Series[1].Values.Add(48d);

        //    cartesianChart1.AxisX.Add(new Axis
        //    {
        //        Title = "Sales Man",
        //        Labels = new[] { "Maria", "Susan", "Charles", "Frida" }
        //    });

        //    cartesianChart1.AxisY.Add(new Axis
        //    {
        //        Title = "Sold Apps",
        //        LabelFormatter = value => value.ToString("N")
        //    });
        //}

    }
}
