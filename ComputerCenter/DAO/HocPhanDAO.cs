﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ComputerCenter.DAO
{
    public class HocPhanDAO
    {
        static string path = @"Data Source=TRANG\SQLSERVER2008;Initial Catalog=ComputerCentre;Integrated Security=True";
        public DataTable LayDSNhomHocPhan(string MaKhoaHoc)
        {
            SqlConnection conn = new SqlConnection(path);
            var cmd = string.Format("SELECT*FROM NHOMHOCPHAN WHERE MAKHOAHOC = {0}", MaKhoaHoc);
            var dr = new SqlDataAdapter(cmd, conn);
            var tableHocPhan = new DataTable();
            dr.Fill(tableHocPhan);
            dr.Dispose();

            return tableHocPhan;
        }

    }
}