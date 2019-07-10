using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tugass.Models
{
    public class Product
    {
        public string IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public int HargaBarang { get; set; }

        private List<Product> ListProduct = new List<Product>();
        public List<Product> ShowProduct()
        {
            this.ListProduct.Add(new Product { IdBarang = "A01", NamaBarang = "Sepatu", HargaBarang = 650000 });
            this.ListProduct.Add(new Product { IdBarang = "B21", NamaBarang = "Kemeja", HargaBarang = 1230000 });
            this.ListProduct.Add(new Product { IdBarang = "C31", NamaBarang = "Topi", HargaBarang = 240000 });
            this.ListProduct.Add(new Product { IdBarang = "D41", NamaBarang = "Celana Jeans", HargaBarang = 768000 });
            this.ListProduct.Add(new Product { IdBarang = "E51", NamaBarang = "Hoodie", HargaBarang = 1890000 });
            this.ListProduct.Add(new Product { IdBarang = "F61", NamaBarang = "Jaket", HargaBarang = 1450000 });
            return ListProduct;
        }
    }
}