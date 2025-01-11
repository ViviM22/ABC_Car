using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public void LoadForm(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = form as Form;

            if (f != null)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                f.Show();
            }
            else
            {
                MessageBox.Show("The object passed is not a Form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            LoadForm(new Dashboard());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.Show();
            this.Hide();
        }

        private void btnManageCars_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageCars());
        }

        private void btnManageCarParts_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageCarParts());
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManagerders_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageOrders());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadForm(new Reports());
        }

        private void btnManageCustomers_Click_1(object sender, EventArgs e)
        {
            LoadForm(new ManageCustomers());
        }
    }
}
