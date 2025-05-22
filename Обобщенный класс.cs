using System;
class Program
{
    static void Main(string[] args)
    {
        int[] ints = { 1, 2, 3, 4, 5, 6 };
        string[] stings = { "a", "b", "c", "d", "e", "f" };
        Array<int> arr = new Array<int>(ints);
        Array<string> str = new Array<string>(stings);

        printArray(arr);
        printArray(str);

        arr.Append(7);
        str.Append("g");

        printArray(arr);
        printArray(str);

        arr.RemoveAt(2);
        str.RemoveAt(2);

        printArray(arr);
        printArray(str);
    }

    static void printArray<T>(Array<T> arr)
    {
        T[] array = arr.GetArray();
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}


class Array<T>
{
    private T[] array;
    public T[] GetArray() { return array; }
    public Array(T[] array)
    {
        this.array = array;
    }

    public void Append(T value)
    {
        T[] newArray = new T[array.Length + 1];
        for (int i = 0; i < newArray.Length - 1; i++)
        {
            newArray[i] = array[i];
        }
        newArray[array.Length] = value;
        array = newArray;
    }

    public void RemoveAt(int index)
    {
        T[] newArray = new T[array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }
        for (int i = index; i < array.Length - 1; i++)
        {
            newArray[i] = array[i + 1];
        }
        array = newArray;
    }
}
