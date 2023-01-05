using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }

        public Product(String name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "Product { Name: " + this.name + ", Price: Rp. " + this.price + "}";
        }

        public static List<Product> GetData()
        {
            List<Product> products = new List<Product>()
        {
            new Product("Indomie Goreng", 5000),
            new Product("Indomie Soto", 5000),
            new Product("Indomie telor 2", 10000),
        };

            return products;
        }

        public static void SampleFilterProduct()
        {
            // 1. create data source
            List<Product> products = GetData();

            // 2. create query
            IEnumerable<Product> productFilter = from item in products
                                                 where item.price >= 5000
                                               select item;

            // 3. execute query
            foreach (var product in productFilter)
            {
                Console.WriteLine(product);
            }
        }

        public static void SampleFilterProductByName()
        {
            // 1. create data source
            List<Product> products = GetData();

            // 2. create query
            IEnumerable<Product> productFilter = from product in products
                                                 where product.name.ToLower().Contains("indo")
                                                 select product;

            // 3. execute query
            foreach (var product in productFilter)
            {
                Console.WriteLine(product);
            }
        }

    }
}
