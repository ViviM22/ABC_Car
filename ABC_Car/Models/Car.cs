using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car.Models
{
    internal class Car
    {
        public int CarID { get; set; }
        public string CarModel { get; set; }
        public string BodyStyle { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Status1 { get; set; }
    }
    internal class CarParts
    {
        public int PartID { get; set; }
        public string PartName { get; set; }
        public string Category { get; set; }
        public string CarModel { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Supplier { get; set; }
        public string ImagePath { get; set; }
    }
    internal class Customer 
    {
        public int CutomerID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int NIC { get; set; }
        public int Password { get; set; }
        public int ConfirmPassword { get; set; }
        public int ContactNumber { get; set; }
    }
    internal class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public int CardNumber { get; set; }
        public string PaymentStatus { get; set; }
        public string Status { get; set; }
    }
}
