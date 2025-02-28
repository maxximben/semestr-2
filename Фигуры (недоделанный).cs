using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {

       

    }
}


class Figure
{
    public string name;

    public Figure(string Name)
    {
        name = Name;   
    }
}

class Circle : Figure
{
    public double radius;

    public Circle(string Name, double Radius) : base (Name)
    {
        name = Name;
        radius = Radius;
    }
}

class Square : Figure
{
    public double length;

    public Square(string Name, double Len) : base(Name) 
    {
        name = Name;
        length = Len;
    }
}

class Triangle : Figure
{
    public double length;

    public Triangle(string Name, double Len) : base(Name) 
    {
        name = Name;
        length = Len;
    }
}
