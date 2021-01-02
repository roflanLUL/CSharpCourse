using System;

namespace Tasks17_Task8
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 1567;
            for (int i = 1568; i <= 9956; ++i)
            {
                if (((int)Math.Sqrt(i) * (int)Math.Sqrt(i) == i) && (i % 9 != 0) && (i % 25 != 0))
                {
                    if (i > maxim)
                    {
                        maxim = i;
                    }
                    cnt++;
                }
            }
            Console.WriteLine($"{cnt} {maxim}");
        }
    }
}
