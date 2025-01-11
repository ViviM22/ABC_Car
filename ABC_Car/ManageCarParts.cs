using ABC_Car.Models;
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

namespace ABC_Car
{
    public partial class ManageCarParts : Form
    {
        private CarPartManager carPartManager;
        public ManageCarParts()
        {
            InitializeComponent();
            carPartManager = new CarPartManager(); // Initialize the service
        }

        private void LoadCarPartsData()
        {
            DataTable carPartsTable = carPartManager.GetCarParts();
            dataGridView1.DataSource = carPartsTable; // Assuming your DataGridView is named dataGridView1
        }

        private void ManageCarParts_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields()) // Ensure all fields are validated
            {
                // Parse PartID as integer
                int partID;
                if (int.TryParse(txtPartID.Text, out partID))
                {
                    CarPart newCarPart = new CarPart
                    {
                        PartID = partID, // Assign parsed PartID
                        PartName = txtPartName.Text,
                        Category = cmbCategory.Text,
                        CarModel = cmbCarModel.Text,
                        Make = cmbMake.Text,
                        Year = int.Parse(txtYear.Text),
                        Price = decimal.Parse(txtPrice.Text),
                        StockQuantity = int.Parse(txtStockQuantity.Text),
                        Supplier = txtSupplier.Text,
                        ImagePath = txtImagePath.Text
                    };

                    carPartManager.AddCarPart(newCarPart); // Add the car part using the service method
                    LoadCarPartsData(); // Refresh the DataGridView after adding
                    ClearFields(); // Clear input fields
                    MessageBox.Show("Car part record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Part ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (MessageBox.Show("Are you sure you want to update this part?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CarPart selectedCarPart = new CarPart
                    {
                        PartID = int.Parse(txtPartID.Text),
                        PartName = txtPartName.Text,
                        Category = cmbCategory.Text,
                        CarModel = cmbCarModel.Text,
                        Make = cmbMake.Text,
                        Year = int.Parse(txtYear.Text),
                        Price = decimal.Parse(txtPrice.Text),
                        StockQuantity = int.Parse(txtStockQuantity.Text),
                        Supplier = txtSupplier.Text,
                        ImagePath = txtImagePath.Text
                    };

                    carPartManager.UpdateCarPart(selectedCarPart);
                    LoadCarPartsData(); // Refresh the DataGridView after updating
                    ClearFields();
                    MessageBox.Show("Car part updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPartID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int partID = int.Parse(txtPartID.Text);

                    carPartManager.DeleteCarPart(partID);
                    LoadCarPartsData(); // Refresh the DataGridView after deletion
                    ClearFields();
                    MessageBox.Show("Car part deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a car part to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                int partID;
                if (int.TryParse(txtSearch.Text, out partID))
                {
                    CarPart carPart = carPartManager.GetCarPartById(partID);
                    if (carPart != null)
                    {
                        txtPartID.Text = carPart.PartID.ToString();
                        txtPartName.Text = carPart.PartName;
                        cmbCategory.Text = carPart.Category;
                        cmbCarModel.Text = carPart.CarModel;
                        cmbMake.Text = carPart.Make;
                        txtYear.Text = carPart.Year.ToString();
                        txtPrice.Text = carPart.Price.ToString();
                        txtStockQuantity.Text = carPart.StockQuantity.ToString();
                        txtSupplier.Text = carPart.Supplier;
                        txtImagePath.Text = carPart.ImagePath;

                        if (!string.IsNullOrEmpty(carPart.ImagePath) && System.IO.File.Exists(carPart.ImagePath))
                        {
                            picPartImage.Image = Image.FromFile(carPart.ImagePath);
                        }
                        else
                        {
                            picPartImage.Image = null; // Clear the image if the file doesn't exist
                        }
                    }
                    else
                    {
                        MessageBox.Show("No part found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Part ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Part ID cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName; // Assuming txtImagePath is a TextBox to store the image path
                    picPartImage.Image = Image.FromFile(ofd.FileName); // Assuming picPartImage is the PictureBox
                }
            }
        }
        private void ClearFields()
        {
            txtSearch.Clear();
            txtPartID.Clear();
            txtPartName.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbCarModel.SelectedIndex = -1;
            cmbMake.SelectedIndex = -1;
            txtYear.Clear();
            txtPrice.Clear();
            txtStockQuantity.Clear();
            txtSupplier.Clear();
            txtImagePath.Clear();
            picPartImage.Image = null;
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtPartName.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                string.IsNullOrWhiteSpace(cmbCarModel.Text) ||
                string.IsNullOrWhiteSpace(cmbMake.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStockQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtSupplier.Text) ||
                string.IsNullOrWhiteSpace(txtImagePath.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
