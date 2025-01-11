using ABC_Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ABC_Car.Services
{
    internal class CarService
    {
        private string connectionString = "Data Source=DESKTOP-2POJ18T\\SQLEXPRESS;Initial Catalog=ABC_Car;Integrated Security=True";

        public Car GetCarById(int carID)
        {
            // Assuming you are using SQL
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cars WHERE CarID = @CarID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", carID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Car car = new Car
                    {
                        CarID = (int)reader["CarID"],
                        CarModel = reader["CarModel"].ToString(),
                        BodyStyle = reader["BodyStyle"].ToString(),
                        Make = reader["Make"].ToString(),
                        Year = (int)reader["Year"],
                        Color = reader["Color"].ToString(),
                        Price = (decimal)reader["Price"],
                        Description = reader["Description"].ToString(),
                        ImagePath = reader["ImagePath"].ToString(),
                        Status1 = reader["Status1"].ToString()
                    };
                    return car;
                }
            }

            return null; // Return null if no car is found
        }

        // Method to add a new car to the database
        public void AddCar(Car car)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cars (CarModel, BodyStyle, Make, Year, Color, Price, Description, ImagePath, Status1) " +
               "VALUES (@CarModel, @BodyStyle, @Make, @Year, @Color, @Price, @Description, @ImagePath, @Status1)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", car.CarID);
                cmd.Parameters.AddWithValue("@CarModel", car.CarModel);
                cmd.Parameters.AddWithValue("@BodyStyle", car.BodyStyle);
                cmd.Parameters.AddWithValue("@Make", car.Make);
                cmd.Parameters.AddWithValue("@Year", car.Year);
                cmd.Parameters.AddWithValue("@Color", car.Color);
                cmd.Parameters.AddWithValue("@Price", car.Price);
                cmd.Parameters.AddWithValue("@Description", car.Description);
                cmd.Parameters.AddWithValue("@ImagePath", car.ImagePath);
                cmd.Parameters.AddWithValue("@Status1", car.Status1);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateCar(Car car)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cars SET CarModel = @CarModel, BodyStyle = @BodyStyle, Make = @Make, Year = @Year, " +
                               "Color = @Color, Price = @Price, Description = @Description, ImagePath = @ImagePath, Status1 = @Status1 " +
                               "WHERE CarID = @CarID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CarID", car.CarID);
                cmd.Parameters.AddWithValue("@CarModel", car.CarModel);
                cmd.Parameters.AddWithValue("@BodyStyle", car.BodyStyle);
                cmd.Parameters.AddWithValue("@Make", car.Make);
                cmd.Parameters.AddWithValue("@Year", car.Year);
                cmd.Parameters.AddWithValue("@Color", car.Color);
                cmd.Parameters.AddWithValue("@Price", car.Price);
                cmd.Parameters.AddWithValue("@Description", car.Description);
                cmd.Parameters.AddWithValue("@ImagePath", car.ImagePath);
                cmd.Parameters.AddWithValue("@Status1", car.Status1);

                conn.Open();
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
                string query = "SELECT * FROM Cars WHERE CarModel LIKE @SearchText OR Make LIKE @SearchText OR BodyStyle LIKE @SearchText";

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
                string query = "SELECT * FROM Cars";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
