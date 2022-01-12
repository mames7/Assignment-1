using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            foreach (char c in originalString)
            {
                reverseString = c + reverseString;
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }      
    }
}