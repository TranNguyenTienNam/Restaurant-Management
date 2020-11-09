using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV
{
    public class Table
    {
        private int iD;
        private string status;
        private string name;
        public Table(DataRow data)
        {
            this.iD = (int)data["MABAN"];
            this.status = (string)data["TRANGTHAI"];
            this.name = (string)data["TENBAN"];

        }
        public int ID { get => iD; set => iD = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
    }
}
