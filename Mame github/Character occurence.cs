using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string message = Console.ReadLine();

            Dictionary<char, int> dict = message.Replace(" ", string.Empty)
                                         .GroupBy(c => c)
                                         .ToDictionary(gr => gr.Key, gr => gr.Count());

            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }

            Console.ReadKey();
        }
    }
}