using System;
using System.Collections.Generic;

class Phone
{
    public string Number;
    public string FullName;
    public string Operator;

    public Phone(string number, string fullName, string operatorName)
    {
        Number = number;
        FullName = fullName;
        Operator = operatorName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Phone> phones = new List<Phone>
        {
            new Phone("45456245", "иванов", "мтс"),
            new Phone("2452456245", "петров", "билайн"),
            new Phone("2456546", "сидоров", "мтс"),
            new Phone("245624562456", "алексеев", "мегафон"),
            new Phone("2454256456", "николаев", "мтс")
        };

        
        Dictionary<string, int> operatorFrequency = new Dictionary<string, int>();

        
        foreach (Phone phone in phones)
        {
            if (operatorFrequency.ContainsKey(phone.Operator))
            {
                operatorFrequency[phone.Operator]++;
            }
            else
            {
                operatorFrequency[phone.Operator] = 1;
            }
        }

        Console.WriteLine("Частота использования операторов связи:");
        foreach (var pair in operatorFrequency)
        {
            Console.WriteLine("Оператор: " + pair.Key + "\nКоличество: " + pair.Value);
        }
    }
}
