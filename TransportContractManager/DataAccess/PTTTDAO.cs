using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class PTTTDAO
    {
        public static List<PTTT> GetAll()
        {
            List<PTTT> list = new List<PTTT>();
            string query = "SELECT MaPTTT, ten_phuong_thuc FROM dm_phuongthucthanhtoan";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PTTT
                        {
                            MaPTTT = reader["MaPTTT"].ToString(),
                            TenPTTT = reader["ten_phuong_thuc"].ToString()
                        });
                    }
                }
            }

            return list;
        }
    }
}
