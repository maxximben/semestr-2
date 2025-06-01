using System;

delegate int Delegate(ref int a, int b);
class Equation
{
    public int A { get; set; }
    public int B { get; set; }
    public Equation(int a, int b)
    {
        A = a;
        B = b;
    }

    public static int Sum(ref int A, int B)
    {
        A = A + B;
        return A;
    }

    public static int Difference(ref int A, int B)
    {
        A = A - B;
        return A;
    }

    public static int Composition(ref int A, int B)
    {
        A = A * B;
        return A;
    }

    public static int Division(ref int A, int B)
    {
        if (B != 0) 
        { 
            A = A / B; return A; 
        }
        else 
        { 
            Console.WriteLine("деление на 0"); return 0; 
        }
    }
}

class Program
{
    static void Main()
    {
        Equation element1 = new Equation(578, 710);
        int a1 = element1.A;
        int b1 = element1.B;

        Delegate m1 = Equation.Sum;
        m1 += Equation.Composition;
        m1 += Equation.Difference;
        int result_1 = m1(ref a1, b1);

        Console.WriteLine("Результат_1 = {0}", result_1);

        Equation element2 = new Equation(568, 49);
        int a2 = element2.A;
        int b2 = element2.B;

        Delegate m2 = Equation.Difference;
        m2 += Equation.Division;
        m2 += Equation.Composition;
        int result_2 = m2(ref a2, b2);

        Console.WriteLine("Результат_2 = {0}", result_2);
    }
}
