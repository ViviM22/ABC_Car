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

namespace ABC_Car
{
    public partial class PlaceCar : Form
    {
        public PlaceCar()
        {
            InitializeComponent();
            cmbMethod.SelectedIndexChanged += cmbMethod_SelectedIndexChanged;

        }
        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected method is "Card"
            if (cmbMethod.SelectedItem != null)
            {
                string selectedMethod = cmbMethod.SelectedItem.ToString();

                if (selectedMethod == "Card")
                {
                    lblNo.Visible = true;
                    txtCardNo.Visible = true;
                }
                else
                {
                    lblNo.Visible = false;
                    txtCardNo.Visible = false;
                }
            }
        }

        // Public properties to access the text boxes
        public string CarID
        {
            get { return txtCarID.Text; }
            set { txtCarID.Text = value; }
        }
        public string CarModel
        {
            get { return txtCarModel.Text; }
            set { txtCarModel.Text = value; }
        }

        public string ModelYear
        {
            get { return txtModelYear.Text; }
            set { txtModelYear.Text = value; }
        }

        public string Color
        {
            get { return txtColor.Text; }
            set { txtColor.Text = value; }
        }

        public string Price
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }
        public Image CarImage
        {
            get { return picCarImage.Image; }
            set { picCarImage.Image = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

            // Get values from form controls
            int customerID = int.Parse(txtCustomerID.Text);
            int carID = int.Parse(txtCarID.Text);
            decimal totalPrice = decimal.Parse(txtPrice.Text);
            string paymentMethod = cmbMethod.SelectedItem.ToString();
            string cardNumber = txtCardNo.Text;
            string paymentStatus = "Pending";
            string status = "Pending";

            // Create the SQL query to insert the data
            string query = "INSERT INTO Orders (CustomerID, CarID, Name, Quantity, TotalPrice, PaymentMethod, CardNumber, PaymentStatus, Status) " +
               "VALUES (@CustomerID, @CarID, @Name, @Quantity, @TotalPrice, @PaymentMethod, @CardNumber, @PaymentStatus, @Status)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@CarID", carID);
                        cmd.Parameters.AddWithValue("@Name", txtCarModel.Text);
                        cmd.Parameters.AddWithValue("@Quantity", 1); // Car quantity is always 1
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@CardNumber", string.IsNullOrEmpty(cardNumber) ? (object)DBNull.Value : cardNumber);
                        cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                        cmd.Parameters.AddWithValue("@Status", status);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Show a confirmation message box if data is inserted successfully
                            MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            // Show an error message box if data insertion fails
                            MessageBox.Show("Failed to place the order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred and show an error message box
                    MessageBox.Show("An error occurred while placing the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            // Clear text fields
            txtCarID.Clear();
            txtCarModel.Clear();
            txtModelYear.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            txtCardNo.Clear(); // Clear the card number text box

            // Hide the label and card number text box if the payment method is changed
            lblNo.Visible = false;
            txtCardNo.Visible = false;

            // Reset the combo box
            cmbMethod.SelectedIndex = -1;

            // Clear the image
            picCarImage.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderCar oC = new OrderCar();
            oC.Show();
            this.Hide();
        }
    }
}
