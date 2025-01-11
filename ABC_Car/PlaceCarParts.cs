using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ABC_Car
{
    public partial class PlaceCarParts : Form
    {
        public PlaceCarParts()
        {
            InitializeComponent();
            cmbMethod.SelectedIndexChanged += cmbMethod_SelectedIndexChanged;
        }
        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        // Public properties to access the text boxes and other controls
        public string PartID
        {
            get { return txtPartID.Text; }
            set { txtPartID.Text = value; }
        }

        public string Category
        {
            get { return txtCategory.Text; }
            set { txtCategory.Text = value; }
        }

        public string PartName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        public string CarModel
        {
            get { return txtCarModel.Text; }
            set { txtCarModel.Text = value; }
        }
        public string Price
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }
        public Image PartImage
        {
            get { return picPartImage.Image; }
            set { picPartImage.Image = value; }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            
            
        }

        private void PlaceCarParts_Load(object sender, EventArgs e)
        {
            
        }

        private void CalculateTotal()
        {
            decimal price;
            int quantity;
            decimal total;

            // Retrieve the price from txtPrice
            if (decimal.TryParse(txtPrice.Text, out price))
            {
                // Retrieve the selected quantity from cmbQuantity
                if (cmbQuantity.SelectedItem != null && int.TryParse(cmbQuantity.SelectedItem.ToString(), out quantity))
                {
                    // Calculate the total
                    total = price * quantity;

                    // Update txtTotal with the calculated value (without currency symbol)
                    txtTotal.Text = total.ToString("F2"); // Format with 2 decimal places
                }
                else
                {
                    txtTotal.Text = string.Empty; // Clear the text box if quantity is not selected
                }
            }
            else
            {
                txtTotal.Text = string.Empty; // Clear the text box if price is invalid
            }
        }

        private void cmbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Log for debugging
            Debug.WriteLine("cmbQuantity_SelectedIndexChanged triggered");

            // Calculate total based on current selection
            CalculateTotal();

            // Check if a valid quantity is selected
            if (cmbQuantity.SelectedItem != null)
            {
                if (int.TryParse(cmbQuantity.SelectedItem.ToString(), out int selectedQuantity))
                {
                    // Fetch available quantity from database
                    int availableQuantity = FetchAvailableQuantity();

                    if (availableQuantity < 0)
                    {
                        // If there's an error fetching data, skip further logic
                        return;
                    }

                    // Check if selected quantity is available
                    if (selectedQuantity > availableQuantity)
                    {
                        MessageBox.Show("Can't place order. The selected quantity exceeds the available stock.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbQuantity.SelectedIndex = -1; // Reset ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Selected quantity is available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Proceed with order logic
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid quantity.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private int FetchAvailableQuantity()
        {
            int availableQuantity = -1; // Default error value
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";
            string query = "SELECT StockQuantity FROM CarParts WHERE PartID = @PartID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PartID", txtPartID.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out availableQuantity))
                        {
                            return availableQuantity;
                        }
                        else
                        {
                            MessageBox.Show("Part not found. Please check the Part ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1; // Return error value
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching the quantity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Return error value
                }
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void ClearFields()
        {
            // Clear text boxes
            txtCustomerID.Text = string.Empty;
            txtPartID.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCarModel.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtCardNo.Text = string.Empty; // Clear card number if visible

            // Reset combo boxes
            cmbQuantity.SelectedIndex = -1; // Reset to no selection
            cmbMethod.SelectedIndex = -1; // Reset to no selection

            // Clear or reset other controls if necessary
            picPartImage.Image = null; // Clear image

            // Additional fields or controls to reset
            // lblNo.Visible = false; // Hide label if it was previously visible
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
