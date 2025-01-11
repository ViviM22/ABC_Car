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
    public partial class Customer : Form
    {
        private string customerName;
        private string customerId;

        // Constructor to accept parameters
        public Customer(string customerName, string customerId)
        {
            InitializeComponent();
            this.customerName = customerName;
            this.customerId = customerId;

            // Hook up the Load event handler
            this.Load += new System.EventHandler(this.panelWelcome_Load);
        }
        public void LoadForm(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);  // Remove any existing controls in the panel

            Form f = form as Form;  // Cast the object to a Form

            if (f != null)
            {
                f.TopLevel = false;  
                f.Dock = DockStyle.Fill;  
                this.mainPanel.Controls.Add(f);  
                this.mainPanel.Tag = f;  
                f.Show();  // Display the form
            }
            else
            {
                MessageBox.Show("The object passed is not a Form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new MyProfile());

        }

        private void btnOrderCar_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderCar());
        }

        private void btnOrderCarParts_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderCarParts());
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUsername.Text, out int customerId))
            {
                LoadForm(new OrderStatus(customerId)); // Pass the customerId to the OrderStatus form
            }
            else
            {
                MessageBox.Show("Invalid CustomerID. Please check the input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panelWelcome_Load(object sender, EventArgs e)
        {
            // Set the values in the text boxes
            txtUsername.Text = customerName;
            txtUserID.Text = customerId;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form2 cust = new Form2();
            cust.Show();
            this.Hide();
        }
    }
}
