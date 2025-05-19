using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class DonViDoDAO
    {
        public static List<DonViDo> GetAll()
        {
            var list = new List<DonViDo>();
            string query = "SELECT MaDVD, ten_don_vi_do FROM dm_donvido";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DonViDo
                        {
                            MaDVD = reader["MaDVD"].ToString(),
                            TenDonViDo = reader["ten_don_vi_do"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}
