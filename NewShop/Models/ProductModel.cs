using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace NewShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal ProductCost { get; set; }
        public decimal ProductVallue { get; set; }
        public decimal DollarChange { get; set; }
        public decimal TengeChange { get; set; }
        public decimal EuroChange { get; set; }
        
    }
}
