﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=sinavsistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
