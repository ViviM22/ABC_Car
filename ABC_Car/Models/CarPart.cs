using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car.Models
{
    internal class CarPart
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
}
