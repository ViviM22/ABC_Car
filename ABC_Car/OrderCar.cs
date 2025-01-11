using ABC_Car.Services;
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
    public partial class OrderCar : Form
    {
        public OrderCar()
        {
            InitializeComponent();
          
        }

        private void OrderCar_Load(object sender, EventArgs e)
        {
            // Connection string to database
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Cars"; 

                // Create a SqlDataAdapter to fill a DataTable with the results
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear existing columns and rows from the DataGridView
                dgvCars.Columns.Clear();
                dgvCars.Rows.Clear();

                

                // Bind the DataTable to the DataGridView
                dgvCars.DataSource = dt;

                
            }
        }
        private void InspectColumns()
        {
            foreach (DataGridViewColumn column in dgvCars.Columns)
            {
                Console.WriteLine($"Column Name: {column.Name}, Header Text: {column.HeaderText}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedModel = cmbCarModel.SelectedItem?.ToString();
            string selectedBodyStyle = cmbBodyStyle.SelectedItem?.ToString();
            string selectedYear = txtYear.Text.Trim();

            // Call the method to filter and display data
            FilterAndDisplayCars(selectedModel, selectedBodyStyle, selectedYear);
        }
        private void FilterAndDisplayCars(string carModel, string bodyStyle, string year)
        {
            string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM Cars WHERE 1=1");

                if (!string.IsNullOrEmpty(carModel))
                {
                    queryBuilder.Append(" AND CarModel = @CarModel");
                }

                if (!string.IsNullOrEmpty(bodyStyle))
                {
                    queryBuilder.Append(" AND BodyStyle = @BodyStyle");
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

                    if (!string.IsNullOrEmpty(bodyStyle))
                    {
                        cmd.Parameters.AddWithValue("@BodyStyle", bodyStyle);
                    }

                    if (!string.IsNullOrEmpty(year))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCars.DataSource = dt; // Bind the filtered data to the DataGridView
                }
            }
        }




        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       
        private void dgvCars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvCars_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
     

        private void dgvCars_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvCars_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row and column
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow row = dgvCars.Rows[e.RowIndex];

                    // Debug to ensure column names match
                    Console.WriteLine($"Selected Column Name: {row.Cells[e.ColumnIndex].OwningColumn.Name}");

                    // Populate the form fields with data from the selected row
                    txtCarID.Text = row.Cells["CarID"].Value?.ToString() ?? string.Empty;
                    txtCarModel.Text = row.Cells["CarModel"].Value?.ToString() ?? string.Empty;
                    txtModelYear.Text = row.Cells["Year"].Value?.ToString() ?? string.Empty;
                    txtColor.Text = row.Cells["Color"].Value?.ToString() ?? string.Empty;
                    txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? string.Empty;
                    txtStatus.Text = row.Cells["Status1"].Value?.ToString() ?? string.Empty;
                    txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;

                    // Handle image path and display image if exists
                    string imagePath = row.Cells["ImagePath"].Value?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        picCarImage.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        picCarImage.Image = null; // Clear the image if the path is invalid
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show("An error occurred while loading car details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text == "Available")
            {
                PlaceCar placeCarForm = new PlaceCar();

                // Pass values to PlaceCar form
                placeCarForm.CarID = txtCarID.Text;
                placeCarForm.CarModel = txtCarModel.Text;
                placeCarForm.ModelYear = txtModelYear.Text;
                placeCarForm.Color = txtColor.Text;
                placeCarForm.Price = txtPrice.Text;

                // Set the car image in PlaceCar form
                placeCarForm.CarImage = picCarImage.Image?.Clone() as Image;

                // Show the PlaceCar form
                placeCarForm.ShowDialog();
            }
            else if (txtStatus.Text == "Sold")
            {
                MessageBox.Show("Sorry, Can't place an order. It's already sold.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Invalid car status. Please check the car details.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
}
