using Day_01_G01;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            ////1. Find all products that are out of stock.

            //List<Product> products;
            //products= ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            ////2. Find all products that are in stock and cost more than 3.00 per unit.

            //products = ListGenerator.ProductList.Where(P => P.UnitsInStock >= 0 && P.UnitPrice>3).ToList();


            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}

            ////3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var names = Arr.Where((name, index) => name.Length < index).ToArray();
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region LINQ - Restriction Operators

            //1. Return a sequence of just the names of a list of products.

            //var productNames = ListGenerator.ProductList.Select(p => p.ProductName);
            //foreach (var product in productNames)
            //{
            //    Console.WriteLine(product);
            //}




            #endregion




        }
    }
}
