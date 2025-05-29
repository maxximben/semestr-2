using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Phone phone6 = new Phone("3338", "Николай", 2015, "мтс");
        Phone phone1 = new Phone("111", "Иван", 2017, "билайн");
        Phone phone3 = new Phone("222", "Леха", 2023, "билайн");
        Phone phone4 = new Phone("2322", "Алексей", 2023, "теле2");
        Phone phone5 = new Phone("333", "Сергей", 2015, "мтс");
        Phone phone2 = new Phone("1141", "Ваня", 2017, "мегафон");

        List<Phone> data = new List<Phone>();
        data.Add(phone6);
        data.Add(phone2);
        data.Add(phone3);
        data.Add(phone1);
        data.Add(phone4);
        data.Add(phone5);


        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("1. Выборка по ФИО\n" +
                                "2. Выборка по номеру телефона\n" +
                                "3. Выдать все данные, сгрупированные по году\n" +
                                "4. Выдать все данные, сгрупированные по оператору\n" +
                                "5. Выход");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 5:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Write("Введи ФИО: ");
                    string name = Console.ReadLine();
                    var users = from n in data where n.name == name select n;
                    foreach (var x in users)
                    {
                        x.printData();
                    }
                    break;

                case 2:
                    Console.Write("Введи номер: ");
                    string phone = Console.ReadLine();
                    var phones = from n in data where n.number == phone select n;
                    foreach (var x in phones)
                    {
                        x.printData();

                    }
                    break;
                case 3:
                    var years = from n in data group n by n.date into grouped select grouped;
                    foreach (var group in years)
                    {
                        foreach (var x in group)
                        {
                            Console.WriteLine($"Год выпуска: {group.Key}");
                            x.printData();
                            Console.WriteLine();

                        }
                    }
                    break;
                case 4:
                    var providers = from n in data group n by n.provider into grouped select grouped;
                    foreach (var group in providers)
                    {
                        foreach (var x in group)
                        {
                            x.printData();
                            Console.WriteLine();
                        }
                    }
                    break;
            }
        }
    }
}

class Phone
{
    public string number;
    public string name;
    public int date;
    public string provider;

    public Phone(string number, string name, int date, string provider)
    {
        this.number = number;
        this.name = name;
        this.date = date;
        this.provider = provider;
    }

    public void printData()
    {
        Console.WriteLine($"ФИО: {name}");
        Console.WriteLine($"Номер: {number}");
        Console.WriteLine($"Дата: {date}");
        Console.WriteLine($"Оператор: {provider}");   
    }
}
