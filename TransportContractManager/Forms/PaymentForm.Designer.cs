namespace TransportContractManager.Forms
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaHDon;
        private System.Windows.Forms.TextBox txtMaHDon;
        private System.Windows.Forms.Label lblMaVC;
        private System.Windows.Forms.ComboBox cbVanChuyen;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.ComboBox cbPTTT;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtLinkTaiLieu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvPayments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblMaHDon = new Label();
            txtMaHDon = new TextBox();
            lblMaVC = new Label();
            cbVanChuyen = new ComboBox();
            lblPTTT = new Label();
            cbPTTT = new ComboBox();
            lblLink = new Label();
            txtLinkTaiLieu = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvPayments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // lblMaHDon
            // 
            lblMaHDon.AutoSize = true;
            lblMaHDon.Location = new Point(30, 20);
            lblMaHDon.Name = "lblMaHDon";
            lblMaHDon.Size = new Size(92, 20);
            lblMaHDon.TabIndex = 0;
            lblMaHDon.Text = "Mã hóa đơn:";
            // 
            // txtMaHDon
            // 
            txtMaHDon.Location = new Point(150, 17);
            txtMaHDon.Name = "txtMaHDon";
            txtMaHDon.Size = new Size(715, 27);
            txtMaHDon.TabIndex = 1;
            // 
            // lblMaVC
            // 
            lblMaVC.AutoSize = true;
            lblMaVC.Location = new Point(30, 55);
            lblMaVC.Name = "lblMaVC";
            lblMaVC.Size = new Size(110, 20);
            lblMaVC.TabIndex = 2;
            lblMaVC.Text = "Mã vận chuyển:";
            // 
            // cbVanChuyen
            // 
            cbVanChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVanChuyen.Location = new Point(150, 52);
            cbVanChuyen.Name = "cbVanChuyen";
            cbVanChuyen.Size = new Size(715, 28);
            cbVanChuyen.TabIndex = 3;
            // 
            // lblPTTT
            // 
            lblPTTT.AutoSize = true;
            lblPTTT.Location = new Point(30, 90);
            lblPTTT.Name = "lblPTTT";
            lblPTTT.Size = new Size(116, 20);
            lblPTTT.TabIndex = 4;
            lblPTTT.Text = "Phương thức TT:";
            // 
            // cbPTTT
            // 
            cbPTTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPTTT.Location = new Point(150, 87);
            cbPTTT.Name = "cbPTTT";
            cbPTTT.Size = new Size(715, 28);
            cbPTTT.TabIndex = 5;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(30, 125);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(87, 20);
            lblLink.TabIndex = 6;
            lblLink.Text = "Link tài liệu:";
            // 
            // txtLinkTaiLieu
            // 
            txtLinkTaiLieu.Location = new Point(150, 122);
            txtLinkTaiLieu.Name = "txtLinkTaiLieu";
            txtLinkTaiLieu.Size = new Size(715, 27);
            txtLinkTaiLieu.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(150, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(230, 160);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 34);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(390, 160);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Xóa trắng";
            btnClear.Click += btnClear_Click;
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeight = 29;
            dgvPayments.Location = new Point(30, 200);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(835, 295);
            dgvPayments.TabIndex = 12;
            dgvPayments.CellClick += dgvPayments_CellClick;
            // 
            // PaymentForm
            // 
            ClientSize = new Size(999, 529);
            Controls.Add(lblMaHDon);
            Controls.Add(txtMaHDon);
            Controls.Add(lblMaVC);
            Controls.Add(cbVanChuyen);
            Controls.Add(lblPTTT);
            Controls.Add(cbPTTT);
            Controls.Add(lblLink);
            Controls.Add(txtLinkTaiLieu);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvPayments);
            Name = "PaymentForm";
            Text = "Quản lý thanh toán";
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
