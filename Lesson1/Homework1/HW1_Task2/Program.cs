using System;

namespace HW1_Task2
{
    class Program
    {
        static void Main()
        {
            var dividend = TryGetNumber("divisible value");
            var divider = TryGetNumber("divisor");
            
            Console.WriteLine(divider == 0 ? "You can't divide by zero!" : $"Result: {dividend / divider}");
            
            int TryGetNumber(string message)
            {
                Console.Write($"Enter the {message}: ");
                var value = Console.ReadLine();
                
                if (int.TryParse(value, out var number) == false)
                    throw new FormatException("You entered incorrect data!");

                return number;
            }
        }
    }
}