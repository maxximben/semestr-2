using System;
class Interface
{
    static void Main(string[] args)
    {
        Square square = new Square(6, "Квадрат");
        Triangle triangle = new Triangle(7, "Треугольник");
        Sircle sircle = new Sircle(9, "Окружность");

        Console.WriteLine($"Name: {square.name}\nPerimetr: {square.getPerimetr()}\nSquare: {square.getSquare()}\n");
        Console.WriteLine($"Name: {triangle.name}\nPerimetr: {triangle.getPerimetr()}\nSquare: {triangle.getSquare()}\n");
        Console.WriteLine($"Name: {sircle.name}\nPerimetr: {sircle.getPerimetr()}\nSquare: {sircle.getSquare()}\n");
    }
}

interface ICalculate
{
    double getPerimetr();
    double getSquare();
}
class Figure
{
    public string name;
}

class Square : Figure, ICalculate
{
    int a;
    public Square(int a, string name)
    {
        this.a = a;
        this.name = name;
    }

    public double getPerimetr()
    {
        return a * 4;
    }

    public double getSquare()
    {
        return a * a;
    }
}

class Triangle : Figure, ICalculate
{
    int a;

    public Triangle(int a, string name)
    {
        this.a = a;
        this.name = name;
    }

    public double getPerimetr()
    {
        return a * 3;
    }

    public double getSquare()
    {
        return Math.Sqrt(3) / 4 * Math.Pow(a, 2);
    }

}

class Sircle : Figure, ICalculate
{
    int r;

    public Sircle(int r, string name)
    {
        this.r = r;
        this.name = name;
    }
    public double getPerimetr()
    {
        return 2 * Math.PI * r;
    }

    public double getSquare()
    {
        return Math.PI * r * r;
    }
}
