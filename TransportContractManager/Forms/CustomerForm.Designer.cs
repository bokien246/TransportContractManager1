namespace TransportContractManager.Forms
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTenCty;
        private System.Windows.Forms.Label lblNguoiDaiDien;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblLoaiKhach;
        private System.Windows.Forms.Label lblMaSoThue;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblSTK;
        private System.Windows.Forms.Label lblNganHang;

        private System.Windows.Forms.TextBox txtTenCty;
        private System.Windows.Forms.TextBox txtNguoiDaiDien;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.ComboBox cbLoaiKhach;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox txtNganHang;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvCustomers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTenCty = new Label();
            lblNguoiDaiDien = new Label();
            lblChucVu = new Label();
            lblLoaiKhach = new Label();
            lblMaSoThue = new Label();
            lblDiaChi = new Label();
            lblSDT = new Label();
            lblSTK = new Label();
            lblNganHang = new Label();
            txtTenCty = new TextBox();
            txtNguoiDaiDien = new TextBox();
            txtChucVu = new TextBox();
            cbLoaiKhach = new ComboBox();
            txtMaSoThue = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtSTK = new TextBox();
            txtNganHang = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblTenCty
            // 
            lblTenCty.Location = new Point(30, 30);
            lblTenCty.Name = "lblTenCty";
            lblTenCty.Size = new Size(94, 20);
            lblTenCty.TabIndex = 0;
            lblTenCty.Text = "Tên công ty:";
            // 
            // lblNguoiDaiDien
            // 
            lblNguoiDaiDien.Location = new Point(30, 70);
            lblNguoiDaiDien.Name = "lblNguoiDaiDien";
            lblNguoiDaiDien.Size = new Size(114, 20);
            lblNguoiDaiDien.TabIndex = 2;
            lblNguoiDaiDien.Text = "Người đại diện:";
            // 
            // lblChucVu
            // 
            lblChucVu.Location = new Point(30, 110);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(94, 20);
            lblChucVu.TabIndex = 4;
            lblChucVu.Text = "Chức vụ:";
            // 
            // lblLoaiKhach
            // 
            lblLoaiKhach.Location = new Point(30, 150);
            lblLoaiKhach.Name = "lblLoaiKhach";
            lblLoaiKhach.Size = new Size(90, 20);
            lblLoaiKhach.TabIndex = 6;
            lblLoaiKhach.Text = "Loại khách:";
            // 
            // lblMaSoThue
            // 
            lblMaSoThue.Location = new Point(646, 27);
            lblMaSoThue.Name = "lblMaSoThue";
            lblMaSoThue.Size = new Size(86, 20);
            lblMaSoThue.TabIndex = 8;
            lblMaSoThue.Text = "Mã số thuế:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(646, 67);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(86, 20);
            lblDiaChi.TabIndex = 10;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSDT
            // 
            lblSDT.Location = new Point(646, 107);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(86, 20);
            lblSDT.TabIndex = 12;
            lblSDT.Text = "SĐT:";
            // 
            // lblSTK
            // 
            lblSTK.Location = new Point(646, 147);
            lblSTK.Name = "lblSTK";
            lblSTK.Size = new Size(86, 20);
            lblSTK.TabIndex = 14;
            lblSTK.Text = "Số tài khoản:";
            // 
            // lblNganHang
            // 
            lblNganHang.Location = new Point(30, 190);
            lblNganHang.Name = "lblNganHang";
            lblNganHang.Size = new Size(90, 20);
            lblNganHang.TabIndex = 16;
            lblNganHang.Text = "Ngân hàng:";
            // 
            // txtTenCty
            // 
            txtTenCty.Location = new Point(150, 27);
            txtTenCty.Name = "txtTenCty";
            txtTenCty.Size = new Size(351, 27);
            txtTenCty.TabIndex = 1;
            // 
            // txtNguoiDaiDien
            // 
            txtNguoiDaiDien.Location = new Point(150, 67);
            txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            txtNguoiDaiDien.Size = new Size(351, 27);
            txtNguoiDaiDien.TabIndex = 3;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(150, 107);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(351, 27);
            txtChucVu.TabIndex = 5;
            // 
            // cbLoaiKhach
            // 
            cbLoaiKhach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiKhach.Location = new Point(150, 147);
            cbLoaiKhach.Name = "cbLoaiKhach";
            cbLoaiKhach.Size = new Size(351, 28);
            cbLoaiKhach.TabIndex = 7;
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.Location = new Point(738, 23);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(349, 27);
            txtMaSoThue.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(738, 63);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(349, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(738, 103);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(349, 27);
            txtSDT.TabIndex = 13;
            // 
            // txtSTK
            // 
            txtSTK.Location = new Point(738, 143);
            txtSTK.Name = "txtSTK";
            txtSTK.Size = new Size(349, 27);
            txtSTK.TabIndex = 15;
            // 
            // txtNganHang
            // 
            txtNganHang.Location = new Point(150, 187);
            txtNganHang.Name = "txtNganHang";
            txtNganHang.Size = new Size(351, 27);
            txtNganHang.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(558, 186);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 35);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(648, 186);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(83, 35);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(738, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 35);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(828, 186);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 35);
            btnClear.TabIndex = 21;
            btnClear.Text = "Làm mới";
            btnClear.Click += btnClear_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeight = 29;
            dgvCustomers.Location = new Point(30, 240);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1057, 415);
            dgvCustomers.TabIndex = 22;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // CustomerForm
            // 
            ClientSize = new Size(1099, 676);
            Controls.Add(lblTenCty);
            Controls.Add(txtTenCty);
            Controls.Add(lblNguoiDaiDien);
            Controls.Add(txtNguoiDaiDien);
            Controls.Add(lblChucVu);
            Controls.Add(txtChucVu);
            Controls.Add(lblLoaiKhach);
            Controls.Add(cbLoaiKhach);
            Controls.Add(lblMaSoThue);
            Controls.Add(txtMaSoThue);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(lblSDT);
            Controls.Add(txtSDT);
            Controls.Add(lblSTK);
            Controls.Add(txtSTK);
            Controls.Add(lblNganHang);
            Controls.Add(txtNganHang);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvCustomers);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
