using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14WpfApp
{
    public enum ProductCategories
    {
        Eat,
        Appliances
    }
    public class Product
    {
        public string ProductName {get; set;}
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategories ProductCategory { get; set; }
    }
}
