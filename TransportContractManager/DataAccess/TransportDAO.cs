using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class TransportDAO
    {
        public static List<Transport> GetAll()
        {
            List<Transport> list = new List<Transport>();
            string query = "SELECT * FROM ql_vanchuyen";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transport
                        {
                            MaVC = reader["MaVC"].ToString(),
                            MaHD = reader["MaHD"].ToString(),
                            BienSoXe = reader["bien_so_xe"].ToString(),
                            TenHang = reader["ten_hang"].ToString(),
                            MaLoaiHang = reader["MaLoaiHang"].ToString(),
                            DiemNhan = reader["diem_nhan"].ToString(),
                            ThoiGianNhan = Convert.ToDateTime(reader["thoi_gian_nhan"]),
                            DiemTra = reader["diem_tra"].ToString(),
                            ThoiGianTra = Convert.ToDateTime(reader["thoi_gian_tra"]),
                            MaDVD = reader["MaDVD"].ToString(),
                            GhiChu = reader["ghi_chu"].ToString(),
                            TrongLuongHang = Convert.ToSingle(reader["trong_luong_hang"]),
                            TLXe = Convert.ToSingle(reader["tl_xe"]),
                            KhoiLuongBi = Convert.ToSingle(reader["khoi_luong_bi"]),
                            TLTong = Convert.ToSingle(reader["tl_tong"]),
                            DonGia = Convert.ToDecimal(reader["don_gia"]),
                            ThanhTien = Convert.ToDecimal(reader["thanh_tien"])
                        });
                    }
                }
            }
            return list;
        }

        public static bool Insert(Transport transport)
        {
            string query = @"INSERT INTO ql_vanchuyen
                (MaVC, MaHD, bien_so_xe, ten_hang, MaLoaiHang, diem_nhan, thoi_gian_nhan, diem_tra, thoi_gian_tra, MaDVD, ghi_chu, trong_luong_hang, tl_xe, khoi_luong_bi, tl_tong, don_gia, thanh_tien)
                VALUES
                (@MaVC, @MaHD, @BienSoXe, @TenHang, @MaLoaiHang, @DiemNhan, @ThoiGianNhan, @DiemTra, @ThoiGianTra, @MaDVD, @GhiChu, @TrongLuongHang, @TLXe, @KhoiLuongBi, @TLTong, @DonGia, @ThanhTien)";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaVC", transport.MaVC);
                    cmd.Parameters.AddWithValue("@MaHD", transport.MaHD);
                    cmd.Parameters.AddWithValue("@BienSoXe", transport.BienSoXe);
                    cmd.Parameters.AddWithValue("@TenHang", transport.TenHang);
                    cmd.Parameters.AddWithValue("@MaLoaiHang", transport.MaLoaiHang);
                    cmd.Parameters.AddWithValue("@DiemNhan", transport.DiemNhan);
                    cmd.Parameters.AddWithValue("@ThoiGianNhan", transport.ThoiGianNhan);
                    cmd.Parameters.AddWithValue("@DiemTra", transport.DiemTra);
                    cmd.Parameters.AddWithValue("@ThoiGianTra", transport.ThoiGianTra);
                    cmd.Parameters.AddWithValue("@MaDVD", transport.MaDVD);
                    cmd.Parameters.AddWithValue("@GhiChu", transport.GhiChu);
                    cmd.Parameters.AddWithValue("@TrongLuongHang", transport.TrongLuongHang);
                    cmd.Parameters.AddWithValue("@TLXe", transport.TLXe);
                    cmd.Parameters.AddWithValue("@KhoiLuongBi", transport.KhoiLuongBi);
                    cmd.Parameters.AddWithValue("@TLTong", transport.TLTong);
                    cmd.Parameters.AddWithValue("@DonGia", transport.DonGia);
                    cmd.Parameters.AddWithValue("@ThanhTien", transport.ThanhTien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Delete(string maVC)
        {
            string query = "DELETE FROM ql_vanchuyen WHERE MaVC = @MaVC";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaVC", maVC);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Update(Transport transport)
        {
            string query = @"UPDATE ql_vanchuyen SET
                MaHD = @MaHD,
                bien_so_xe = @BienSoXe,
                ten_hang = @TenHang,
                MaLoaiHang = @MaLoaiHang,
                diem_nhan = @DiemNhan,
                thoi_gian_nhan = @ThoiGianNhan,
                diem_tra = @DiemTra,
                thoi_gian_tra = @ThoiGianTra,
                MaDVD = @MaDVD,
                ghi_chu = @GhiChu,
                trong_luong_hang = @TrongLuongHang,
                tl_xe = @TLXe,
                khoi_luong_bi = @KhoiLuongBi,
                tl_tong = @TLTong,
                don_gia = @DonGia,
                thanh_tien = @ThanhTien
                WHERE MaVC = @MaVC";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaVC", transport.MaVC);
                    cmd.Parameters.AddWithValue("@MaHD", transport.MaHD);
                    cmd.Parameters.AddWithValue("@BienSoXe", transport.BienSoXe);
                    cmd.Parameters.AddWithValue("@TenHang", transport.TenHang);
                    cmd.Parameters.AddWithValue("@MaLoaiHang", transport.MaLoaiHang);
                    cmd.Parameters.AddWithValue("@DiemNhan", transport.DiemNhan);
                    cmd.Parameters.AddWithValue("@ThoiGianNhan", transport.ThoiGianNhan);
                    cmd.Parameters.AddWithValue("@DiemTra", transport.DiemTra);
                    cmd.Parameters.AddWithValue("@ThoiGianTra", transport.ThoiGianTra);
                    cmd.Parameters.AddWithValue("@MaDVD", transport.MaDVD);
                    cmd.Parameters.AddWithValue("@GhiChu", transport.GhiChu);
                    cmd.Parameters.AddWithValue("@TrongLuongHang", transport.TrongLuongHang);
                    cmd.Parameters.AddWithValue("@TLXe", transport.TLXe);
                    cmd.Parameters.AddWithValue("@KhoiLuongBi", transport.KhoiLuongBi);
                    cmd.Parameters.AddWithValue("@TLTong", transport.TLTong);
                    cmd.Parameters.AddWithValue("@DonGia", transport.DonGia);
                    cmd.Parameters.AddWithValue("@ThanhTien", transport.ThanhTien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
