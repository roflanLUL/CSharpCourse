using System;

namespace Methods_Task5
{
    class Program
    {
        static int z(int x, int y)
        {
            var ret = 2 * f(x) + 4 * f(y);

            return ret;
        }

        static int f(int x)
        {
            if (x >= 0)
            {
                return 5 * x;
            }

            if (x < 0)
            {
                return -2 * x;
            }

            return 0;
        }

        static void Main()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var ans = z(x, y);

            Console.WriteLine(ans);
        }
    }
}
