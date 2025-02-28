using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введи строку:");
        string str = Console.ReadLine();

        char[] charArray = str.ToCharArray();

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] == '(')
            {
                stack.Push(charArray[i]);
            }
            else if (charArray[i] == '{')
            {
                stack.Push(charArray[i]);
            }
            else if (charArray[i] == '[')
            {
                stack.Push(charArray[i]);
            }
            else if (charArray[i] == ')')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Скобки расставлены неправильно");
                    Environment.Exit(0);
                }
                if (stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("Скобки расставлены неправильно");
                    Environment.Exit(0);
                }
            }
            else if (charArray[i] == ']')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Скобки расставлены неправильно");
                    Environment.Exit(0);

                }
                if (stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("Скобки расставлены неправильно");
                    Environment.Exit(0);
                }
            }
            else if (charArray[i] == '}')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Скобки расставлены неправильно");
                    Environment.Exit(0);
                }
                if (stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine("Скобки расставлены неправильно");
                    Environment.Exit(0);
                }
            }
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("Скобки расставлены правильно");
        }

        else
        {
            Console.WriteLine("Скобки расставлены неправильно");
        }

        /*Console.WriteLine("Элементы стека :");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }*/
    }
}
