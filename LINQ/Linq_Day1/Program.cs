using System;
using System.Linq;

namespace LINQExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // 1. Find all products that are out of stock.
            //var result1 = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);

            //    // 2. Find all products that are in stock and cost more than 3.00 per unit.
            //    var result2 = ListGenerators.ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            //    // 3. Returns digits whose name is shorter than their value.
            //    string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //    var result3 = arr
            //        .Select((n, i) => new { Name = n, Value = i })
            //        .Where(n => n.Name.Length < n.Value);

            //    // LINQ - Element Operators
            //    // 1. Get first Product out of Stock
            //    var result2_1 = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            //    // 2. Return the first product whose Price > 1000,
            //    // unless there is no match, in which case null is returned.
            //    var result2_2 = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000M);

            //    // 3. Retrieve the second number greater than 5
            //    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //    var result2_3 = numbers.Where(n => n > 5).Skip(1).FirstOrDefault();


            //    foreach (var item in result1)
            //        Console.WriteLine($"{item}");

            //    // 3- LINQ - Set Operators 
            //    // Use ListGenerators.cs & Customers.xml 
            //    // 1. Find the unique Category names from Product List 
            //    var result3_1 = ListGenerators.ProductList.Select(p=>p.Category).Distinct();
            //    // 2. Produce a Sequence containing the unique first letter from 
            //    // //both product and customer names. 
            //    var product_res2 = ListGenerators.ProductList.Select(p=>p.ProductName[0]);
            //    var customer_res2 = ListGenerators.CustomerList.Select(c=>c.CompanyName[0]);
            //    var result3_2 =product_res.Union(customer_res);

            //    // 3. Create one sequence that contains the common first letter 
            //    // //from both product and customer names. 
            //    var product_res3 = ListGenerators.ProductList.Select(p=>p.ProductName[0]);
            //    var customer_res3 = ListGenerators.CustomerList.Select(c=>c.CompanyName[0]);
            //    var result3_3 =product_res.Intersect(customer_res);
            //    // 4. Create one sequence that contain
            //    // //ظthe first letters of product names that are not also first letters of customer names. 
            //    var product_res4 = ListGenerators.ProductList.Select(p=>p.ProductName[0]);
            //    var customer_res4 = ListGenerators.CustomerList.Select(c=>c.CompanyName[0]);
            //    var result3_4 =product_res.Except(customer_res);
            //    // 5. Create one sequence that contains the last Three Characters 
            //    // //in each names of all customers and products, including any duplicates 


            //    //4-  LINQ - Aggregate Operators min max count group by
            //    // 1. Uses Count to get the number of odd numbers in the array 
            //    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //     var result4_1 = Arr.Count(n=>n%2==1);
            //    // Use ListGenerators.cs & Customers.xml 
            //    // 2. Return a list of customers and how many orders each has. 
            //    var result4_2 = ListGenerators.CustomerList.Select(c=>new{c.CompanyName,c.order.Count()});
            //    // 3. Return a list of categories and how many products each has 
            //    var result4_3 = ListGenerators.ProductList.GroupBy(p=>p.Category)
            //    .Select(group=>new{Category=g.key ,Count=g.Count()});
            //    // 4. Get the total of the numbers in an array. 
            //    // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 

            //    var result4_4 = Arr.Sum();

            //    // 5. Get the total number of characters of 
            //    // //all words in dictionary_english.txt 
            //    // //(Read dictionary_english.txt into Array of String First). 

            //    // Use ListGenerators.cs & Customers.xml 
            //    // 6. Get the total units in stock for each product category. 
            //    var result4_6 = ListGenerators.ProductList.GroupBy(p=>p.Category)
            //    .Sum(group=>group.UnitsInStock);
            //    // 7. Get the length of the shortest 
            //    // //word in dictionary_english.txt 
            //    // //(Read dictionary_english.txt into Array of String First). 

            //    // Use ListGenerators.cs & Customers.xml 
            //    // 8. Get the cheapest price among each category's products 
            //    var result4_8 = ListGenerators.ProductList
            //                    .GroupBy(p => p.Category)                     
            //                    .Select(group => new                              
            //                    {
            //                        Category = group.Key,                         
            //                        CheapestPrice = group.Min(p => p.UnitPrice)  
            //                    });

            //    // 5 LINQ - Ordering Operators 
            //    // Use ListGenerators.cs & Customers.xml 
            //    // 1. Sort a list of products by name 
            //    var result5_1 = ListGenerators.ProductList.OrderBy(p => p.ProductName);

            //    // 2. Uses a custom comparer to do a 
            //    // //case-insensitive sort of the words in an array. 
            //    string[] Arr5= { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }; 
            //    var result5_2 = Arr5.OrderBy(s=>s.StringComparer.OrdinalIgnoreCase);


            //    // Use ListGenerators.cs & Customers.xml 
            //    // 3. Sort a list of products by units in stock from highest to lowest. 
            //    var result5_3 = ListGenerators.ProductList
            //                .OrderByDescending(p => p.UnitsInStock);
            //    // 4. Sort a list of digits, first by length of their name, 
            //    // //and then alphabetically by the name itself. 
            //    string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
            //    var result5_4 = Arr4.OrderBy(w=>w.Length).ThenBy(a=>a);
            //    // 5. Sort first by word length and then by a case-insensitive sort 
            //    // //of the words in an array. 
            //    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }; 
            //    var result5_5 = words
            //            .OrderBy(w => w.Length)                         
            //            .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);


            //    // Use ListGenerators.cs & Customers.xml 
            //    // 6. Sort a list of products, first by category, 
            //    // //and then by unit price, from highest to lowest. 
            //    var result6 = ListGenerators.ProductList
            //                                .OrderBy(p => p.Category)              
            //                                .ThenByDescending(p => p.UnitPrice); 
            //    // 7. Sort first by word length and 
            //    // //then by a case-insensitive descending sort of the words in an array. 
            //    string[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }; 
            //    var result7 = Arr7
            //                    .OrderBy(w => w.Length) 
            //                    .ThenByDescending(w => w.ToLower());
            //    // 8. Create a list of all digits in the array ظ
            //    // //hose second letter is 'i' that is /// index 1 
            //    // //reversed from the order in the original array. 
            //    string[] Arr8 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 

            //    var result5_8 = Arr8.Where(e=>e.ElementAtOrDefault(1)=='i').reverse();

            //// 6-LINQ - Partitioning Operators take , skip ,takeWhile , skipWhile
            //// Use ListGenerators.cs & Customers.xml 
            //// 1. Get the first 3 orders from customers take(3)
            //// // in Washington Where
            //var result6_1 =ListGenerators.CustomerList.Where(c=>c.City=="Washington")
            //                            .SelectMany(o=>o.Orders).Take(3); // 3 customer in washington
            //// 2. Get all but the first 2 orders from customers in Washington. 
            //var result6_2 =ListGenerators.CustomerList.Where(c=>c.City=="Washington")
            //                            .SelectMany(o=>o.Orders).Skip(2);
            //// 3. Return elements starting from the beginning of the array 
            //// //until a number is hit that is less than its position in the array. 
            //int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            //var result6_3 = numbers3.TakeWhile((n,i)=>n >=i)
            //// 4. Get the elements of the array starting from 
            //// //the first element divisible by 3. 
            //int[] numbers4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            // var result6_4 = numbers4.TakeWhile((n)=>n%3==0)
            // int[] numbers4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            // var result6_4 = numbers4.SkipeWhile((n)=>n%3 != 0)
            //// 5. Get the elements of the array starting 
            //// //from the first element less than its position. 
            //int[] numbers5 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            //var result6_3 = numbers3.SkipWhile((n,i)=>n >=i)


            //// LINQ 7- Projection Operators 
            //// Use ListGenerators.cs & Customers.xml 
            //// 1. Return a sequence of just the names of a list of products. 
            //var result7_1 = ListGenerators.GetProducts()
            //                         .Select(p => p.ProductName);
            //// 2. Produce a sequence of the uppercase //
            //// and lowercase versions of each word in the original array (Anonymous Types). 
            //  string[] words2 = { "aPPLE", "BlUeBeRrY", "cHeRry" }; 
            //var res = words.Select(w=>new
            //{
            //    upper=w.ToUpper();
            //    lower=w.ToLower();
            //});
            ////Use ListGenerators.cs & Customers.xml 
            //// 3. Produce a sequence containing some properties of Products, 
            //// //including UnitPrice which is renamed to Price in the resulting type. 
            //var result7_3= ListGenerators.ProductList
            //        .Select(p => new
            //        {
            //            p.ProductID,
            //            p.ProductName,
            //            Price = p.UnitPrice, 
            //            p.Category
            //        });

            //// 4. Determine if the value of ints in an array match their position in the array. 
            //int[] Arr44 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 
            // var result7_5 = Arr44.Select((value, index) => new
            //                {
            //                    Number = value,
            //                    position = value == index
            //                });
            //// Result 
            //// Number: In-place? 
            //// 5: False 
            //// 4: False 
            //// 1: False 
            //// 3: True 
            //// 9: False 
            //// 8: False 
            //// 6: True 
            //// 7: True 
            //// 2: False 
            //// 0: False 



            //// 5. Returns all pairs of numbers from both arrays such that the number 
            //// //from numbersA is less than the number from numbersB. a<B=>a,b
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }; 
            //int[] numbersB = { 1, 3, 5, 7, 8 }; 
            //var pairs = numbersA.SelectMany(a => num_in_B,
            //                            (a, b) => new { A = a, B = b })
            //                .Where(pair => pair.A < pair.B);

            //// Result 

            //// Pairs where a < b: 
            //// 0 is less than 1 
            //// 0 is less than 3 
            //// 0 is less than 5 
            //// 0 is less than 7 
            //// 0 is less than 8 
            //// 2 is less than 3 
            //// 2 is less than 5 
            //// 2 is less than 7 
            //// 2 is less than 8 
            //// 4 is less than 5 
            //// 4 is less than 7 
            //// 4 is less than 8 
            //// 5 is less than 7 
            //// 5 is less than 8 
            //// 6 is less than 7 
            //// 6 is less than 8 



            //// Use ListGenerators.cs & Customers.xml 
            //// 6. Select all orders where the order total is less than 500.00. 
            //var result7_2 =ListGenerators.CustomerList
            //            .SelectMany(c => c.Orders)
            //            .Where(o => o.Total < 500); 
            //// 7. Select all orders where the order was made in 1998 or later. 
            //    var recentOrdersresult7_1 = ListGenerators.CustomerList
            //             .SelectMany(c => c.Orders)
            //             .Where(o => o.OrderDate.Year >= 1998);

            //// LINQ - Quantifiers 
            //// 1. Determine if any of the words in dictionary_english.txt 
            //// //(Read dictionary_english.txt into Array of String First) 
            //// //contain the substring 'ei'. 
            //string[] words = System.IO.File.ReadAllLines("Read dictionary_english.txt");
            //bool isContainEi =words.Any(word=>word.Contains("ei"));


            //// Use ListGenerators.cs & Customers.xml 
            //// 2. Return a grouped a list of products only for categories 
            //// //that have at least one product that is out of stock. any unitinstock==0
            //var result = ListGenerators.ProductList
            //                    .GroupBy(p => p.Category)
            //                    .Where(g => g.Any(p => p.UnitsInStock == 0));
            //// 3. Return a grouped a list of products only for categories 
            //// //that have all of their products in stock. 
            //var result = ListGenerators.ProductList
            //                        .GroupBy(p => p.Category)     
            //                        .Where(g => g.All(p => p.UnitsInStock > 0)); 

            //// LINQ - Grouping Operators 
            //// 1. Use group by to partition a list of numbers by their remainder 
            //// //when divided by 5 

            //var grouped = numbers.GroupBy(n => n % 5);

            //// 2. Uses group by to partition a list of words by their first letter. 
            //// Use dictionary_english.txt for Input 

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var groupedWords = words.GroupBy(word => word[0]);
            //foreach (var group in groupedWords)
            //        {
            //            Console.WriteLine($"start '{group.Key}':");
            //            foreach (var word in group)
            //            {
            //                Console.WriteLine(word);
            //            }
            //            Console.WriteLine();
            //        }

            //// 3. Consider this Array as an Input  
            // string[] Arrr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " }; 
            //// Use Group By with a custom comparer 
            //// //that matches words that are consists of the same Characters Together 

            //// Result 

            //// ... 
            //// from  
            //// form  
            //// ... 
            //// salt 
            //// last  
            //// ... 
            //// earn  
            //// near 























        }
    }
            }
