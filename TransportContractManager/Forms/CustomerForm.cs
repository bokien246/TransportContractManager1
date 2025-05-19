using System;
using System.Data;
using System.Windows.Forms;
using TransportContractManager.DataAccess;
using TransportContractManager.Models;

namespace TransportContractManager.Forms
{
    public partial class CustomerForm : Form
    {
        private string selectedCustomerId = null;

        public CustomerForm()
        {
            InitializeComponent();
            LoadLoaiKhach();
            LoadCustomerData();
        }

        private void LoadLoaiKhach()
        {
            cbLoaiKhach.DataSource = CustomerTypeDAO.GetAll();
            cbLoaiKhach.DisplayMember = "TenLoaiKH";
            cbLoaiKhach.ValueMember = "MaLoaiKH";
        }

        private void LoadCustomerData()
        {
            dgvCustomers.DataSource = CustomerDAO.GetAll();
            dgvCustomers.ClearSelection();
            ClearInput();
        }

        private void ClearInput()
        {
            txtTenCty.Text = "";
            txtNguoiDaiDien.Text = "";
            txtChucVu.Text = "";
            cbLoaiKhach.SelectedIndex = -1;
            txtMaSoThue.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSTK.Text = "";
            txtNganHang.Text = "";
            selectedCustomerId = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                MaKH = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper(), // Tạo MaKH tự động
                TenCty = txtTenCty.Text.Trim(),
                NguoiDaiDien = txtNguoiDaiDien.Text.Trim(),
                ChucVu = txtChucVu.Text.Trim(),
                MaLoaiKH = cbLoaiKhach.SelectedValue?.ToString(),
                MaSoThue = txtMaSoThue.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                STK = txtSTK.Text.Trim(),
                NganHang = txtNganHang.Text.Trim()
            };

            if (CustomerDAO.Insert(customer))
            {
                MessageBox.Show("Đã thêm khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCustomerId))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa.", "Thông báo");
                return;
            }

            var customer = new Customer
            {
                MaKH = selectedCustomerId,
                TenCty = txtTenCty.Text.Trim(),
                NguoiDaiDien = txtNguoiDaiDien.Text.Trim(),
                ChucVu = txtChucVu.Text.Trim(),
                MaLoaiKH = cbLoaiKhach.SelectedValue?.ToString(),
                MaSoThue = txtMaSoThue.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                STK = txtSTK.Text.Trim(),
                NganHang = txtNganHang.Text.Trim()
            };

            if (CustomerDAO.Update(customer))
            {
                MessageBox.Show("Đã cập nhật khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCustomerId))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CustomerDAO.Delete(selectedCustomerId))
                {
                    MessageBox.Show("Đã xóa khách hàng!", "Thông báo");
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCustomers.Rows.Count > 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                selectedCustomerId = row.Cells["MaKH"].Value?.ToString();

                txtTenCty.Text = row.Cells["TenCty"].Value?.ToString();
                txtNguoiDaiDien.Text = row.Cells["NguoiDaiDien"].Value?.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                cbLoaiKhach.SelectedValue = row.Cells["MaLoaiKH"].Value?.ToString();
                txtMaSoThue.Text = row.Cells["MaSoThue"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtSTK.Text = row.Cells["STK"].Value?.ToString();
                txtNganHang.Text = row.Cells["NganHang"].Value?.ToString();
            }
        }
    }
}
