using ConsoleApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{
    class Program
    {
        static void FilteredIncludes()
        {
            using var db = new MyStoreContext();
            Console.WriteLine("Enter a minimum for units in stock: ");
            string unitsInStock = Console.ReadLine();
            int stock = int.Parse(unitsInStock);
            IQueryable<Category> cats = db.Category
                 .Include(c => c.Products.Where(p => p.UnitsInStock >= stock));
            foreach (Category c in cats)
            {
                Console.WriteLine($"{c.CategoryName} has {c.Products.Count} product");
                foreach (Product p in c.Products)
                {
                    Console.WriteLine($"--->{p.ProductName} has {p.UnitsInStock} units in stock");
                }
            }
        }
        static void AggregateProducts() {
            using (var db = new MyStoreContext()) {
                Console.WriteLine("{0, -25} {1, 10}", arg0: "Product count:", arg1: db.Product.Count());
                Console.WriteLine("{0, -25} {1, 10:$#,##0.00}", arg0: "Highest product price:", arg1: db.Product.Max(p => p.UnitPrice));
                Console.WriteLine("{0, -25} {1, 10:N0}", arg0: "Sum of units in stock:", arg1: db.Product.Sum(p => p.UnitsInStock));
                Console.WriteLine("{0, -25} {1, 10:$#,##0.00}", arg0: "Average unit price:", arg1: db.Product.Average(p => p.UnitPrice));
                Console.WriteLine("{0, -25} {1, 10:$#,##0.00}", arg0: "Value of units in stock", arg1: db.Product.AsEnumerable().Sum(p => p.UnitPrice * p.UnitsInStock));
            }
        }

        static void QueryingProducts()
        {
            using (var db = new MyStoreContext())
            {
                Console.WriteLine("Products that cost more than a price, highest at top");
                string input;
                decimal price;
                do
                {
                    Console.WriteLine("Enter a product price: ");
                    input = Console.ReadLine();
                } while (!decimal.TryParse(input, out price));
                IQueryable<Product> prods = db.Product
                    .Where(product => product.UnitPrice > price)
                    .OrderByDescending(product => product.UnitPrice);
                foreach (Product item in prods)
                {
                    Console.WriteLine($"ProductName: {item.ProductName} costs {item.UnitPrice:$#,##0.00} " + $"and has {item.UnitsInStock} in stock.");
                }
                {

                }
            }
        }
        static void Main(string[] args)
        {
            
            MyStoreContext myStore = new MyStoreContext();
            var products = from p in myStore.Product select new { p.ProductName, p.CategoryId };
            foreach (var p in products)
            {
                Console.WriteLine($"ProductName: {p.ProductName}, CategoryId: {p.CategoryId}");
            }
            Console.WriteLine("----------------------------");
            IQueryable<Category> cats = myStore.Category.Include(c => c.Products);
            foreach (Category c in cats)
            {
                Console.WriteLine($"CategoryId: {c.CategoryId} has {c.Products.Count} products.");
            }
            Console.WriteLine("---------------------------------------\n");
            FilteredIncludes();
            Console.WriteLine("---------------------------------------\n");
            AggregateProducts();
            Console.WriteLine("---------------------------------------\n");
            QueryingProducts();
            Console.ReadLine();
        }
    }
}