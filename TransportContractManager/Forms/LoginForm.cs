using System;
using System.Windows.Forms;
using TransportContractManager.DataAccess;
using TransportContractManager.Models;
using TransportContractManager.Utilities;

namespace TransportContractManager.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false; // nếu muốn ẩn nút thu nhỏ

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Băm mật khẩu
            string passwordHash = HashHelper.ComputeSha256Hash(password);

            // Gọi DAO để kiểm tra
            User? user = UserDAO.Login(username, passwordHash);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở MainForm (nếu có)
                this.Hide();
                MainForm mainForm = new MainForm(); // Giả sử bạn có MainForm
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
