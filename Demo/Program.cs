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


            //--------------------------------------------------------------------------------//

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordss = words.Select(word => new
            //{
            //    Upper = word.ToUpper(),
            //    Lower = word.ToLower()
            //});

            //foreach (var item in wordss)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //}

            //--------------------------------------------------------------------------------//


            ////3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var productInfo = ListGenerator.ProductList.Select(p => new
            //{
            //    p.ProductName,
            //    Price = p.UnitPrice,  
            //    p.UnitsInStock
            //});

            //// Print results
            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.Price}, Stock: {item.UnitsInStock}");
            //}


            //--------------------------------------------------------------------------------//


            ////4. Determine if the value of ints in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((num, index) => new
            //{
            //    Number = num,
            //    Position = num == index
            //});

            //// Print results
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.Position}");
            //}


            //--------------------------------------------------------------------------------//


            ////5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { A = a, B = b };

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}


            //--------------------------------------------------------------------------------//

            ////6. Select all orders where the order total is less than 500.00.


            //List<Order> orders = ListGenerator.CustomerList
            //    .SelectMany(C => C.Orders)
            //    .Where(O => O.Total < 500)
            //    .ToList();


            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"Total: {order.Total}");
            //}
         




            #endregion




        }
    }
}
