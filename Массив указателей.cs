using System;

namespace ConsoleApplication6
{
    class Program
    {
        unsafe static void Main()
        {
            int size = 10000;

            int* ptrs = stackalloc int[size];

           
            for (int i = 0; i < size; i++)
            {
                ptrs[i] = i+1;
            }

            for (int i = 0; i < size; i++)
            {
                if (IsPalindrome(ptrs[i]))
                {
                    Console.WriteLine(ptrs[i]);
                }
            }
        }

        static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
