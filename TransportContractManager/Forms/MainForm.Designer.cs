namespace TransportContractManager.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            btnCustomers = new Button();
            btnContracts = new Button();
            btnVehicles = new Button();
            btnPayments = new Button();
            btnUsers = new Button();
            btnReports = new Button();
            panel1 = new Panel();
            Tile = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCustomers);
            groupBox1.Controls.Add(btnContracts);
            groupBox1.Controls.Add(btnVehicles);
            groupBox1.Controls.Add(btnPayments);
            groupBox1.Controls.Add(btnUsers);
            groupBox1.Controls.Add(btnReports);
            groupBox1.Location = new Point(208, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 289);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(17, 25);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(150, 106);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "Khách hàng";
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnContracts
            // 
            btnContracts.Location = new Point(252, 25);
            btnContracts.Name = "btnContracts";
            btnContracts.Size = new Size(150, 106);
            btnContracts.TabIndex = 7;
            btnContracts.Text = "Hợp Đồng";
            btnContracts.Click += btnContracts_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Location = new Point(495, 26);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(150, 105);
            btnVehicles.TabIndex = 8;
            btnVehicles.Text = "Vận Chuyển";
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnPayments
            // 
            btnPayments.Location = new Point(17, 157);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(150, 106);
            btnPayments.TabIndex = 9;
            btnPayments.Text = "Hóa Đơn";
            btnPayments.Click += btnPayments_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(252, 157);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(150, 106);
            btnUsers.TabIndex = 10;
            btnUsers.Text = "Người dùng (Admin)";
            btnUsers.Click += btnUsers_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(495, 157);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(150, 106);
            btnReports.TabIndex = 11;
            btnReports.Text = "Báo cáo";
            btnReports.Click += btnReports_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(Tile);
            panel1.Location = new Point(208, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 80);
            panel1.TabIndex = 8;
            // 
            // Tile
            // 
            Tile.AutoSize = true;
            Tile.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tile.ForeColor = Color.White;
            Tile.Location = new Point(3, 17);
            Tile.Name = "Tile";
            Tile.Size = new Size(627, 45);
            Tile.TabIndex = 0;
            Tile.Text = "Quản Lý Khách Hàng và Hợp Đồng";
            Tile.Click += Tile_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnLogout);
            panel2.Location = new Point(-1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 364);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 165);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DeepSkyBlue;
            btnLogout.Location = new Point(27, 300);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 48);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MainForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(947, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chính";
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private GroupBox groupBox1;
        private Button btnCustomers;
        private Button btnContracts;
        private Button btnVehicles;
        private Button btnPayments;
        private Button btnUsers;
        private Button btnReports;
        private Panel panel1;
        private Label Tile;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnLogout;
    }
}
