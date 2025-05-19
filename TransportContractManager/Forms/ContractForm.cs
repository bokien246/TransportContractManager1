using System;
using System.Windows.Forms;
using TransportContractManager.Models;
using TransportContractManager.DataAccess;
using System.Collections.Generic;

namespace TransportContractManager.Forms
{
    public partial class ContractForm : Form
    {
        private string selectedMaHD = null;

        public ContractForm()
        {
            InitializeComponent();
            LoadKhachHang();
            LoadPTTT();
            LoadContractData();
        }

        private void LoadKhachHang()
        {
            var list = CustomerDAO.GetAll();
            cbKhachHang.DataSource = list;
            cbKhachHang.DisplayMember = "TenCty";
            cbKhachHang.ValueMember = "MaKH";
        }

        private void LoadPTTT()
        {
            var list = PTTTDAO.GetAll(); // Giả định đã có DAO phương thức thanh toán
            cbPTTT.DataSource = list;
            cbPTTT.DisplayMember = "TenPTTT";
            cbPTTT.ValueMember = "MaPTTT";
        }

        private void LoadContractData()
        {
            dgvContracts.DataSource = ContractDAO.GetAll();
            dgvContracts.ClearSelection();
            ClearInput();
        }

        private void ClearInput()
        {
            txtMaHD.Text = "";
            cbKhachHang.SelectedIndex = -1;
            dtpNgayUpload.Value = DateTime.Now;
            dtpNgayHL.Value = DateTime.Now;
            dtpNgayHetHL.Value = DateTime.Now;
            cbPTTT.SelectedIndex = -1;
            txtLinkTaiLieu.Text = "";
            selectedMaHD = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hợp đồng!", "Thông báo");
                return;
            }

            var contract = new Contract
            {
                MaHD = txtMaHD.Text.Trim(),
                MaKH = cbKhachHang.SelectedValue?.ToString(),
                NgayUpload = dtpNgayUpload.Value,
                NgayHieuLuc = dtpNgayHL.Value,
                NgayHetHieuLuc = dtpNgayHetHL.Value,
                MaPTTT = cbPTTT.SelectedValue?.ToString(),
                LinkTaiLieu = txtLinkTaiLieu.Text.Trim()
            };

            if (ContractDAO.Insert(contract))
            {
                MessageBox.Show("Đã thêm hợp đồng!", "Thông báo");
                LoadContractData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaHD))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng để sửa.", "Thông báo");
                return;
            }

            var contract = new Contract
            {
                MaHD = selectedMaHD,
                MaKH = cbKhachHang.SelectedValue?.ToString(),
                NgayUpload = dtpNgayUpload.Value,
                NgayHieuLuc = dtpNgayHL.Value,
                NgayHetHieuLuc = dtpNgayHetHL.Value,
                MaPTTT = cbPTTT.SelectedValue?.ToString(),
                LinkTaiLieu = txtLinkTaiLieu.Text.Trim()
            };

            if (ContractDAO.Update(contract))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                LoadContractData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaHD))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng để xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ContractDAO.Delete(selectedMaHD))
                {
                    MessageBox.Show("Đã xóa!", "Thông báo");
                    LoadContractData();
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

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvContracts.Rows.Count > 0)
            {
                DataGridViewRow row = dgvContracts.Rows[e.RowIndex];

                selectedMaHD = row.Cells["MaHD"].Value?.ToString();
                txtMaHD.Text = selectedMaHD;
                cbKhachHang.SelectedValue = row.Cells["MaKH"].Value?.ToString();
                dtpNgayUpload.Value = Convert.ToDateTime(row.Cells["NgayUpload"].Value);
                dtpNgayHL.Value = Convert.ToDateTime(row.Cells["NgayHieuLuc"].Value);
                dtpNgayHetHL.Value = Convert.ToDateTime(row.Cells["NgayHetHieuLuc"].Value);
                cbPTTT.SelectedValue = row.Cells["MaPTTT"].Value?.ToString();
                txtLinkTaiLieu.Text = row.Cells["LinkTaiLieu"].Value?.ToString();
            }
        }
    }
}
