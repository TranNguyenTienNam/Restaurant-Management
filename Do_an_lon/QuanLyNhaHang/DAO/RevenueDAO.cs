using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace QuanLyNhaHang
{
    public class RevenueDAO
    {
        private static RevenueDAO instance;
        public static RevenueDAO Instance
        {
            get { if (instance == null) instance = new RevenueDAO(); return RevenueDAO.instance; }
            private set { RevenueDAO.instance = value; }
        }

        private RevenueDAO() { }
        public DataTable LoadRevenue_ByDay(string fromDate, string toDate)
        {
            string query = "SELECT CAST(DAY(NGAYTHANHTOAN) AS VARCHAR(2)) + '-' + CAST(MONTH(NGAYTHANHTOAN) AS VARCHAR(4)) "
                                + "+ '-' + CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) as N'Ngày', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND NGAYTHANHTOAN >= '" + fromDate + "' AND NGAYTHANHTOAN <= '" + toDate + "' "
                                + "GROUP BY CAST(DAY(NGAYTHANHTOAN) AS VARCHAR(2)) + '-' + CAST(MONTH(NGAYTHANHTOAN) AS VARCHAR(4)) + '-' + CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) "
                                + "ORDER BY CAST(DAY(NGAYTHANHTOAN) AS VARCHAR(2)) + '-' + CAST(MONTH(NGAYTHANHTOAN) AS VARCHAR(4)) + '-' + CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) ASC;";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadRevenue_ByMonth(string fromDate, string toDate)
        {
            string query = "SELECT CAST(MONTH(NGAYTHANHTOAN) AS VARCHAR(4)) + '-' + CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) as N'Tháng', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND MONTH(NGAYTHANHTOAN) >= '" + fromDate + "' AND MONTH(NGAYTHANHTOAN) <= '" + toDate + "' "
                                + "GROUP BY CAST(MONTH(NGAYTHANHTOAN) AS VARCHAR(4)) + '-' + CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) "
                                + "ORDER BY CAST(MONTH(NGAYTHANHTOAN) AS VARCHAR(4)) + '-' + CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) ASC;";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadRevenue_ByYear(string fromDate, string toDate)
        {
            string query = "SELECT CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) as N'Năm', "
                                + "sum(TONGTIEN) as N'Doanh thu' from HOADON where TONGTIEN > 0 "
                                + "AND YEAR(NGAYTHANHTOAN) >= '" + fromDate + "' AND YEAR(NGAYTHANHTOAN) <= '" + toDate + "' "
                                + "GROUP BY CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) ORDER BY CAST(YEAR(NGAYTHANHTOAN) AS VARCHAR(4)) ASC;";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetSaleInfos(DateTime fromDate, DateTime toDate)
        {

            return DataProvider.Instance.ExecuteQuery(
            "SELECT HOADON.TONGTIEN revenue, YEAR(HOADON.NGAYTHANHTOAN) y, MONTH(HOADON.NGAYTHANHTOAN) m "
                                + "FROM CHITIETHOADON dt LEFT JOIN HOADON on dt.MAHOADON = HOADON.MAHOADON "
                                + "WHERE HOADON.NGAYTHANHTOAN >= " + fromDate + "AND HOADON.NGAYTHANHTOAN <= " + toDate
                                  + "GROUP BY YEAR(HOADON.NGAYTHANHTOAN) ORDER BY YEAR(HOADON.NGAYTHANHTOAN) ASC;");
        }
    }
}