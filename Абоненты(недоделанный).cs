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


            }
        }
        
        


    }


    static int FillData(Subscriber[] subscribers, int count)
    {
        while (count < MaxSubscribers)
        {
            Console.WriteLine("Введите данные для абонента (или нажмите Enter для завершения):");
            Console.WriteLine("ФИО:");

            string subsctiberName = Console.ReadLine();


            Console.WriteLine("Номер телефона:");
            string subscriberNumber = Console.ReadLine();

            subscribers[count++] = new Subscriber(subsctiberName, subscriberNumber);
        }
        return count;

    }
    
}

class Subscriber {
    public string name = "ФИО";
    public string number = "88005553535";

    public Subscriber(string Name, string Number)
    {
        name = Name;
        number = Number;
    }

}
