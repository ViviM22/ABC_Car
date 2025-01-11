using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ABC_Car.Models;

namespace ABC_Car.Services
{
    internal class CarPartManager
    {
        private string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

        public CarPart GetCarPartById(int partID)
        {
            CarPart carPart = null;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CarParts WHERE PartID=@PartID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PartID", partID);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        carPart = new CarPart
                        {
                            PartID = Convert.ToInt32(reader["PartID"]),
                            PartName = reader["PartName"].ToString(),
                            Category = reader["Category"].ToString(),
                            CarModel = reader["CarModel"].ToString(),
                            Make = reader["Make"].ToString(),
                            Year = Convert.ToInt32(reader["Year"]),
                            Price = Convert.ToDecimal(reader["Price"]),
                            StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                            Supplier = reader["Supplier"].ToString(),
                            ImagePath = reader["ImagePath"].ToString()
                        };
                    }
                }
            }

            return carPart;
        }
        public void AddCarPart(CarPart carPart)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CarParts (PartName, Category, CarModel, Make, Year, Price, StockQuantity, Supplier, ImagePath) " +
               "VALUES (@PartName, @Category, @CarModel, @Make, @Year, @Price, @StockQuantity, @Supplier, @ImagePath)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PartID", carPart.PartID);
                cmd.Parameters.AddWithValue("@PartName", carPart.PartName);
                cmd.Parameters.AddWithValue("@Category", carPart.Category);
                cmd.Parameters.AddWithValue("@CarModel", carPart.CarModel);
                cmd.Parameters.AddWithValue("@Make", carPart.Make);
                cmd.Parameters.AddWithValue("@Year", carPart.Year);
                cmd.Parameters.AddWithValue("@Price", carPart.Price);
                cmd.Parameters.AddWithValue("@StockQuantity", carPart.StockQuantity);
                cmd.Parameters.AddWithValue("@Supplier", carPart.Supplier);
                cmd.Parameters.AddWithValue("@ImagePath", carPart.ImagePath);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCarPart(CarPart carPart)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE CarParts SET PartName=@PartName, Category=@Category, CarModel=@CarModel, Make=@Make, Year=@Year, " +
                               "Price=@Price, StockQuantity=@StockQuantity, Supplier=@Supplier, ImagePath=@ImagePath WHERE PartID=@PartID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PartName", carPart.PartName);
                cmd.Parameters.AddWithValue("@Category", carPart.Category);
                cmd.Parameters.AddWithValue("@CarModel", carPart.CarModel);
                cmd.Parameters.AddWithValue("@Make", carPart.Make);
                cmd.Parameters.AddWithValue("@Year", carPart.Year);
                cmd.Parameters.AddWithValue("@Price", carPart.Price);
                cmd.Parameters.AddWithValue("@StockQuantity", carPart.StockQuantity);
                cmd.Parameters.AddWithValue("@Supplier", carPart.Supplier);
                cmd.Parameters.AddWithValue("@ImagePath", carPart.ImagePath);
                cmd.Parameters.AddWithValue("@PartID", carPart.PartID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCarPart(int partID)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM CarParts WHERE PartID=@PartID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PartID", partID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // Method to delete a car from the database
        public void DeleteCar(int carID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Cars WHERE CarID = @CarID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", carID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Method to search for cars by model or other criteria
        public DataTable SearchCars(string searchText)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CarParts WHERE CarModel LIKE @SearchText OR Make LIKE @SearchText OR BodyStyle LIKE @SearchText";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Method to load all cars from the database
        public DataTable LoadCars()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CarParts";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable GetCarParts()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CarParts";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.Fill(dt);
            }
            return dt;
        }
    }
}
