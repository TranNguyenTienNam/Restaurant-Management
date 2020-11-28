using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace QuanLyNhaHang
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        private MenuDAO() { }
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null) instance = new MenuDAO();
                return instance;
            }
        }
        public List<Menu> GetListMenusById(int MaBan)
        {
            string query = "USP_GetListMenuByIdTable @MABAN";
            List<Menu> menus = new List<Menu>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaBan });
            foreach (DataRow dataRow in data.Rows)
            {
                Menu menu = new Menu(dataRow);
          
                menus.Add(menu);

            }
            return menus;
        }

    }
}
