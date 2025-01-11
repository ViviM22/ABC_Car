using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABC_Car
{
    public partial class MyProfile : Form
    {
        private string currentPassword;
        public MyProfile()
        {
            InitializeComponent();
        }


        // Constructor that accepts customerId as a parameter
        public MyProfile(string customerId)
        {
            InitializeComponent();
            
        }
       

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadCustomerData(username);
        }

        private void LoadCustomerData(string username)
        {
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";
            string query = "SELECT * FROM Customers WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtUsername.Text = reader["Username"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtNIC.Text = reader["NIC"].ToString();
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtAddress.Text = reader["Address"].ToString();

                            // Store the current password to verify later
                            currentPassword = reader["Password"].ToString();

                            
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the specified username.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFormFields()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtNIC.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
            txtCurrentPassword.Clear();
            txtConPassword.Clear();
            txtNewPassword.Clear();
           
        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // Show the current password controls
            lblCurrentPassword.Visible = true;
            txtCurrentPassword.Visible = true;
        }


        private void txtCurrentPassword_Leave(object sender, EventArgs e)
        {
            // When the user leaves the current password textbox, verify it
            if (VerifyCurrentPassword(txtCurrentPassword.Text.Trim()))
            {
                // If the password is correct, show the new password controls
                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
                lblConfirmPassword.Visible = true;
                txtConPassword.Visible = true;
            }
            else
            {
                // If the password is incorrect, show an error message
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Clear(); // Clear the current password field
            }

        }
        private bool VerifyCurrentPassword(string enteredPassword)
        {
            return enteredPassword == currentPassword;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if new password and confirm password match
            if (txtNewPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the new password and ensure it's not empty
            string newPassword = txtNewPassword.Text.Trim();
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Password field cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Define the connection string and update query
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";
            string query = "UPDATE Customers SET Password = @Password, ProfilePicture = @ProfilePicture WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Set the parameters for the query
                        cmd.Parameters.AddWithValue("@Password", newPassword);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());

                        

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update profile. Please check the username and try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
    }
}
