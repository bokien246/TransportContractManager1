using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransportContractManager.Forms
{
    partial class VehicleForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtMaVC;
        private ComboBox cbMaHD;
        private TextBox txtBienSoXe;
        private TextBox txtTenHang;
        private ComboBox cbLoaiHang;
        private TextBox txtDiemNhan;
        private DateTimePicker dtpNhan;
        private TextBox txtDiemTra;
        private DateTimePicker dtpTra;
        private ComboBox cbDonViDo;
        private TextBox txtGhiChu;
        private TextBox txtTrongLuong;
        private TextBox txtTLXe;
        private TextBox txtKhoiLuongBi;
        private TextBox txtTongTL;
        private TextBox txtDonGia;
        private TextBox txtThanhTien;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvTransport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMaVC = new TextBox();
            this.cbMaHD = new ComboBox();
            this.txtBienSoXe = new TextBox();
            this.txtTenHang = new TextBox();
            this.cbLoaiHang = new ComboBox();
            this.txtDiemNhan = new TextBox();
            this.dtpNhan = new DateTimePicker();
            this.txtDiemTra = new TextBox();
            this.dtpTra = new DateTimePicker();
            this.cbDonViDo = new ComboBox();
            this.txtGhiChu = new TextBox();
            this.txtTrongLuong = new TextBox();
            this.txtTLXe = new TextBox();
            this.txtKhoiLuongBi = new TextBox();
            this.txtTongTL = new TextBox();
            this.txtDonGia = new TextBox();
            this.txtThanhTien = new TextBox();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.dgvTransport = new DataGridView();

            this.SuspendLayout();

            int labelX = 30, controlX = 160, top = 20, spacingY = 30;
            int width = 180;

            AddLabel("Mã VC:", labelX, top);
            txtMaVC.Location = new Point(controlX, top);
            txtMaVC.Size = new Size(width, 22);
            this.Controls.Add(txtMaVC);
            top += spacingY;

            AddLabel("Mã HĐ:", labelX, top);
            cbMaHD.Location = new Point(controlX, top);
            cbMaHD.Size = new Size(width, 22);
            this.Controls.Add(cbMaHD);
            top += spacingY;

            AddLabel("Biển số xe:", labelX, top);
            txtBienSoXe.Location = new Point(controlX, top);
            txtBienSoXe.Size = new Size(width, 22);
            this.Controls.Add(txtBienSoXe);
            top += spacingY;

            AddLabel("Tên hàng:", labelX, top);
            txtTenHang.Location = new Point(controlX, top);
            txtTenHang.Size = new Size(width, 22);
            this.Controls.Add(txtTenHang);
            top += spacingY;

            AddLabel("Loại hàng:", labelX, top);
            cbLoaiHang.Location = new Point(controlX, top);
            cbLoaiHang.Size = new Size(width, 22);
            this.Controls.Add(cbLoaiHang);
            top += spacingY;

            AddLabel("Điểm nhận:", labelX, top);
            txtDiemNhan.Location = new Point(controlX, top);
            txtDiemNhan.Size = new Size(width, 22);
            this.Controls.Add(txtDiemNhan);
            top += spacingY;

            AddLabel("Thời gian nhận:", labelX, top);
            dtpNhan.Location = new Point(controlX, top);
            dtpNhan.Size = new Size(width, 22);
            this.Controls.Add(dtpNhan);
            top += spacingY;

            AddLabel("Điểm trả:", labelX, top);
            txtDiemTra.Location = new Point(controlX, top);
            txtDiemTra.Size = new Size(width, 22);
            this.Controls.Add(txtDiemTra);
            top += spacingY;

            AddLabel("Thời gian trả:", labelX, top);
            dtpTra.Location = new Point(controlX, top);
            dtpTra.Size = new Size(width, 22);
            this.Controls.Add(dtpTra);
            top += spacingY;

            AddLabel("Đơn vị đo:", labelX, top);
            cbDonViDo.Location = new Point(controlX, top);
            cbDonViDo.Size = new Size(width, 22);
            this.Controls.Add(cbDonViDo);
            top += spacingY;

            AddLabel("Ghi chú:", labelX, top);
            txtGhiChu.Location = new Point(controlX, top);
            txtGhiChu.Size = new Size(width, 22);
            this.Controls.Add(txtGhiChu);
            top += spacingY;

            AddLabel("Trọng lượng:", labelX, top);
            txtTrongLuong.Location = new Point(controlX, top);
            txtTrongLuong.Size = new Size(width, 22);
            this.Controls.Add(txtTrongLuong);
            top += spacingY;

            AddLabel("TL xe:", labelX, top);
            txtTLXe.Location = new Point(controlX, top);
            txtTLXe.Size = new Size(width, 22);
            this.Controls.Add(txtTLXe);
            top += spacingY;

            AddLabel("Khối lượng bì:", labelX, top);
            txtKhoiLuongBi.Location = new Point(controlX, top);
            txtKhoiLuongBi.Size = new Size(width, 22);
            this.Controls.Add(txtKhoiLuongBi);
            top += spacingY;

            AddLabel("Tổng TL:", labelX, top);
            txtTongTL.Location = new Point(controlX, top);
            txtTongTL.Size = new Size(width, 22);
            this.Controls.Add(txtTongTL);
            top += spacingY;

            AddLabel("Đơn giá:", labelX, top);
            txtDonGia.Location = new Point(controlX, top);
            txtDonGia.Size = new Size(width, 22);
            this.Controls.Add(txtDonGia);
            top += spacingY;

            AddLabel("Thành tiền:", labelX, top);
            txtThanhTien.Location = new Point(controlX, top);
            txtThanhTien.Size = new Size(width, 22);
            this.Controls.Add(txtThanhTien);
            top += spacingY;

            btnAdd.Text = "Thêm";
            btnEdit.Text = "Sửa";
            btnDelete.Text = "Xóa";
            btnClear.Text = "Xóa trắng";
            btnAdd.Location = new Point(30, top);
            btnEdit.Location = new Point(120, top);
            btnDelete.Location = new Point(210, top);
            btnClear.Location = new Point(300, top);
            this.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete, btnClear });
            top += 40;

            dgvTransport.Location = new Point(30, top);
            dgvTransport.Size = new Size(720, 250);
            dgvTransport.ReadOnly = true;
            dgvTransport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransport.CellClick += dgvTransport_CellClick;
            this.Controls.Add(dgvTransport);

            this.Text = "Quản lý vận chuyển";
            this.ClientSize = new Size(800, top + 300);
            this.ResumeLayout(false);
        }

        private void AddLabel(string text, int x, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Location = new Point(x, y);
            lbl.Size = new Size(120, 22);
            this.Controls.Add(lbl);
        }
    }
}