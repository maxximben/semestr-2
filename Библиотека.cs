using System;
using System.Collections.Generic;
class Program
{
	static void Main(string[] args)
	{
		List<Book> library = new List<Book>();
		Book book1 = new Book("Пушкин", "Руслан и Людмила", "2017", "Питер");
		book1.addMovement("19.05.2025"); // взята

		Book book2 = new Book("Толстой", "Война и мир", "2012", "Просвещение");
		book2.addMovement("10.05.2025", "17.05.2025");
		book2.addMovement("31.05.2025", "02.06.2025"); // в библиотеке

        Book book3 = new Book("Лермонтов", "Герой нашего времини", "2016", "Просвещение"); // в библиотеке

        Book book4 = new Book("Достоевский", "Преступление и наказание", "2010", "Питер");
		book4.addMovement("16.05.2025"); // взята

		library.Add(book1);
		library.Add(book2);
		library.Add(book3);
		library.Add(book4);


		while (true)
		{
			Console.WriteLine("Меню:");
			Console.WriteLine("1. Выбрать книги, которые не были на руках");
			Console.WriteLine("2. Выбрать книги, которые не сданы в библиотеку");
			Console.WriteLine("3. Выбрать книги, которые сданы в библиотеку");
			Console.WriteLine("4. Выход");


			string key = Console.ReadLine();

			if (key == "4")
			{
				Environment.Exit(0);
			}

			else if (key == "1")
			{
				for (int i = 0; i < library.Count; i++)
				{
					if (library[i].movements.Count == 0)
					{
						library[i].printBook();
					}
				}
			}

			else if (key == "2")
			{
				for (int i = 0; i < library.Count; i++)
				{
                    if (library[i].isInLibrary() == false)
					{
						library[i].printBook();
						library[i].printMovements();					
					}
					

				}
			}

            else if (key == "3")
            {
                for (int i = 0; i < library.Count; i++)
                {
                    if (library[i].isInLibrary() == true)
                    {
                        library[i].printBook();
                        library[i].printMovements();
                    }
                }
            }
        }
    }
}


struct Book
{
	private string authorName;
	private string title;
	private string year;
	private string publishing;
	public List<string> movements;

	public Book(string authorName, string title, string year, string publishing)
	{
		this.authorName = authorName;
		this.title = title;
		this.year = year;
		this.publishing = publishing;
		movements = new List<string>();
	}

	public void printBook()
	{
        Console.WriteLine($"Автор: {authorName}");
        Console.WriteLine($"Название: {title}");
		Console.WriteLine($"Год издания: {year}");
        Console.WriteLine($"Издательство: {publishing}");
	}

	public bool isInLibrary()
	{
		return movements.Count % 2 == 0;
	}
	public void addMovement()
	{
		Console.Write("Введи дату взятия книги: ");
		movements.Add(Console.ReadLine());
		Console.WriteLine("Книга возвращена? (да/нет)");
		if (Console.ReadLine().Equals("да"))
		{
			Console.Write("Введите дату возврата книги: ");
			movements.Add(Console.ReadLine());
		}	
	}

	public void printMovements()
	{ 
		for (int i = 0; i < movements.Count; i++)
		{
			if (i % 2 == 0) {
				Console.WriteLine($"Дата выдачи: {movements[i]}");
			} else {
				Console.WriteLine($"Дата сдачи: {movements[i]}");
			}
		}
        Console.WriteLine();
	}

	public void addMovement(string date1)
	{
		movements.Add(date1);
	}

	public void addMovement(string date1, string date2)
	{
		movements.Add(date1);
		movements.Add(date2);
	}
}
