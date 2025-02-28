using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    const int MaxSubscribers = 100;

    static void Main(string[] args)
    {

        Subscriber[] subscribers = new Subscriber[MaxSubscribers];
        int count = 0;

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Ввод данных");
            Console.WriteLine("2. Выборка по ФИО");
            Console.WriteLine("3. Выборка по оператору");
            Console.WriteLine("4. Выборка по номеру телефона");
            Console.WriteLine("5. Выход");

            Console.WriteLine("Выберите опцию");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    count = FillData(subscribers, count);
                    break;
                case 2:
                    FilterByName(subscribers, count);
                    break;
                case 3:
                    FilterByOperator(subscribers, count);
                    break;
                case 4:
                    FilterByNumber(subscribers, count);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }




    }

    static void print_array(string[] arr)
    {
        Console.Write("\n");
        for (int i = 0; i < arr.Length; i++)
        {

            Console.WriteLine(arr[i]);
        }
    }

    static void FilterByName(Subscriber[] subs, int count)
    {
        Console.WriteLine("Введите имя абонента");
        string nm = Console.ReadLine();

        Console.WriteLine();


        for (int i = 0; i < count; i++)
        {
            if (subs[i].name == nm)
            {
                Console.Write("Имя: ");
                Console.WriteLine(subs[i].name);
                
                Console.Write("Город: ");
                Console.WriteLine(subs[i].city);

                Console.WriteLine("Номера:");
                for (int j = 0; j < subs[i].phones.Length; i++)
                {
                    Console.WriteLine(subs[i].phones[j].number);
                    Console.WriteLine(subs[i].phones[j].year);
                }

                Console.WriteLine();
            }
        }


    }
    static void FilterByOperator(Subscriber[] subs, int count)
    {
        Console.WriteLine("Введите название оператора: ");
        string op = Console.ReadLine();
        Console.WriteLine();

        for (int i = 0; i < count; i++)
        {
            for (int k = 0; k < subs[i].phones.Length; k++)
            {
                if (subs[i].phones[k].operatr == op)
                {
                    Console.Write("Имя: ");
                    Console.WriteLine(subs[i].name);

                    Console.Write("Город: ");
                    Console.WriteLine(subs[i].city);

                    Console.WriteLine("Номера:");
                    for (int j = 0; j < subs[i].phones.Length; i++)
                    {
                        Console.WriteLine(subs[i].phones[j].number);
                        Console.WriteLine(subs[i].phones[j].year);
                    }

                    Console.WriteLine();
                }
            }
            
        }


    }

    static void FilterByNumber(Subscriber[] subs, int count)
    {
        Console.WriteLine("Введите номер: ");
        string num = Console.ReadLine();
        Console.WriteLine();


        for (int i = 0; i < count; i++)
        {
            for (int k = 0; k < subs[i].phones.Length; k++)
            {
                if (subs[i].phones[k].number == num)
                {
                    Console.Write("Имя: ");
                    Console.WriteLine(subs[i].name);

                    Console.Write("Город: ");
                    Console.WriteLine(subs[i].city);

                    Console.WriteLine("Номера:");
                    for (int j = 0; j < subs[i].phones.Length; i++)
                    {
                        Console.WriteLine(subs[i].phones[j].number);
                        Console.WriteLine(subs[i].phones[j].year);
                    }

                    Console.WriteLine();
                }
            }
        }
    }

    static int FillData(Subscriber[] subscribers, int count)
    {
        while (count < MaxSubscribers)
        {
            Console.WriteLine("Введите данные для абонента (или нажмите Enter для завершения):");
            Console.WriteLine("ФИО:");


            string subscriberName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(subscriberName)) break;


            Console.Write("Введите количество номеров: ");
            int n = Int32.Parse(Console.ReadLine());
            Phone[] phones = new Phone[n];
            

            for (int i = 0; i < n; i++)
            {
                
                Console.Write("Введите " + (i + 1) + " номер телефона: ");
                string nm = Console.ReadLine();
                Console.WriteLine("Оператор: ");
                string op = Console.ReadLine();
                Console.WriteLine("Год подключения: ");
                string yr = Console.ReadLine();
                
                phones[i] = new Phone(nm, op, yr);
            }

            Console.WriteLine("Город: ");
            string city = Console.ReadLine();

     
            subscribers[count++] = new Subscriber(subscriberName, city, phones);
        }
        return count;

    }

}

class Subscriber
{
    public string name;
    public string city;
    public Phone[] phones;



    public Subscriber(string Name, string City, Phone[] Phones)
    {
        name = Name;
        city = City;
        phones = Phones;
    }
}

class Phone
{
    public string number;
    public string operatr;
    public string year;

    public Phone(string Number, string Operatr, string Year)
    {
        number = Number;
        operatr = Operatr;
        year = Year;
    }
}
