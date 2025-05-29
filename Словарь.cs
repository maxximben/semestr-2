using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Phone phone6 = new Phone("3338", "Николай", "мтс");
        Phone phone1 = new Phone("111", "Иван", "билайн");
        Phone phone3 = new Phone("222", "Леха", "билайн");
        Phone phone4 = new Phone("2322", "Алексей", "теле2");
        Phone phone5 = new Phone("333", "Сергей", "мтс");
        Phone phone2 = new Phone("1141", "Ваня", "мегафон");

        List<Phone> data = new List<Phone>{ phone1, phone2, phone3, phone4, phone5, phone6 };

        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach (Phone phone in data) 
        {
            if (frequency.ContainsKey(phone.provider))
            {
                frequency[phone.provider]++;
            }
            else
            {
                frequency[phone.provider] = 1;
            }
        }

        foreach (var pair in frequency) 
        {
            Console.WriteLine($"Оператор: {pair.Key}\nЧастота: {pair.Value}\n");
        }
    }
}

class Phone
{
    public string number;
    public string name;
    public string provider;

    public Phone(string number, string name, string provider)
    {
        this.number = number;
        this.name = name;
        this.provider = provider;
    }
}


