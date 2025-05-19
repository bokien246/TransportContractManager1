using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class CustomerTypeDAO
    {
        public static List<CustomerType> GetAll()
        {
            List<CustomerType> list = new List<CustomerType>();
            string query = "SELECT MaLoaiKH, ten_loai_khach_hang FROM dm_loaikhachhang";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CustomerType
                        {
                            MaLoaiKH = reader["MaLoaiKH"].ToString(),
                            TenLoaiKH = reader["ten_loai_khach_hang"].ToString()
                        });
                    }
                }
            }

            return list;
        }
    }
}
