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
using static System.Net.Mime.MediaTypeNames;

namespace ABC_Car
{
    public partial class OrderCarParts : Form
    {
        public OrderCarParts()
        {
            InitializeComponent();
        }

        private void OrderCarParts_Load(object sender, EventArgs e)
        {
            // Connection string to database
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CarParts"; // Modify the query if necessary

                // Create a SqlDataAdapter to fill a DataTable with the results
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear existing columns and rows from the DataGridView
                dgvCarParts.Columns.Clear();
                dgvCarParts.Rows.Clear();



                // Bind the DataTable to the DataGridView
                dgvCarParts.DataSource = dt;

                // Optional: Auto-generate columns if needed
                // dgvCars.AutoGenerateColumns = true; 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedModel = cmbCarModel.SelectedItem?.ToString();
            string selectedBodyStyle = cmbCategory.SelectedItem?.ToString();
            string selectedYear = txtYear.Text.Trim();

            // Call the method to filter and display data
            FilterAndDisplayCarParts(selectedModel, selectedBodyStyle, selectedYear);
        }
        private void FilterAndDisplayCarParts(string carModel, string category, string year)
        {
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM CarParts WHERE 1=1");

                if (!string.IsNullOrEmpty(carModel))
                {
                    queryBuilder.Append(" AND CarModel = @CarModel");
                }

                if (!string.IsNullOrEmpty(category))
                {
                    queryBuilder.Append(" AND Category = @Category");
                }

                if (!string.IsNullOrEmpty(year))
                {
                    queryBuilder.Append(" AND Year = @Year");
                }

                using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    if (!string.IsNullOrEmpty(carModel))
                    {
                        cmd.Parameters.AddWithValue("@CarModel", carModel);
                    }

                    if (!string.IsNullOrEmpty(category))
                    {
                        cmd.Parameters.AddWithValue("@Category", category);
                    }

                    if (!string.IsNullOrEmpty(year))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCarParts.DataSource = dt; // Bind the filtered data to the DataGridView
                }
            }
        }

        private void dgvCarParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row and column
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow row = dgvCarParts.Rows[e.RowIndex];

                    // Populate the form fields with data from the selected row
                    txtPartID.Text = row.Cells["PartID"].Value?.ToString() ?? string.Empty;
                    txtPartName.Text = row.Cells["PartName"].Value?.ToString() ?? string.Empty;
                    txtCarModel.Text = row.Cells["CarModel"].Value?.ToString() ?? string.Empty;
                    txtMake.Text = row.Cells["Make"].Value?.ToString() ?? string.Empty;
                    txtStockQuantity.Text = row.Cells["StockQuantity"].Value?.ToString() ?? string.Empty;
                    txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? string.Empty;

                    // Handle image path and display image if exists
                    string imagePath = row.Cells["ImagePath"].Value?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        // Load the image from the file into a MemoryStream
                        using (var stream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(imagePath)))
                        {
                            picPartImage.Image = System.Drawing.Image.FromStream(stream);  // Use System.Drawing.Image explicitly
                        }
                    }
                    else
                    {
                        picPartImage.Image = null; // Clear the image if the path is invalid
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("An error occurred while loading car part details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int stockQuantity = int.Parse(txtStockQuantity.Text); // Assuming txtStockQuantity contains the stock quantity

            if (stockQuantity > 0)
            {
                PlaceCarParts placeCarPartsForm = new PlaceCarParts();

                // Pass values to PlaceCarParts form
                placeCarPartsForm.PartID = txtPartID.Text;
                placeCarPartsForm.PartName = txtPartName.Text;
                placeCarPartsForm.CarModel = txtCarModel.Text;
                placeCarPartsForm.Price = txtPrice.Text;
                placeCarPartsForm.Category = cmbCategory.SelectedItem?.ToString();

                // Clone the image and pass it to the next form
                placeCarPartsForm.PartImage = picPartImage.Image?.Clone() as System.Drawing.Image;  // Use System.Drawing.Image explicitly

                // Show the PlaceCarParts form
                placeCarPartsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Stock unavailable. Cannot place an order.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
