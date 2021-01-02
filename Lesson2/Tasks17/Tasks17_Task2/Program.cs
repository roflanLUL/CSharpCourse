using System;

namespace Tasks17_Task2
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 1577;
            for (int i = 1578; i <= 6237; ++i)
            {
                if ((i % 4 == 0) && (i % 3 != 0) && (i % 16 != 0) && (i % 12 != 0) && (i % 8 != 0))
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
