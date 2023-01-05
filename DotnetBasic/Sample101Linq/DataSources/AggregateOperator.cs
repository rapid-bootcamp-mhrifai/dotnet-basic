using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101Linq.DataSources
{
    public class AggregateOperator
    {
        public List<Product> GetProducts() => Products.ProductList;
        public List<Customer> GetCustomers() => Customers.CustomerList; 

        public int CountSyntax()
        {
            #region count-syntax
            int[] factorsOf300 = { 2, 2, 3, 5, 5, 6, 6, 6 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
            #endregion
            return 0;
        }

        public int CountConditional()
        {
            #region count-conditional
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
            #endregion
            return 0;
        }

        public int CountNested()
        {
            #region nested-count
            List<Customer> customers = Customers.GetCustomerList();

            /*
            var orderCounts = from c in customers
                select  (c.CustomerID,c.CompanyName, OrderCount: c.Orders.Count());

            foreach(var customer in orderCounts)
            {
                Console.WriteLine($"ID: {customer.CustomerID}, Name: {customer.CompanyName}, count: {customer.OrderCount}");
            }
            */

            var orderCounts = from c in customers
                              where c.City.Equals("Berlin")
                              select new
                              {
                                  ID = c.CustomerID,
                                  Name = c.CompanyName,
                                  City = c.City,
                                  Country = c.Country,
                                  Count = c.Orders.Count()                                  
                              };

            foreach (var customer in orderCounts)
            {
                Console.WriteLine($"ID: {customer.ID}, Name: {customer.Name}, City: {customer.City}, Country: {customer.Country}, count: {customer.Count}");
            }

            #endregion
            return 0;
        }

        public int GroupedCount()
        {
            #region groupedcount
            List<Product> products = GetProducts();

            var categoryCounts = from p in products
                                 group p by p.Category into g
                                 select (Category: g.Key, ProductCount: g.Count());

            foreach (var c in categoryCounts)
            {
                Console.WriteLine($"Category: {c.Category}: Product count: {c.ProductCount}");
            }
            #endregion
            
            return 0;
        }

        public int SumSyntax()
        {
            #region sum-syntax
            int[] numbers = { 1, 2, 3, 2, 4, 7, 8, 12, 11, 7, 12, 15 };

            double numSum = numbers.Sum();

            Console.WriteLine($"The sum of the numbers is {numSum}");
            #endregion
            
            return 0;
        }

        public int SumProjection()
        {
            #region sum-of-projection
            string[] words = { "Aristotels", "Plato", "Pythagoras" };

            double totalChars = words.Sum(w => w.Length);

            Console.WriteLine($"There are a total of {totalChars} characters in these words.");
            #endregion
            
            return 0;
        }

        public int SumGrouped()
        {
            #region grouped-sum
            List<Product> products = GetProducts();

            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, TotalUnitsInStock: g.Sum(p => p.UnitsInStock));

            foreach (var pair in categories)
            {
                Console.WriteLine($"Category: {pair.Category}, Units in stock: {pair.TotalUnitsInStock}");
            }
            #endregion
            
            return 0;
        }

        public int MinSyntax()
        {
            #region min-syntax
            int[] numbers = { 1, 2, 3, 2, 4, 7, 8, 12, 11, 7, 12, 15 };

            int minNum = numbers.Min();

            Console.WriteLine($"The minimum number is {minNum}");
            #endregion
            
            return 0;
        }

        public int MinProjection()
        {
            #region min-projection
            string[] words = { "Aristotels", "Plato", "Pythagoras" };

            int shortestWord = words.Min(w => w.Length);

            Console.WriteLine($"The shortest word is {shortestWord} characters long.");
            #endregion
            
            return 0;
        }

        public int MinGrouped()
        {
            #region min-grouped
            List<Product> products = GetProducts();

            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, CheapestPrice: g.Min(p => p.UnitPrice));

            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}, Lowest price: {c.CheapestPrice}");
            }
            #endregion

            return 0;
        }

        public int MinEachgroup()
        {
            #region min-each-group
            List<Product> products = GetProducts();

            var categories = from p in products
                             group p by p.Category into g
                             let minPrice = g.Min(p => p.UnitPrice)
                             select (Category: g.Key, CheapestProducts: g.Where(p => p.UnitPrice == minPrice));

            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}");
                foreach (var p in c.CheapestProducts)
                {
                    Console.WriteLine($"\tProduct: {p}");
                }
            }
            #endregion

            return 0;
        }

        public int MaxSyntax()
        {
            #region max-syntax
            int[] numbers = { 1, 2, 3, 2, 4, 7, 8, 12, 11, 7, 12, 15 };

            int maxNum = numbers.Max();

            Console.WriteLine($"The maximum number is {maxNum}");
            #endregion

            return 0;
        }

        public int MaxProjection()
        {
            #region max-projection
            string[] words = { "Aristotels", "Plato", "Pythagoras" };

            int longestLength = words.Max(w => w.Length);

            Console.WriteLine($"The longest word is {longestLength} characters long.");
            #endregion

            return 0;
        }

        public int MaxGrouped()
        {
            #region max-grouped
            List<Product> products = GetProducts();

            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, MostExpensivePrice: g.Max(p => p.UnitPrice));

            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category} Most expensive product: {c.MostExpensivePrice}");
            }
            #endregion

            return 0;
        }

        public int MaxEachGroup()
        {
            #region max-each-group
            List<Product> products = GetProducts();

            var categories = from p in products
                             group p by p.Category into g
                             let maxPrice = g.Max(p => p.UnitPrice)
                             select (Category: g.Key, MostExpensiveProducts: g.Where(p => p.UnitPrice == maxPrice));

            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}");
                foreach (var p in c.MostExpensiveProducts)
                {
                    Console.WriteLine($"\t{p}");
                }
            }
            #endregion

            return 0;
        }

        public int AverageSyntax()
        {
            #region average-syntax
            int[] numbers = { 1, 2, 3, 2, 4, 7, 8, 12, 11, 7, 12, 15 };

            double averageNum = numbers.Average();

            Console.WriteLine($"The average number is {averageNum}.");
            #endregion

            return 0;
        }

        public int AverageProjection()
        {
            #region average-projection
            string[] words = { "Aristotels", "Plato", "Pythagoras" };

            double averageLength = words.Average(w => w.Length);

            Console.WriteLine($"The average word length is {averageLength} characters.");
            #endregion

            return 0;
        }

        public int AverageGroup()
        {
            #region average-grouped
            List<Product> products = GetProducts();

            var categories = from p in products
                             group p by p.Category into g
                             select (Category: g.Key, AveragePrice: g.Average(p => p.UnitPrice));

            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}, Average price: {c.AveragePrice}");
            }
            #endregion

            return 0;
        }

        public int AggregateSyntax()
        {
            #region aggregate-syntax
            double[] doubles = { 2.3, 3.1, 2.9, 5.7, 1.2 };

            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine($"Total product of all numbers: {product}");
            #endregion

            return 0;
        }

        public int SeededAggregate()
        {
            #region aggregate-seeded
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 10, 30, 10, 50, 40, 80 };

            double endBalance =
                attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine($"Ending balance: {endBalance}");
            #endregion

            return 0;
        }
    }
}
