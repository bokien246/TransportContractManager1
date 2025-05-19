using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class LoaiHangDAO
    {
        public static List<LoaiHang> GetAll()
        {
            var list = new List<LoaiHang>();
            string query = "SELECT MaLoaiHang, ten_loai_hang FROM dm_loaihang";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LoaiHang
                        {
                            MaLoaiHang = reader["MaLoaiHang"].ToString(),
                            TenLoaiHang = reader["ten_loai_hang"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
