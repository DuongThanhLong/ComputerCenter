﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ComputerCenter.DAO;

namespace ComputerCenter.BUS
{
    public class DiemThiTN
    {
        DiemThiTN_DB TN = new DiemThiTN_DB();

        public DataTable LayDSHVThiDatTotNghiep(string MaKhoaHoc)
        {
            return TN.LayDSHVThiDatTotNghiep(MaKhoaHoc);
        }
    }
}