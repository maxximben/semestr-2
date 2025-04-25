using System;
using System.IO;
using System.Collections.Generic;


namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)

        {

            string filePath = "input.txt";

            
            string[] input = File.ReadAllLines(filePath);
            
            Console.WriteLine("Считано из файла:");
            foreach (string str in input)
            {
                Console.WriteLine(str);
            }


            List<string> output = new List<string>();


            for (int i = 0; i < input.Length; i++)
            {

                string currentNumber = "";
                
                int j = 0;
                foreach (char c in input[i])
                {
                    if (char.IsDigit(c))
                    {
                        currentNumber += c;
                        if (j == input[i].Length - 1 && currentNumber.Length > 0 && int.Parse(currentNumber) % 2 == 0)
                        {
                            output.Add(input[i]);currentNumber = "";
                        }
                    }
                    else
                    {
                        if (currentNumber.Length > 0)
                        {
                            if (int.Parse(currentNumber) % 2 == 0)
                            {
                                output.Add(input[i]);
                            }
                            currentNumber = "";
                        }
                    }
                    j++;
                }
            }

            Console.WriteLine();

            File.WriteAllLines("output.txt", output);

            Console.WriteLine("Записано в файл:");
            foreach (string str in output)
            {
                Console.WriteLine(str);
            }
        }
    }
}
