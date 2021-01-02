using System;

namespace Tasks17_Task4
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 9999;
            for (int i = 10000; i <= 100000; ++i)
            {
                if ((i % 23 == 0) && (i % 5 != 0) && (i % 6 != 0) && (i % 7 != 0) && (i % 8 != 0))
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
