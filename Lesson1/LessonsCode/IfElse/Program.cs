using System;

namespace IfElse
{
    class Program
    {
        static void Main()
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            if (int.TryParse(a, out var intA) == false) Environment.Exit(0);
            if (int.TryParse(b, out var intB) == false) Environment.Exit(0);
            var sum = intA + intB;
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}