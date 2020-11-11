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
        public List<DTO.Menu> GetListMenus(int MaBan)
        {
            string query = "USP_GetListMenuByIdTable @MABAN";
            List<DTO.Menu> menus = new List<DTO.Menu>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaBan });
            foreach (DataRow dataRow in data.Rows)
            {
                DTO.Menu menu = new DTO.Menu(dataRow);
          
                menus.Add(menu);

            }
            return menus;
        }

    }
}
