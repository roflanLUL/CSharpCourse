using System;

namespace Methods_Task1
{
    class Program
    {
        static double z(double x, double y)
        {
            if (x > y)
            {
                return 5.0 * x + y;
            }

            if (x == y)
            {
                return Math.Cos(x);
            }

            if (y-10 < x && x < y)
            {
                return -2.0 * Math.Sin(y);
            }

            if (x <= y - 10)
            {
                return 0.0;
            }
            return 0.0;
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
