using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportContractManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false; // nếu muốn ẩn nút thu nhỏ
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            new ContractForm().ShowDialog();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            new VehicleForm().ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            new PaymentForm().ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Nếu bạn muốn giới hạn quyền Admin:
            // if (loggedInUser.Role == "Admin")
            new UserForm().ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new ReportForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart(); // Quay về LoginForm
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Tile_Click(object sender, EventArgs e)
        {

        }
    }
}
