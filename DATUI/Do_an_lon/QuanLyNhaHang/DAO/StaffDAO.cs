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
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        private StaffDAO() { }
        public DataTable LoadStaff()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT *FROM NHANVIEN");
        }
      public bool InsertStaff(int manhanvien,string ten,string chucvu,string gioitinh,DateTime ngaysinh)
        {
            string query = "INSERT INTO NHANVIEN(MANHANVIEN,HOTEN,CHUCVU,GIOITINH,NGAYSINH)" +
                " VALUES ("+manhanvien+",N'" + ten + "',N'" + chucvu + "','" + gioitinh + "',N'" + ngaysinh + "')";
            int x = DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }
        public bool UpdateStaff(int id, string name, string chucvu, string gioitinh, DateTime ngsinh)
        {
            string query = "UPDATE NHANVIEN SET HOTEN =N'" + name + "', CHUCVU=N'" + chucvu + "',GIOITINH=N'" + 
                gioitinh + "',NGAYSINH='" + ngsinh + "' WHERE MANHANVIEN='" + id + "'";
            int x = DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;
        }

        public bool DeleteStaff(int id)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANHANVIEN='" + id + "'";
            int x = DataProvider.Instance.ExecuteNonQuery(query);
            if (x > 0) return true;
            return false;


        }
        public DataTable SearchStaffByName(string hoten)
        {
            string query = "Select *from NHANVIEN where HOTEN like N'" + hoten + "%'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
                     
        }
    }
}
