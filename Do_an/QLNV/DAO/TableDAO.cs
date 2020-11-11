using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace QLNV.DAO
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



        }
    
}
