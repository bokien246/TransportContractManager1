using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TransportContractManager.Models;
using TransportContractManager.DataAccess;

namespace TransportContractManager.Forms
{
    public partial class PaymentForm : Form
    {
        private string selectedMaHDon = null;

        public PaymentForm()
        {
            InitializeComponent();
            LoadVanChuyen();
            LoadPTTT();
            LoadPaymentData();
        }

        private void LoadVanChuyen()
        {
            cbVanChuyen.DataSource = TransportDAO.GetAll();
            cbVanChuyen.DisplayMember = "MaVC";
            cbVanChuyen.ValueMember = "MaVC";
        }

        private void LoadPTTT()
        {
            cbPTTT.DataSource = PTTTDAO.GetAll();
            cbPTTT.DisplayMember = "TenPTTT";
            cbPTTT.ValueMember = "MaPTTT";
        }


        private void LoadPaymentData()
        {
            dgvPayments.DataSource = InvoiceDAO.GetAll();
            dgvPayments.ClearSelection();
            ClearInput();
        }

        private void ClearInput()
        {
            txtMaHDon.Text = "";
            cbVanChuyen.SelectedIndex = -1;
            cbPTTT.SelectedIndex = -1;
            txtLinkTaiLieu.Text = "";
            selectedMaHDon = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHDon.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo");
                return;
            }

            var invoice = new Invoice
            {
                MaHDon = txtMaHDon.Text.Trim(),
                MaVC = cbVanChuyen.SelectedValue?.ToString(),
                MaPTTT = GetSelectedPTTTValue(),
                LinkTaiLieu = txtLinkTaiLieu.Text.Trim()
            };

            if (InvoiceDAO.Insert(invoice))
            {
                MessageBox.Show("Đã thêm hóa đơn!", "Thông báo");
                LoadPaymentData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaHDon))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để sửa.", "Thông báo");
                return;
            }

            var invoice = new Invoice
            {
                MaHDon = selectedMaHDon,
                MaVC = cbVanChuyen.SelectedValue?.ToString(),
                MaPTTT = GetSelectedPTTTValue(),
                LinkTaiLieu = txtLinkTaiLieu.Text.Trim()
            };

            if (InvoiceDAO.Update(invoice))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                LoadPaymentData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaHDon))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (InvoiceDAO.Delete(selectedMaHDon))
                {
                    MessageBox.Show("Đã xóa!", "Thông báo");
                    LoadPaymentData();
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

        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPayments.Rows.Count > 0)
            {
                DataGridViewRow row = dgvPayments.Rows[e.RowIndex];
                selectedMaHDon = row.Cells["MaHDon"].Value?.ToString();
                txtMaHDon.Text = selectedMaHDon;
                cbVanChuyen.SelectedValue = row.Cells["MaVC"].Value?.ToString();
                SetSelectedPTTT(row.Cells["MaPTTT"].Value?.ToString());
                txtLinkTaiLieu.Text = row.Cells["LinkTaiLieu"].Value?.ToString();
            }
        }

        private string GetSelectedPTTTValue()
        {
            return cbPTTT.SelectedValue?.ToString();
        }


        private void SetSelectedPTTT(string maPTTT)
        {
            cbPTTT.SelectedValue = maPTTT;
        }

    }
}
