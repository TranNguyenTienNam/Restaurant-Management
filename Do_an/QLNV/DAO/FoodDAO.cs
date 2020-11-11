using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.DAO
{
    public class FoodDAO
    {
        private  FoodDAO() { }
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return instance;
            }
        }
        public DataTable LoadFood()
        {
            DataTable data = new DataTable();
            data=DataProvider.Instance.ExecuteQuery("Select *from THUCAN");
            return data;
        }


    }
}
