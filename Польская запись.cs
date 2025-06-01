using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите выражение: ");
        string line = Console.ReadLine();
        string[] elements = line.Split();
        bool flag = true;

        Stack stack = new Stack();

        for (int i = 0; i < elements.Length; i++)
        {
            string element= elements[i];

            if (element != "*" & element != "+" & element != "-" & element != "/")
            {
                stack.Push(Convert.ToInt32(element));
            }

            else if ((element == "*" || element == "+" || element == "-" || element == "/") && stack.Count >= 2)
            {
                int a = (int)stack.Pop();
                int b = (int)stack.Pop();

                if (element == "*")
                {
                    stack.Push(a * b);
                }

                else if (element == "+")
                {
                    stack.Push(a + b);
                }

                else if (element == "/")
                {
                    if (a != 0) { stack.Push(b / a); }
                    else 
                    { 
                        flag = false; 
                    }
                }

                else if (element == "-")
                {
                    stack.Push(b - a);
                }
            }
        }

        if (stack.Count == 1 && flag)
        {
            foreach (int i in stack)
            {
                Console.WriteLine("Результат {0}", i);
            }
        }
        else 
        { 
            Console.WriteLine("Неверная форма записи"); 
        }
    }
}
