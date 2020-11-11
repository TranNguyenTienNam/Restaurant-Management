﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace QLNV.DTO
{
    public class Menu
    {
        private string tenthucan;
        private int soluong;
        private int gia;
        private int thanhtien;
      

        public string Tenthucan { get => tenthucan; set => tenthucan = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }

        public Menu(DataRow row)
        {
            tenthucan = (string)row["TENTHUCAN"];
            soluong = (int)row["SOLUONG"];
            gia = (int)row["GIA"];
            Thanhtien = (int)row["THANHTIEN"];
        }
    }
}
