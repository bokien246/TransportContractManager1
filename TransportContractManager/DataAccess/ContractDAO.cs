using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class ContractDAO
    {
        public static List<Contract> GetAll()
        {
            List<Contract> list = new List<Contract>();
            string query = @"
                SELECT h.*, k.ten_cty AS TenKhachHang
                FROM ql_hopdong h
                JOIN ql_khachhang k ON h.MaKH = k.MaKH";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Contract
                        {
                            MaHD = reader["MaHD"].ToString(),
                            MaKH = reader["MaKH"].ToString(),
                            NgayUpload = Convert.ToDateTime(reader["ngay_upload"]),
                            NgayHieuLuc = Convert.ToDateTime(reader["ngay_hieu_luc"]),
                            NgayHetHieuLuc = Convert.ToDateTime(reader["ngay_het_hieu_luc"]),
                            MaPTTT = reader["MaPTTT"].ToString(),
                            LinkTaiLieu = reader["link_tai_lieu"].ToString(),
                            TenKhachHang = reader["TenKhachHang"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public static bool Insert(Contract contract)
        {
            string query = @"INSERT INTO ql_hopdong 
                (MaHD, MaKH, ngay_upload, ngay_hieu_luc, ngay_het_hieu_luc, MaPTTT, link_tai_lieu)
                VALUES (@MaHD, @MaKH, @NgayUpload, @NgayHieuLuc, @NgayHetHieuLuc, @MaPTTT, @LinkTaiLieu)";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", contract.MaHD);
                    cmd.Parameters.AddWithValue("@MaKH", contract.MaKH);
                    cmd.Parameters.AddWithValue("@NgayUpload", contract.NgayUpload);
                    cmd.Parameters.AddWithValue("@NgayHieuLuc", contract.NgayHieuLuc);
                    cmd.Parameters.AddWithValue("@NgayHetHieuLuc", contract.NgayHetHieuLuc);
                    cmd.Parameters.AddWithValue("@MaPTTT", contract.MaPTTT);
                    cmd.Parameters.AddWithValue("@LinkTaiLieu", contract.LinkTaiLieu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Update(Contract contract)
        {
            string query = @"UPDATE ql_hopdong SET 
                MaKH = @MaKH,
                ngay_upload = @NgayUpload,
                ngay_hieu_luc = @NgayHieuLuc,
                ngay_het_hieu_luc = @NgayHetHieuLuc,
                MaPTTT = @MaPTTT,
                link_tai_lieu = @LinkTaiLieu
                WHERE MaHD = @MaHD";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", contract.MaHD);
                    cmd.Parameters.AddWithValue("@MaKH", contract.MaKH);
                    cmd.Parameters.AddWithValue("@NgayUpload", contract.NgayUpload);
                    cmd.Parameters.AddWithValue("@NgayHieuLuc", contract.NgayHieuLuc);
                    cmd.Parameters.AddWithValue("@NgayHetHieuLuc", contract.NgayHetHieuLuc);
                    cmd.Parameters.AddWithValue("@MaPTTT", contract.MaPTTT);
                    cmd.Parameters.AddWithValue("@LinkTaiLieu", contract.LinkTaiLieu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Delete(string maHD)
        {
            string query = "DELETE FROM ql_hopdong WHERE MaHD = @MaHD";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static Contract GetById(string maHD)
        {
            string query = "SELECT * FROM ql_hopdong WHERE MaHD = @MaHD";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Contract
                            {
                                MaHD = reader["MaHD"].ToString(),
                                MaKH = reader["MaKH"].ToString(),
                                NgayUpload = Convert.ToDateTime(reader["ngay_upload"]),
                                NgayHieuLuc = Convert.ToDateTime(reader["ngay_hieu_luc"]),
                                NgayHetHieuLuc = Convert.ToDateTime(reader["ngay_het_hieu_luc"]),
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
