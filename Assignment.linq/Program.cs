namespace Assignment.linq
{

    internal class Program
    {
        static void Main()
        {
            #region 1. LINQ - Restriction Operators

            // 1.1.Find all products that are out of stock.
            //var result = ProductList.Where(P => P.UnitsInStock == 0);

            // 1.2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);

            // 1.3. Returns digits whose name is shorter than their value.
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = digits.Where((digit, index) => digit.Length < index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. LINQ - Element Operators
            // 2.1. Get first Product out of Stock.
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            // 2.2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);

            // 2.3. Retrieve the second number greater than 5.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(result);
            #endregion

            #region 3. LINQ - Aggregate Operators
            // 3.1. Uses Count to get the number of odd numbers in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Count(n => n % 2 != 0);

            // 3.2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(C => new { C.CustomerName, OrderCount = C.Orders.Length });

            // 3.3. Return a list of categories and how many products each has.
            //var result = ProductList.GroupBy(P => P.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() });

            // 3.4. Get the total of the numbers in an array.
            //var result = numbers.Sum();

            // 3.5. Get the total number of characters of all words in dictionary_english.txt.
            //var words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(word => word.Length);

            // 3.6. Get the length of the shortest word in dictionary_english.txt.
            //var result = words.Min(word => word.Length);

            // 3.7. Get the length of the longest word in dictionary_english.txt.
            //var result = words.Max(word => word.Length);

            // 3.8. Get the average length of the words in dictionary_english.txt.
            //var result = words.Average(word => word.Length);

            // 3.9. Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(P => P.Category).Select(g => new { Category = g.Key, TotalUnits = g.Sum(P => P.UnitsInStock) });

            // 3.10. Get the cheapest price among each category's products.
            //var result = ProductList.GroupBy(P => P.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(P => P.UnitPrice) });

            // 3.11. Get the products with the cheapest price in each category (Use Let).
            //var result = from P in ProductList
            //             group P by P.Category into g
            //             let minPrice = g.Min(P => P.UnitPrice)
            //             select new { Category = g.Key, CheapestProducts = g.Where(P => P.UnitPrice == minPrice) };

            // 3.12. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(P => P.Category).Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(P => P.UnitPrice) });

            // 3.13. Get the products with the most expensive price in each category.
            //var result = from P in ProductList
            //             group P by P.Category into g
            //             let maxPrice = g.Max(P => P.UnitPrice)
            //             select new { Category = g.Key, MostExpensiveProducts = g.Where(P => P.UnitPrice == maxPrice) };

            // 3.14. Get the average price of each category's products.
            //var result = ProductList.GroupBy(P => P.Category).Select(g => new { Category = g.Key, AveragePrice = g.Average(P => P.UnitPrice) });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. LINQ - Ordering Operators
            // 4.1. Sort a list of products by name.
            //var result = ProductList.OrderBy(P => P.ProductName);

            // 4.2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] wordsArray = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = wordsArray.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            // 4.3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(P => P.UnitsInStock);

            // 4.4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] digitsArray = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = digitsArray.OrderBy(d => d.Length).ThenBy(d => d);

            // 4.5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //var result = wordsArray.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            // 4.6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            // 4.7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //var result = wordsArray.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            // 4.8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //var result = digitsArray.Where(d => d.Length > 1 && d[1] == 'i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. LINQ - Transformation Operators
            // 5.1. Return a sequence of just the names of a list of products.
            //var result = ProductList.Select(P => P.ProductName);

            // 5.2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });

            // 5.3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductList.Select(P => new { P.ProductName, P.Category, Price = P.UnitPrice });

            // 5.4. Determine if the value of int in an array matches their position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Select((num, index) => new { Number = num, Index = index, IsMatch = num == index });

            // 5.5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            // 5.6. Select all orders where the order total is less than 500.00.
            //var result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500.00M);

            // 5.7. Select all orders where the order was made in 1998 or later.
            //var result = CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year >= 1998);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6. LINQ - Set Operators
            // 6.1. Find the unique Category names from Product List.
            //var result = ProductList.Select(P => P.Category).Distinct();

            // 6.2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(P => P.ProductName[0])
            //    .Union(CustomerList.Select(C => C.CustomerName[0]))
            //    .Distinct();

            // 6.3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(P => P.ProductName[0])
            //    .Intersect(CustomerList.Select(C => C.CustomerName[0]));

            // 6.4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(P => P.ProductName[0])
            //    .Except(CustomerList.Select(C => C.CustomerName[0]));

            // 6.5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates.
            //var result = ProductList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName)
            //    .Concat(CustomerList.Select(C => C.CustomerName.Length >= 3 ? C.CustomerName.Substring(C.CustomerName.Length - 3) : C.CustomerName));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. LINQ - Partitioning Operators
            // 7.1. Get the first 3 orders from customers in Washington.
            //var result = CustomerList
            //    .Where(C => C.Region == "WA")
            //    .SelectMany(C => C.Orders)
            //    .Take(3);

            // 7.2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList
            //    .Where(C => C.Region == "WA")
            //    .SelectMany(C => C.Orders)
            //    .Skip(2);

            // 7.3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((num, index) => num >= index);

            // 7.4. Get the elements of the array starting from the first element divisible by 3.
            //var result = numbers.SkipWhile(num => num % 3 != 0);


            #endregion

            #region 8. LINQ - Quantifiers
            // 8.1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
            //var words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.Any(word => word.Contains("ei"));

            // 8.2. Return a grouped list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList
            //    .GroupBy(P => P.Category)
            //    .Where(g => g.Any(P => P.UnitsInStock == 0));

            // 8.3. Return a grouped list of products only for categories that have all of their products in stock.
            //var result = ProductList
            //    .GroupBy(P => P.Category)
            //    .Where(g => g.All(P => P.UnitsInStock > 0));

            //Console.WriteLine(result);
            #endregion

            #region 9. LINQ - Grouping Operators

            // 9.1. Uses group by to partition a list of words by their first letter.
            //var words = System.IO.File.ReadAllLines("dictionary_english.txt");
            //var result = words.GroupBy(word => word[0]);

            #endregion
        }


    }


}
