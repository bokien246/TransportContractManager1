using System;
using Microsoft.Data.SqlClient;
using TransportContractManager.Models;

namespace TransportContractManager.DataAccess
{
    public static class UserDAO
    {
        /// <summary>
        /// Đăng ký người dùng mới
        /// </summary>
        public static bool Register(User user)
        {
            // Kiểm tra tên đăng nhập đã tồn tại
            if (IsUsernameExists(user.Username))
                return false;

            string query = "INSERT INTO Users (Username, PasswordHash, FullName, Role, Email, Phone, Id_Quyen) " +
                           "VALUES (@Username, @PasswordHash, @FullName, @Role, @Email, @Phone, @Id_Quyen)";

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@Email", user.Email ?? "");
                        cmd.Parameters.AddWithValue("@Phone", user.Phone ?? "");
                        cmd.Parameters.AddWithValue("@Id_Quyen", user.Role == "admin" ? 1 : 2);

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi hệ thống khi đăng ký: " + ex.Message); // Tùy chọn debug
                return false;
            }
        }


        /// <summary>
        /// Kiểm tra đăng nhập
        /// </summary>
        public static User? Login(string username, string passwordHash)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";

            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                                FullName = reader.GetString(reader.GetOrdinal("FullName")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone"))
                            };
                        }
                    }
                }
            }

            return null;
        }
        public static bool IsUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
