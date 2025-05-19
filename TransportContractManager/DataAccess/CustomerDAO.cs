using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class CustomerDAO
    {
        public static List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();
            string query = "SELECT * FROM ql_khachhang";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Customer
                        {
                            MaKH = reader["MaKH"].ToString(),
                            TenCty = reader["ten_cty"].ToString(),
                            NguoiDaiDien = reader["nguoi_dai_dien"].ToString(),
                            ChucVu = reader["chuc_vu_dai_dien"].ToString(),
                            MaLoaiKH = reader["MaLoaiKH"].ToString(),
                            MaSoThue = reader["ma_so_thue"].ToString(),
                            DiaChi = reader["dia_chi"].ToString(),
                            SDT = reader["sdt"].ToString(),
                            STK = reader["stk"].ToString(),
                            NganHang = reader["ngan_hang"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public static bool Insert(Customer customer)
        {
            string query = @"INSERT INTO ql_khachhang 
                (MaKH, ten_cty, nguoi_dai_dien, chuc_vu_dai_dien, MaLoaiKH, ma_so_thue, dia_chi, sdt, stk, ngan_hang)
                VALUES (@MaKH, @TenCty, @NguoiDaiDien, @ChucVu, @MaLoaiKH, @MaSoThue, @DiaChi, @SDT, @STK, @NganHang)";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", customer.MaKH);
                    cmd.Parameters.AddWithValue("@TenCty", customer.TenCty);
                    cmd.Parameters.AddWithValue("@NguoiDaiDien", customer.NguoiDaiDien);
                    cmd.Parameters.AddWithValue("@ChucVu", customer.ChucVu);
                    cmd.Parameters.AddWithValue("@MaLoaiKH", customer.MaLoaiKH);
                    cmd.Parameters.AddWithValue("@MaSoThue", customer.MaSoThue);
                    cmd.Parameters.AddWithValue("@DiaChi", customer.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", customer.SDT);
                    cmd.Parameters.AddWithValue("@STK", customer.STK);
                    cmd.Parameters.AddWithValue("@NganHang", customer.NganHang);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Update(Customer customer)
        {
            string query = @"UPDATE ql_khachhang SET 
                ten_cty = @TenCty,
                nguoi_dai_dien = @NguoiDaiDien,
                chuc_vu_dai_dien = @ChucVu,
                MaLoaiKH = @MaLoaiKH,
                ma_so_thue = @MaSoThue,
                dia_chi = @DiaChi,
                sdt = @SDT,
                stk = @STK,
                ngan_hang = @NganHang
                WHERE MaKH = @MaKH";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", customer.MaKH);
                    cmd.Parameters.AddWithValue("@TenCty", customer.TenCty);
                    cmd.Parameters.AddWithValue("@NguoiDaiDien", customer.NguoiDaiDien);
                    cmd.Parameters.AddWithValue("@ChucVu", customer.ChucVu);
                    cmd.Parameters.AddWithValue("@MaLoaiKH", customer.MaLoaiKH);
                    cmd.Parameters.AddWithValue("@MaSoThue", customer.MaSoThue);
                    cmd.Parameters.AddWithValue("@DiaChi", customer.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", customer.SDT);
                    cmd.Parameters.AddWithValue("@STK", customer.STK);
                    cmd.Parameters.AddWithValue("@NganHang", customer.NganHang);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Delete(string maKH)
        {
            string query = "DELETE FROM ql_khachhang WHERE MaKH = @MaKH";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static Customer GetById(string maKH)
        {
            string query = "SELECT * FROM ql_khachhang WHERE MaKH = @MaKH";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                MaKH = reader["MaKH"].ToString(),
                                TenCty = reader["ten_cty"].ToString(),
                                NguoiDaiDien = reader["nguoi_dai_dien"].ToString(),
                                ChucVu = reader["chuc_vu_dai_dien"].ToString(),
                                MaLoaiKH = reader["MaLoaiKH"].ToString(),
                                MaSoThue = reader["ma_so_thue"].ToString(),
                                DiaChi = reader["dia_chi"].ToString(),
                                SDT = reader["sdt"].ToString(),
                                STK = reader["stk"].ToString(),
                                NganHang = reader["ngan_hang"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
