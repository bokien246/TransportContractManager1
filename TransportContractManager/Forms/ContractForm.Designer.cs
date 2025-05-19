namespace TransportContractManager.Forms
{
    partial class ContractForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label lblNgayUpload;
        private System.Windows.Forms.DateTimePicker dtpNgayUpload;
        private System.Windows.Forms.Label lblNgayHieuLuc;
        private System.Windows.Forms.DateTimePicker dtpNgayHL;
        private System.Windows.Forms.Label lblNgayHetHieuLuc;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHL;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.ComboBox cbPTTT;
        private System.Windows.Forms.Label lblLinkTaiLieu;
        private System.Windows.Forms.TextBox txtLinkTaiLieu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvContracts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.lblNgayUpload = new System.Windows.Forms.Label();
            this.dtpNgayUpload = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHieuLuc = new System.Windows.Forms.Label();
            this.dtpNgayHL = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHetHieuLuc = new System.Windows.Forms.Label();
            this.dtpNgayHetHL = new System.Windows.Forms.DateTimePicker();
            this.lblPTTT = new System.Windows.Forms.Label();
            this.cbPTTT = new System.Windows.Forms.ComboBox();
            this.lblLinkTaiLieu = new System.Windows.Forms.Label();
            this.txtLinkTaiLieu = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvContracts = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();

            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(30, 20);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(90, 13);
            this.lblMaHD.Text = "Mã Hợp Đồng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(150, 17);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(200, 20);

            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(30, 55);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.Location = new System.Drawing.Point(150, 52);
            this.cbKhachHang.Size = new System.Drawing.Size(300, 21);

            // 
            // lblNgayUpload
            // 
            this.lblNgayUpload.AutoSize = true;
            this.lblNgayUpload.Location = new System.Drawing.Point(30, 90);
            this.lblNgayUpload.Text = "Ngày upload:";
            // 
            // dtpNgayUpload
            // 
            this.dtpNgayUpload.Location = new System.Drawing.Point(150, 87);
            this.dtpNgayUpload.Format = DateTimePickerFormat.Short;

            // 
            // lblNgayHieuLuc
            // 
            this.lblNgayHieuLuc.AutoSize = true;
            this.lblNgayHieuLuc.Location = new System.Drawing.Point(30, 125);
            this.lblNgayHieuLuc.Text = "Ngày hiệu lực:";
            // 
            // dtpNgayHL
            // 
            this.dtpNgayHL.Location = new System.Drawing.Point(150, 122);
            this.dtpNgayHL.Format = DateTimePickerFormat.Short;

            // 
            // lblNgayHetHieuLuc
            // 
            this.lblNgayHetHieuLuc.AutoSize = true;
            this.lblNgayHetHieuLuc.Location = new System.Drawing.Point(30, 160);
            this.lblNgayHetHieuLuc.Text = "Ngày hết hiệu lực:";
            // 
            // dtpNgayHetHL
            // 
            this.dtpNgayHetHL.Location = new System.Drawing.Point(150, 157);
            this.dtpNgayHetHL.Format = DateTimePickerFormat.Short;

            // 
            // lblPTTT
            // 
            this.lblPTTT.AutoSize = true;
            this.lblPTTT.Location = new System.Drawing.Point(30, 195);
            this.lblPTTT.Text = "Phương thức TT:";
            // 
            // cbPTTT
            // 
            this.cbPTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTTT.Location = new System.Drawing.Point(150, 192);
            this.cbPTTT.Size = new System.Drawing.Size(300, 21);

            // 
            // lblLinkTaiLieu
            // 
            this.lblLinkTaiLieu.AutoSize = true;
            this.lblLinkTaiLieu.Location = new System.Drawing.Point(30, 230);
            this.lblLinkTaiLieu.Text = "Link tài liệu:";
            // 
            // txtLinkTaiLieu
            // 
            this.txtLinkTaiLieu.Location = new System.Drawing.Point(150, 227);
            this.txtLinkTaiLieu.Size = new System.Drawing.Size(400, 20);

            // 
            // Buttons
            // 
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(150, 260);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Text = "Sửa";
            this.btnEdit.Location = new System.Drawing.Point(230, 260);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(310, 260);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Xóa trắng";
            this.btnClear.Location = new System.Drawing.Point(390, 260);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // dgvContracts
            // 
            this.dgvContracts.Location = new System.Drawing.Point(30, 300);
            this.dgvContracts.Size = new System.Drawing.Size(700, 200);
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellClick);

            // 
            // ContractForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.AddRange(new Control[] {
                lblMaHD, txtMaHD,
                lblKhachHang, cbKhachHang,
                lblNgayUpload, dtpNgayUpload,
                lblNgayHieuLuc, dtpNgayHL,
                lblNgayHetHieuLuc, dtpNgayHetHL,
                lblPTTT, cbPTTT,
                lblLinkTaiLieu, txtLinkTaiLieu,
                btnAdd, btnEdit, btnDelete, btnClear,
                dgvContracts
            });
            this.Name = "ContractForm";
            this.Text = "Quản lý hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
