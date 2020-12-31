using System;

namespace Methods_Task7
{
    class Program
    {
        static double Add(double x, double y)
        {
            var sum = x + y;

            return sum;
        }

        static double Sub(double x, double y)
        {
            var res = x - y;

            return res;
        }
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var sum = Add(x, y);
            var res = Sub(x, y);

            Console.WriteLine(sum);
            Console.WriteLine(res);
        }
    }
}
