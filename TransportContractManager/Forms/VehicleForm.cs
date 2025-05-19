using System;
using System.Windows.Forms;
using TransportContractManager.Models;
using TransportContractManager.DataAccess;

namespace TransportContractManager.Forms
{
    public partial class VehicleForm : Form
    {
        private string selectedMaVC = null;

        public VehicleForm()
        {
            InitializeComponent();
            LoadHopDong();
            LoadLoaiHang();
            LoadDonViDo();
            LoadTransportData();
        }

        private void LoadHopDong()
        {
            cbMaHD.DataSource = ContractDAO.GetAll();
            cbMaHD.DisplayMember = "MaHD";
            cbMaHD.ValueMember = "MaHD";
        }

        private void LoadLoaiHang()
        {
            cbLoaiHang.DataSource = LoaiHangDAO.GetAll();
            cbLoaiHang.DisplayMember = "TenLoaiHang";
            cbLoaiHang.ValueMember = "MaLoaiHang";
        }

        private void LoadDonViDo()
        {
            cbDonViDo.DataSource = DonViDoDAO.GetAll();
            cbDonViDo.DisplayMember = "TenDonViDo";
            cbDonViDo.ValueMember = "MaDVD";
        }

        private void LoadTransportData()
        {
            dgvTransport.DataSource = TransportDAO.GetAll();
            dgvTransport.ClearSelection();
            ClearInput();
        }

        private void ClearInput()
        {
            txtMaVC.Text = "";
            cbMaHD.SelectedIndex = -1;
            txtBienSoXe.Text = "";
            txtTenHang.Text = "";
            cbLoaiHang.SelectedIndex = -1;
            txtDiemNhan.Text = "";
            dtpNhan.Value = DateTime.Now;
            txtDiemTra.Text = "";
            dtpTra.Value = DateTime.Now;
            cbDonViDo.SelectedIndex = -1;
            txtGhiChu.Text = "";
            txtTrongLuong.Text = "";
            txtTLXe.Text = "";
            txtKhoiLuongBi.Text = "";
            txtTongTL.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            selectedMaVC = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var transport = GetTransportFromInput();
            if (TransportDAO.Insert(transport))
            {
                MessageBox.Show("Thêm vận chuyển thành công!");
                LoadTransportData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaVC))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.");
                return;
            }

            var transport = GetTransportFromInput();
            transport.MaVC = selectedMaVC;

            if (TransportDAO.Update(transport))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadTransportData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaVC))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TransportDAO.Delete(selectedMaVC))
                {
                    MessageBox.Show("Đã xóa!");
                    LoadTransportData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dgvTransport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransport.Rows[e.RowIndex];
                selectedMaVC = row.Cells["MaVC"].Value.ToString();
                txtMaVC.Text = selectedMaVC;
                cbMaHD.SelectedValue = row.Cells["MaHD"].Value.ToString();
                txtBienSoXe.Text = row.Cells["BienSoXe"].Value.ToString();
                txtTenHang.Text = row.Cells["TenHang"].Value.ToString();
                cbLoaiHang.SelectedValue = row.Cells["MaLoaiHang"].Value.ToString();
                txtDiemNhan.Text = row.Cells["DiemNhan"].Value.ToString();
                dtpNhan.Value = Convert.ToDateTime(row.Cells["ThoiGianNhan"].Value);
                txtDiemTra.Text = row.Cells["DiemTra"].Value.ToString();
                dtpTra.Value = Convert.ToDateTime(row.Cells["ThoiGianTra"].Value);
                cbDonViDo.SelectedValue = row.Cells["MaDVD"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                txtTrongLuong.Text = row.Cells["TrongLuongHang"].Value.ToString();
                txtTLXe.Text = row.Cells["TLXe"].Value.ToString();
                txtKhoiLuongBi.Text = row.Cells["KhoiLuongBi"].Value.ToString();
                txtTongTL.Text = row.Cells["TLTong"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
            }
        }

        private Transport GetTransportFromInput()
        {
            return new Transport
            {
                MaVC = txtMaVC.Text.Trim(),
                MaHD = cbMaHD.SelectedValue?.ToString(),
                BienSoXe = txtBienSoXe.Text.Trim(),
                TenHang = txtTenHang.Text.Trim(),
                MaLoaiHang = cbLoaiHang.SelectedValue?.ToString(),
                DiemNhan = txtDiemNhan.Text.Trim(),
                ThoiGianNhan = dtpNhan.Value,
                DiemTra = txtDiemTra.Text.Trim(),
                ThoiGianTra = dtpTra.Value,
                MaDVD = cbDonViDo.SelectedValue?.ToString(),
                GhiChu = txtGhiChu.Text.Trim(),
                TrongLuongHang = float.Parse(txtTrongLuong.Text),
                TLXe = float.Parse(txtTLXe.Text),
                KhoiLuongBi = float.Parse(txtKhoiLuongBi.Text),
                TLTong = float.Parse(txtTongTL.Text),
                DonGia = decimal.Parse(txtDonGia.Text),
                ThanhTien = decimal.Parse(txtThanhTien.Text)
            };
        }
    }
}
