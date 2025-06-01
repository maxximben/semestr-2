using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { -8, 62, 45, 2234, 62, 9, 9, 9, 0, -6 };

        HashSet<int> set = new HashSet<int>(array);
        Console.WriteLine("Множество массива:");
        foreach (int element in set)
        {
            Console.Write("{0}, ", element);
        }
        Console.WriteLine();

        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        foreach (int element in array)
        {
            if (!dictionary.ContainsKey(element))
            {
                dictionary.Add(element, 1);
            }
            else
            {
                dictionary[element] += 1;
            }
        }

        ICollection<int> dict = dictionary.Keys;

        foreach (int i in dict)
        {
            Console.WriteLine("{0}: число повторений: {1}", i, dictionary[i]);
        }
    }

}
