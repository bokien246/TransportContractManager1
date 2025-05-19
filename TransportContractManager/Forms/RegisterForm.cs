using System;
using System.Windows.Forms;
using TransportContractManager.Models;
using TransportContractManager.DataAccess;
using TransportContractManager.Utilities;

namespace TransportContractManager.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()

        {
            InitializeComponent();
            // Thiết lập văn bản mặc định cho txtFullName
            txtFullName.Text = "Nhập tên của bạn";
            txtFullName.ForeColor = System.Drawing.Color.Black;
            // Thiết lập văn bản mặc định cho txtUsername
            txtUsername.Text = "Nhập tên đăng nhập";
            txtUsername.ForeColor = System.Drawing.Color.Black;
            // Thiết lập văn bản mặc định cho txtPassword
            txtPassword.Text = "Nhập mật khẩu";
            txtPassword.ForeColor = System.Drawing.Color.Black;
            // Thiết lập văn bản mặc định cho txtConfirmPassword
            txtConfirmPassword.Text = "Nhập lại mật khẩu";
            txtConfirmPassword.ForeColor = System.Drawing.Color.Black;


            // Gắn sự kiện cho Enter và Leave
            txtFullName.Enter += txtFullName_Enter;
            txtFullName.Leave += txtFullName_Leave;
            txtFullName.MouseDown += xtFullName_MouseDown;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            txtUsername.MouseDown += txtUsername_Down;



            this.ActiveControl = btnRegister;
            this.MaximizeBox = false;
            this.MinimizeBox = false; // nếu muốn ẩn nút thu nhỏ


        }
        private bool isPlaceholderFullName = true;
        private bool isPlaceholderUsername = true;
        private bool isPlaceholderPassword = true;
        private bool isPlaceholderConfirmPassword = true;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kiểm tra kết nối CSDL
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Kết nối CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến CSDL.\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy dữ liệu người dùng nhập
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordHash = HashHelper.ComputeSha256Hash(password);

            var newUser = new User
            {
                FullName = fullName,
                Username = username,
                PasswordHash = passwordHash,
                Role = "User",
                Email = "",
                Phone = ""
            };

            bool success = UserDAO.Register(newUser);

            if (success)
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại hoặc lỗi hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderFullName)
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = System.Drawing.Color.Black;
                isPlaceholderFullName = false;
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                txtFullName.Text = "Nhập tên của bạn";
                txtFullName.ForeColor = System.Drawing.Color.Black;
                isPlaceholderFullName = true;
            }
        }

        private void xtFullName_MouseDown(object sender, MouseEventArgs e)
        {
            // Khi nhấn chuột, nếu đang ở trạng thái placeholder thì di chuyển con trỏ về cuối để không bị bôi đen
            if (isPlaceholderFullName)
            {
                txtFullName.SelectionStart = 0;
                txtFullName.SelectionLength = 0;
            }
        }

        private void txtUsername_Down(object sender, MouseEventArgs e)
        {
            if (isPlaceholderUsername)
            {
                txtUsername.SelectionStart = 0;
                txtUsername.SelectionLength = 0;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderUsername)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.Black;
                isPlaceholderUsername = false;
            }

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Nhập tên đăng nhập";
                txtUsername.ForeColor = System.Drawing.Color.Black;
                isPlaceholderUsername = true;
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Nhập mật khẩu";
                txtPassword.ForeColor = System.Drawing.Color.Black;
                txtPassword.UseSystemPasswordChar = false;
                isPlaceholderPassword = true;
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderPassword)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
                txtPassword.UseSystemPasswordChar = true;
                isPlaceholderPassword = false;
            }
        }

        private void txtPassword_Down(object sender, MouseEventArgs e)
        {
            if (isPlaceholderPassword)
            {
                txtPassword.SelectionStart = 0;
                txtPassword.SelectionLength = 0;
            }
        }

        private void txtConfirmPassword_Down(object sender, MouseEventArgs e)
        {
            if (isPlaceholderConfirmPassword)
            {
                txtConfirmPassword.SelectionStart = 0;
                txtConfirmPassword.SelectionLength = 0;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Text = "Nhập lại mật khẩu";
                txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
                txtConfirmPassword.UseSystemPasswordChar = false;
                isPlaceholderConfirmPassword = true;
            }

        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderConfirmPassword)
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
                txtConfirmPassword.UseSystemPasswordChar = true;
                isPlaceholderConfirmPassword = false;
            }

        }
    }
}
