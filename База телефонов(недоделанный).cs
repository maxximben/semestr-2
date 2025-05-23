using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("111", "Иван", "2017", "билайн");
            Phone phone2 = new Phone("222", "Леха", "2023", "билайн");
            Phone phone3 = new Phone("333", "Сергей", "2015", "мтс");

            List < Phone > data = new List<Phone>();
            data.Add(phone1);
            data.Add(phone2);
            data.Add(phone3); 

            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("1. Выборка по ФИО\n" +
                                  "2. Выборка по номеру телефона\n" +
                                  "3. Выдать все данные, сгрупированные по оператору связи\n" +
                                  "4. Выдать все данные, сгрупированные по году выпуска\n" +
                                  "5. Выход");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 5:
                        Environment.Exit(0);
                        break;

                    
                }

            }

        }

    }

    class Phone
    {
        public string number;
        public string name;
        public string date;
        public string provider;

        public Phone(string number, string name, string date, string provider)
        {
            this.number = number;
            this.name = name;
            this.date = date;
            this.provider = provider;
        }


    }


}
