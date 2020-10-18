﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

namespace QLNV.DAO
{
    public class PersonDAO
    {
        private static PersonDAO instance;
        public static PersonDAO Instance
        {
            get { if (instance == null) instance = new PersonDAO(); return PersonDAO.instance; }
            private set { PersonDAO.instance = value; }
        }

        private PersonDAO() { }
        public DataTable LoadPerson()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT *FROM NHANVIEN");
        }
        public bool InsertPerson(string id,string name, string ngsinh,string gioitinh,string chucvu)
        {
            string query = "INSERT INTO NHANVIEN(MANV,HOTEN,GIOITINH,NGSINH,CHUCVU) VALUES ('"+id+"',N'"+name+"',N'"+gioitinh+"','"+ngsinh + "',N'" + chucvu + "')";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool UpdatePerson(string id, string name, string chucvu,string gioitinh,string ngsinh)
        {
            string query = "UPDATE NHANVIEN SET HOTEN =N'" + name + "', CHUCVU=N'" + chucvu + "',GIOITINH=N'"+gioitinh+"',NGSINH='"+ngsinh+"' WHERE MANV='" + id+"'" ;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool DeletePerson(string id)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV='" + id +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;


        }
    }
}
