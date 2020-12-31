using System;

namespace Methods_Task4
{
    class Program
    {
        static double f(double a, double b)
        {
            var ret = a * 2 + b / 5 + Math.Sin(a + b);

            return ret;
        }

        static double z(double x, double y)
        {
            var ret = f(x, 0) + 2 * f(y, 1) + 2 * f(x, y);

            return ret;
        }
        static void Main()
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var ans = z(x, y);

            Console.WriteLine(ans);
        }
    }
}
