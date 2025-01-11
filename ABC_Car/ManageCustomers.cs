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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        // Connection string to the database
        private string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ensure passwords match before proceeding
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // Ensure required fields are filled out
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Name and Username are required fields!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO Customers (Name, Username, Email, NIC, Password, ConfirmPassword, ContactNumber, Address)
                VALUES (@Name, @Username, @Email, @NIC, @Password, @ConfirmPassword, @ContactNumber, @Address)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", txtRePassword.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully.");
                    ClearFields(); // Clear the fields after adding
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("Please enter the CustomerID to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                UPDATE Customers
                SET Name = @Name, Username = @Username, Email = @Email, NIC = @NIC, 
                    Password = @Password, ConfirmPassword = @ConfirmPassword, 
                    ContactNumber = @ContactNumber, Address = @Address
                WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", txtUserID.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", txtRePassword.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated successfully.");
                    ClearFields(); // Clear the fields after updating
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("Please enter the CustomerID to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", txtUserID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully.");
                    ClearFields(); // Clear the fields after deleting
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("Please enter the CustomerID to search.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", txtUserID.Text);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtUsername.Text = reader["Username"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtNIC.Text = reader["NIC"].ToString();
                            txtPassword.Text = reader["Password"].ToString();
                            txtRePassword.Text = reader["ConfirmPassword"].ToString();
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.");
                            ClearFields(); // Clear the fields if the customer is not found
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
            txtUserID.Clear();
            txtName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtNIC.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            // Connection string to database
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customers"; // Modify the query if necessary

                // Create a SqlDataAdapter to fill a DataTable with the results
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear existing columns and rows from the DataGridView
                dgvCustomers.Columns.Clear();
                dgvCustomers.Rows.Clear();



                // Bind the DataTable to the DataGridView
                dgvCustomers.DataSource = dt;

                // Optional: Auto-generate columns if needed
                // dgvCars.AutoGenerateColumns = true; 
            }
        }
    }
}
