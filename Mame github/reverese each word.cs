using System;
using System.Collections.Generic;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();

            Stack<char> charStack = new Stack<char>();

            // Traverse the given string and push all characters
            // to stack until we see a space.  
            for (int i = 0; i < originalString.Length; ++i)
            {
                if (originalString[i] != ' ')
                {
                    charStack.Push(originalString[i]);
                }

                // When seeing a space, then print contents of the stack.  
                else
                {
                    while (charStack.Count > 0)
                    {
                        Console.Write(charStack.Pop());
                    }
                    Console.Write(" ");
                }
            }

            // Since there may not be space after last word.  
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
            
            Console.ReadKey();
        }      
    }
}