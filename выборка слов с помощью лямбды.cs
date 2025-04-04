using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "огурец", "дерево", "груша", "арбуз", "апельсин" };

            List<string> result = new List<string>();

            Func<string, bool> startsWithA = word => word.StartsWith("а");

            foreach (string word in words)
            {
                if (startsWithA(word))
                {
                    result.Add(word);
                }
            }

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
