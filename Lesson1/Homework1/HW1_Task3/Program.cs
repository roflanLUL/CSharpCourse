using System;

namespace HW1_Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the symbol: ");
            var symbol = Console.Read();
            var nextSymbol = (char) (symbol + 1);
            Console.WriteLine($"The next symbol is {nextSymbol}");
        }
    }
}