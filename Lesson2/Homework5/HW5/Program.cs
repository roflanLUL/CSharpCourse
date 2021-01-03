using System;

namespace HW5
{
    class Program
    {   
        static void Main(string[] args)
        {
            var isArg = false;

            if (args.Length == 3) {
                isArg = true;
            }

            var a = TryGetNumber("A", 0);
            var b = TryGetNumber("B", 1);
            var c = TryGetNumber("C", 2);

            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The coefficient A cannot be zero in a quadratic equation.");
                Console.ForegroundColor = ConsoleColor.Gray;

                if (!isArg)
                {
                    Main(args);
                }
                Environment.Exit(0);
            }

            var d = b * b - 4 * a * c;

            if (d <= 0)
            {
                var x = -b / (2.0 * a);

                if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There are no roots.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"X = {x}.");
                }
            }
            else
            {
                var x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                var x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"X1 = {x1}.\nX2 = {x2}.");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            int TryGetNumber(string message, int i)
            {
                var value = "";

                if (!isArg)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write($"Enter the coefficient {message}: ");
                    value = Console.ReadLine();
                }
                else
                {
                    value = args[i];
                }
                try
                {
                    if (int.TryParse(value, out var number) == false)
                    {
                        throw new FormatException();
                    }
                    return number;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered incorrect data!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    if (!isArg)
                    {
                        TryGetNumber(message, i);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                return 0;
            }
        }
    }
}
