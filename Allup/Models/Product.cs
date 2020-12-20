using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        [Required]
        public double Price { get; set; }
        public double Discount { get; set; }
        public int Rate { get; set; }
        [Required]
        public int Count { get; set; }
        public int SaleCount { get; set; }
        public double ExTax { get; set; }
        public string Tags { get; set; }
        public string Brand { get; set; }
        public bool HasDeleted { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
