using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class InvoiceDAO
    {
        public static List<Invoice> GetAll()
        {
            List<Invoice> list = new List<Invoice>();
            string query = "SELECT * FROM ql_hoadon";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Invoice
                        {
                            MaHDon = reader["MaHDon"].ToString(),
                            MaVC = reader["MaVC"].ToString(),
                            MaPTTT = reader["MaPTTT"].ToString(),
                            LinkTaiLieu = reader["link_tai_lieu"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public static bool Insert(Invoice invoice)
        {
            string query = @"INSERT INTO ql_hoadon 
                (MaHDon, MaVC, MaPTTT, link_tai_lieu)
                VALUES (@MaHDon, @MaVC, @MaPTTT, @Link)";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHDon", invoice.MaHDon);
                    cmd.Parameters.AddWithValue("@MaVC", invoice.MaVC);
                    cmd.Parameters.AddWithValue("@MaPTTT", invoice.MaPTTT);
                    cmd.Parameters.AddWithValue("@Link", invoice.LinkTaiLieu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Update(Invoice invoice)
        {
            string query = @"UPDATE ql_hoadon SET 
                MaVC = @MaVC,
                MaPTTT = @MaPTTT,
                link_tai_lieu = @Link
                WHERE MaHDon = @MaHDon";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHDon", invoice.MaHDon);
                    cmd.Parameters.AddWithValue("@MaVC", invoice.MaVC);
                    cmd.Parameters.AddWithValue("@MaPTTT", invoice.MaPTTT);
                    cmd.Parameters.AddWithValue("@Link", invoice.LinkTaiLieu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Delete(string maHDon)
        {
            string query = "DELETE FROM ql_hoadon WHERE MaHDon = @MaHDon";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHDon", maHDon);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static Invoice GetById(string maHDon)
        {
            string query = "SELECT * FROM ql_hoadon WHERE MaHDon = @MaHDon";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHDon", maHDon);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Invoice
                            {
                                MaHDon = reader["MaHDon"].ToString(),
                                MaVC = reader["MaVC"].ToString(),
                                MaPTTT = reader["MaPTTT"].ToString(),
                                LinkTaiLieu = reader["link_tai_lieu"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
