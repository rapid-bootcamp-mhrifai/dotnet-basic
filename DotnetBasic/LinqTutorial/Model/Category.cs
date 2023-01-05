using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model
{
    public class Category
    {
        public String CategoryName { get; set; }
        public int CategoryId { get; set; }
        public int Count { get; set; }

        public Category(string categoryName, int categoryId, int count)
        {
            this.CategoryName = categoryName;
            this.CategoryId = categoryId;
            this.Count = count;
        }

        public override string ToString()
        {
            return "Product {Category Name : " + this.CategoryName + ", Category Id : " + this.CategoryId + ", Count : " + this.Count + "}";
        }

        public static List<Category> GetData()
        {
            List<Category> categories = new List<Category>()
            {
                new Category("Mie", 12, 5),
                new Category("Mie kuah", 13, 10),
            };
            return categories;
        }

        public static void SampleFilterCategory()
        {
            List<Category> categories = GetData();

            IEnumerable<Category> categoryFilter = from item in categories
                                                   where item.CategoryId == 12
                                                   select item;

            foreach(var category in categoryFilter)
            {
                Console.WriteLine(category);
            }
        }
    }
}
