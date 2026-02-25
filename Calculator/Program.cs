using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        Console.WriteLine("5 - Exit");

        Console.Write("Choose an option: ");
        byte id = byte.Parse(Console.ReadLine());
        switch (id)
        {
            case 1: Add(); break;
            case 2: Subtract(); break;
            case 3: Multiply(); break;
            case 4: Divide(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Add()
    {
        Console.Clear();
        Console.WriteLine("Sum");
        Console.Write("Enter first value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Enter second value: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 + v2);
        Console.ReadKey();
        Menu();
    }

    static void Subtract()
    {
        Console.Clear();
        Console.WriteLine("Subtract");
        Console.Write("Enter first value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Enter second value: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 - v2);
        Console.ReadKey();
        Menu();
    }

    static void Multiply()
    {
        Console.Clear();
        Console.WriteLine("Multiply");
        Console.Write("Enter first value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Enter second value: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 * v2);
        Console.ReadKey();
        Menu();
    }

    static void Divide()
    {
        Console.Clear();
        Console.WriteLine("Divide");
        Console.Write("Enter first value: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Enter second value: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.Write(v1 / v2);
        Console.ReadKey();
        Menu();
    }
}