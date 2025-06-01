using System;

unsafe class Program
{
    unsafe static void Main()
    {
        Product obj1 = new Product(2435, "Мука");
        Product* head = &obj1;

        Product obj2 = new Product(7887, "Соль");
        Product obj3 = new Product(2234, "Хлеб");
        Product obj4 = new Product(1232, "Спички");
        Product obj5 = new Product(3423, "Сахар");

        SelectBranch(head, &obj2);
        SelectBranch(head, &obj3);
        SelectBranch(head, &obj4);
        SelectBranch(head, &obj5);

        Console.WriteLine("Бинарное дерево");
        PrintTree(head);
    }

    public static void SelectBranch(Product* Product1, Product* Product2)
    {
        if (Product2->ID < Product1->ID)
        {
            if (Product1->Left == null)
            {
                Product1->Left = Product2;
            }
            else
            {
                SelectBranch(Product1->Left, Product2);
            }
        }
        else
        {
            if (Product1->Right == null)
            {
                Product1->Right = Product2;
            }
            else
            {
                SelectBranch(Product1->Right, Product2);
            }
        }
    }

    public static void PrintTree(Product* Product, string branch = "Корень")
    {
        if (Product != null)
        {
            if (Product->Left != null)
            {
                PrintTree(Product->Left, "Левая");
            }

            Console.WriteLine($"ID: {Product->ID}, Наименование: {Product->Name}, Ветвь: {branch}");

            if (Product->Right != null)
            {
                PrintTree(Product->Right, "Правая");
            }
        }
    }
}
unsafe struct Product
{
    public int ID;
    public string Name;
    public Product* Left;
    public Product* Right;

    public Product(int ID, string name, Product* left = null, Product* right = null)
    {
        this.ID = ID;
        Name = name;
        Left = left;
        Right = right;
    }
}
