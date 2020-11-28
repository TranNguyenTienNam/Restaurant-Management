﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace QuanLyNhaHang
{


    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return instance;
            }
        }
        public List<Table> GetListTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from BANAN");
            List<Table> TableList = new List<Table>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Table table = new Table(data.Rows[i]);
                TableList.Add(table);
            }
            return TableList;
        }
       public List<Table> GetListTableById(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery
                ("Select *from BANAN where MABAN=" + id);
            List<Table> TableList = new List<Table>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Table table = new Table(data.Rows[i]);
                TableList.Add(table);
            }
            return TableList;

        }
        public void UpdateStatusById(int maban)
        {
            string query = "Update BANAN set TRANGTHAI=N'Có người' "
                + "where MABAN=" + maban;
            DataProvider.Instance.ExecuteNonQuery(query);

        }
        public void ResetStatusById(int maban)
        {
            string query = "Update BANAN set TRANGTHAI=N'Trống' "
                + "where MABAN=" + maban;
            DataProvider.Instance.ExecuteNonQuery(query);
        }




    }
    
}
