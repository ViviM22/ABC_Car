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
    public partial class OrderStatus : Form
    {
        private int customerId;
        public OrderStatus(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void OrderStatus_Load(object sender, EventArgs e)
        {
            LoadOrdersForCustomer(customerId); // Load orders when the form loads
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





                // Bind the DataTable to the DataGridView
                dgvOrders.DataSource = dt;

                // Optional: Auto-generate columns if needed
                // dgvCars.AutoGenerateColumns = true; 
            }
        }


        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            LoadOrdersForCustomer(customerId); // Load orders when the button is clicked
            dgvOrders.Visible = true;
        }
        private void LoadOrdersForCustomer(int customerId)
        {
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT OrderID, CarID, PartID, Name, Quantity, UnitPrice, TotalPrice, OrderDate, PaymentMethod, PaymentStatus, Status
                FROM Orders
                WHERE CustomerID = @CustomerID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrders.DataSource = dt;
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row and column
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

                    // Populate the form fields with data from the selected row
                    txtName.Text = row.Cells["Name"].Value?.ToString() ?? string.Empty;
                    txtDate.Text = row.Cells["OrderDate"].Value?.ToString() ?? string.Empty;
                    txtTotal.Text = row.Cells["TotalPrice"].Value?.ToString() ?? string.Empty;
                    txtStatus.Text = row.Cells["Status"].Value?.ToString() ?? string.Empty;

                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    } 
 }
    


