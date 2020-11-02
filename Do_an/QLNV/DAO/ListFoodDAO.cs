using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.DAO
{
    public class ListFoodDAO
    {
        private static ListFoodDAO instance;
        public static ListFoodDAO Instance
        {
            get { if (instance == null) instance = new ListFoodDAO(); return ListFoodDAO.instance; }
            private set { ListFoodDAO.instance = value; }
        }

        private ListFoodDAO() { }
       /* public DataTable LoadListFood()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT *FROM MONAN ");
        }*/
    }
}
