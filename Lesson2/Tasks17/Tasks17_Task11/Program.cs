using System;

namespace Tasks17_Task11
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 72;
            var x = 157080;
            for (int i = 73; i <= 5578; ++i)
            {
                if (x % i == 0)
                {
                    if (i % 10 == x % 10)
                    {
                        if (i > maxim)
                        {
                            maxim = i;
                        }
                    }
                    cnt++;
                }
            }
            Console.WriteLine($"{cnt} {maxim}");
        }
    }
}
