using System;

namespace Tasks17_Task3
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 9012;
            for (int i = 9013; i <= 23800; ++i)
            {
                if ((i % 9 == 0) && (i % 2 != 0) && (i % 6 != 0) && (i % 12 != 0) && (i % 81 != 0))
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
