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

    public partial class ManageCars : Form
    {

        private CarService carService;
        public ManageCars()
        {
            InitializeComponent();
            carService = new CarService(); // Initialize the service
        }

        private void cmbCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageCars_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadCarData()
        {
            DataTable carsTable = carService.LoadCars();
            dataGridView1.DataSource = carsTable; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                // Parse CarID as integer
                int carID;
                if (int.TryParse(txtCarID.Text, out carID))
                {
                    Car newCar = new Car
                    {
                        CarID = carID, // Assign parsed CarID
                        CarModel = cmbCarModel.Text,
                        BodyStyle = cmbBodyStyle.Text,
                        Make = cmbMake.Text,
                        Year = int.Parse(txtYear.Text),
                        Color = txtColor.Text,
                        Price = decimal.Parse(txtPrice.Text),
                        Description = txtDescription.Text,
                        ImagePath = txtImagePath.Text,
                        Status1 = cmdStatus.Text
                    };

                    carService.AddCar(newCar);
                    LoadCarData(); // Refresh the DataGridView after adding
                    ClearFields();
                    MessageBox.Show("Car record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Car ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Car selectedCar = new Car
                    {
                        CarID = int.Parse(txtCarID.Text),
                        CarModel = cmbCarModel.Text,
                        BodyStyle = cmbBodyStyle.Text,
                        Make = cmbMake.Text,
                        Year = int.Parse(txtYear.Text),
                        Color = txtColor.Text,
                        Price = decimal.Parse(txtPrice.Text),
                        Description = txtDescription.Text,
                        ImagePath = txtImagePath.Text,
                        Status1 = cmdStatus.Text
                    };

                    carService.UpdateCar(selectedCar);
                    LoadCarData(); // Refresh the DataGridView after updating
                    ClearFields();
                    MessageBox.Show("Car record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCarID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int carID = int.Parse(txtCarID.Text);

                    carService.DeleteCar(carID);
                    LoadCarData(); // Refresh the DataGridView after deletion
                    ClearFields();
                    MessageBox.Show("Car record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a car record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                int carID;
                if (int.TryParse(txtSearch.Text, out carID))
                {
                    Car car = carService.GetCarById(carID);
                    if (car != null)
                    {
                        txtCarID.Text = car.CarID.ToString();
                        cmbCarModel.Text = car.CarModel;
                        cmbBodyStyle.Text = car.BodyStyle;
                        cmbMake.Text = car.Make;
                        txtYear.Text = car.Year.ToString();
                        txtColor.Text = car.Color;
                        txtPrice.Text = car.Price.ToString();
                        txtDescription.Text = car.Description;
                        txtImagePath.Text = car.ImagePath;
                        cmdStatus.Text = car.Status1;

                        if (!string.IsNullOrEmpty(car.ImagePath) && System.IO.File.Exists(car.ImagePath))
                        {
                            picCarImage.Image = Image.FromFile(car.ImagePath);
                        }
                        else
                        {
                            picCarImage.Image = null; // Clear the image if the file doesn't exist
                        }
                    }
                    else
                    {
                        MessageBox.Show("No car found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Car ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Car ID cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtSearch.Clear();
            txtCarID.Clear();
            cmbCarModel.SelectedIndex = -1;
            cmbBodyStyle.SelectedIndex = -1;
            cmbMake.SelectedIndex = -1;
            txtYear.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            txtImagePath.Clear();
            picCarImage.Image = null;
            cmdStatus.SelectedIndex = -1;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName; // Assuming txtImagePath is a TextBox to store the image path
                    picCarImage.Image = Image.FromFile(ofd.FileName); // Assuming picCarImage is the PictureBox
                }
            }
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(cmbCarModel.Text) ||
                string.IsNullOrWhiteSpace(cmbBodyStyle.Text) ||
                string.IsNullOrWhiteSpace(cmbMake.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtImagePath.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
