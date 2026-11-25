using LINQ.DataSources;
using LINQ.Models;
namespace LinQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //var seaFood = Source.ProductList
            //       . Where(p => p.Category == "Seafood")
            //         .Select(p => (p.ProductName, p.UnitPrice));
            //foreach (var item in seaFood)
            //{
            //    Console.WriteLine($"{item.ProductName}: {item.UnitPrice}");
            //}
            #endregion

            #region Q2
            //var ProductNamess = Source.ProductList
            //                    .Select(S => (S.ProductName));
            //foreach (var item in ProductNamess)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region Q3
            //var products = Source.ProductList
            //    .OrderBy(S => S.UnitPrice)
            //    .Select(S => (S.ProductName, S.UnitPrice));
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductName}: {item.UnitPrice}");
            //}
            #endregion

            #region Q4
            //var Product = Source.ProductList
            //    .Where(S => S.UnitPrice > 10 && S.UnitPrice < 30)
            //    .Select(S => S.ProductName);
            //foreach (var item in Product)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region Q5
            var Products = Source.ProductList
                            .Where(S => S.Category == "Condiments" && S.UnitPrice > 0)
                            .Select(S => S.ProductName);
            foreach (var item in Products)
            {
                Console.WriteLine($"{item}");
            }
            #endregion
        }
    }
}
