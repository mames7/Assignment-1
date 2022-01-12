using System.Linq;
using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            
            var Substrings =
                from i in Enumerable.Range(0, inputString.Length)
                from j in Enumerable.Range(0, inputString.Length - i + 1)
                where j >= 1
                select inputString.Substring(i, j);

            //Print the array 
            Console.WriteLine();
            Console.WriteLine("All substrings for given string are : ");
            foreach (string substring in Substrings)
            {
                Console.Write(substring + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("All Unique substrings for given string are : ");
            foreach (string substring in Substrings.Distinct())
            {
                Console.Write(substring + " ");
            }
            Console.ReadKey();
        }
    }
}