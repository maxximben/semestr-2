using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введи строку:");
        string str = Console.ReadLine();

        char[] charArray = str.ToCharArray();
        
        Stack<char> stack1 = new Stack<char>();
        Stack<char> stack2 = new Stack<char>();
        Stack<char> stack3 = new Stack<char>();


        for (int i = 0; i < charArray.Length; i++) {
            
            if (charArray[i] == '(')
            {
                stack1.Push(charArray[i]);
            }
            else if (charArray[i] == '{')
            {
                stack2.Push(charArray[i]);
            }
            else if (charArray[i] == '[')
            {
                stack3.Push(charArray[i]);
            }
            else if (charArray[i] == ')' && stack1.Count > 0)
            {
                stack1.Pop();
            }
            else if (charArray[i] == '}' && stack2.Count > 0)
            {
                stack2.Pop();
            }
            else if (charArray[i] == ']' && stack3.Count > 0)
            {
                stack3.Pop();
            }

        }

        Console.WriteLine("Элементы стека1 :");
        foreach (var item in stack1)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Элементы стека2 :");
        foreach (var item in stack2)
        {
            Console.WriteLine(item);
        }
      
        Console.WriteLine("Элементы стека3 :");
        foreach (var item in stack3)
        {
            Console.WriteLine(item);
        }

        if (stack1.Count > 0 || stack2.Count > 0 || stack3.Count > 0){
            Console.WriteLine("Скобки расставлены неправильно");
        }
        else
        {
            Console.WriteLine("Сколби расставлены правильно");
        }

        
    }
}
