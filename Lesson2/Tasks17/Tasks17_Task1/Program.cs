using System;

namespace Tasks17_Task1
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 2076;
            for (int i = 2077; i <= 8276; ++i)
            {
                if ((i % 6 == 0) && (i % 4 != 0) && (i % 9 != 0) && (i % 20 != 0) && (i % 36 != 0))
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
