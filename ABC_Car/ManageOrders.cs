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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Orders (CustomerID, CarID, PartID, Name, Quantity, UnitPrice, TotalPrice, OrderDate, PaymentMethod, CardNumber, PaymentStatus, Status)
            VALUES (@CustomerID, @CarID, @PartID, @Name, @Quantity, @UnitPrice, @TotalPrice, @OrderDate, @PaymentMethod, @CardNumber, @PaymentStatus, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Assign values or DBNull.Value based on the textbox content
                    cmd.Parameters.AddWithValue("@CustomerID", string.IsNullOrEmpty(txtCustomerID.Text) ? (object)DBNull.Value : txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("@CarID", string.IsNullOrEmpty(txtCarID.Text) ? (object)DBNull.Value : txtCarID.Text);
                    cmd.Parameters.AddWithValue("@PartID", string.IsNullOrEmpty(txtPartID.Text) ? (object)DBNull.Value : txtPartID.Text);
                    cmd.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(txtName.Text) ? (object)DBNull.Value : txtName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", string.IsNullOrEmpty(txtQuantity.Text) ? (object)DBNull.Value : int.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@UnitPrice", string.IsNullOrEmpty(txtUnitPrice.Text) ? (object)DBNull.Value : decimal.Parse(txtUnitPrice.Text));
                    cmd.Parameters.AddWithValue("@TotalPrice", string.IsNullOrEmpty(txtTotal.Text) ? (object)DBNull.Value : decimal.Parse(txtTotal.Text));
                    cmd.Parameters.AddWithValue("@OrderDate", string.IsNullOrEmpty(txtDate.Text) ? (object)DBNull.Value : DateTime.Parse(txtDate.Text));
                    cmd.Parameters.AddWithValue("@PaymentMethod", string.IsNullOrEmpty(txtPMe.Text) ? (object)DBNull.Value : txtPMe.Text);
                    cmd.Parameters.AddWithValue("@CardNumber", string.IsNullOrEmpty(txtCardNumber.Text) ? (object)DBNull.Value : txtCardNumber.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPS.SelectedItem == null ? (object)DBNull.Value : cmbPS.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Status", cmbOS.SelectedItem == null ? (object)DBNull.Value : cmbOS.SelectedItem.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully.");
                    ClearFields(); // Clear the fields after adding
                }
            }
        }
        private bool CarIDExists(string carID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Cars WHERE CarID = @CarID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CarID", carID);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter the OrderID to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE Orders
            SET CustomerID = @CustomerID, CarID = @CarID, PartID = @PartID, Name = @Name, 
                Quantity = @Quantity, UnitPrice = @UnitPrice, TotalPrice = @TotalPrice, 
                OrderDate = @OrderDate, PaymentMethod = @PaymentMethod, CardNumber = @CardNumber, 
                PaymentStatus = @PaymentStatus, Status = @Status
            WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", string.IsNullOrEmpty(txtCustomerID.Text) ? (object)DBNull.Value : txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("@CarID", string.IsNullOrEmpty(txtCarID.Text) ? (object)DBNull.Value : txtCarID.Text);
                    cmd.Parameters.AddWithValue("@PartID", string.IsNullOrEmpty(txtPartID.Text) ? (object)DBNull.Value : txtPartID.Text);
                    cmd.Parameters.AddWithValue("@Name", string.IsNullOrEmpty(txtName.Text) ? (object)DBNull.Value : txtName.Text);
                    cmd.Parameters.AddWithValue("@Quantity", string.IsNullOrEmpty(txtQuantity.Text) ? (object)DBNull.Value : int.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@UnitPrice", string.IsNullOrEmpty(txtUnitPrice.Text) ? (object)DBNull.Value : decimal.Parse(txtUnitPrice.Text));
                    cmd.Parameters.AddWithValue("@TotalPrice", string.IsNullOrEmpty(txtTotal.Text) ? (object)DBNull.Value : decimal.Parse(txtTotal.Text));
                    cmd.Parameters.AddWithValue("@OrderDate", string.IsNullOrEmpty(txtDate.Text) ? (object)DBNull.Value : DateTime.Parse(txtDate.Text));
                    cmd.Parameters.AddWithValue("@PaymentMethod", string.IsNullOrEmpty(txtPMe.Text) ? (object)DBNull.Value : txtPMe.Text);
                    cmd.Parameters.AddWithValue("@CardNumber", string.IsNullOrEmpty(txtCardNumber.Text) ? (object)DBNull.Value : txtCardNumber.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPS.SelectedItem == null ? (object)DBNull.Value : cmbPS.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Status", cmbOS.SelectedItem == null ? (object)DBNull.Value : cmbOS.SelectedItem.ToString());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order updated successfully.");
                    ClearFields(); // Clear the fields after updating
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter the OrderID to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Orders WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order deleted successfully.");
                    ClearFields(); // Clear the fields after deleting
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrderID.Text))
            {
                MessageBox.Show("Please enter the OrderID to search.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCustomerID.Text = reader["CustomerID"].ToString();
                            txtCarID.Text = reader["CarID"].ToString();
                            txtPartID.Text = reader["PartID"].ToString();
                            txtName.Text = reader["Name"].ToString();
                            txtQuantity.Text = reader["Quantity"].ToString();
                            txtUnitPrice.Text = reader["UnitPrice"].ToString();
                            txtTotal.Text = reader["TotalPrice"].ToString();
                            txtDate.Text = reader["OrderDate"].ToString();
                            txtPMe.Text = reader["PaymentMethod"].ToString();
                            txtCardNumber.Text = reader["CardNumber"].ToString();
                            cmbPS.SelectedItem = reader["PaymentStatus"].ToString();
                            cmbOS.SelectedItem = reader["Status"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Order not found.");
                            ClearFields(); // Clear the fields if the order is not found
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtOrderID.Clear();
            txtCustomerID.Clear();
            txtCarID.Clear();
            txtPartID.Clear();
            txtName.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtTotal.Clear();
            txtDate.Clear();
            txtPMe.Clear();
            txtCardNumber.Clear();
            cmbPS.SelectedIndex = -1; // Reset the Payment Status combo box
            cmbOS.SelectedIndex = -1; // Reset the Order Status combo box
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            // Connection string to database
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Orders"; // Modify the query if necessary

                // Create a SqlDataAdapter to fill a DataTable with the results
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear existing columns and rows from the DataGridView
                dgvOrders.Columns.Clear();
                dgvOrders.Rows.Clear();



                // Bind the DataTable to the DataGridView
                dgvOrders.DataSource = dt;

                // Optional: Auto-generate columns if needed
                // dgvCars.AutoGenerateColumns = true; 
            }
        }
    }
}
