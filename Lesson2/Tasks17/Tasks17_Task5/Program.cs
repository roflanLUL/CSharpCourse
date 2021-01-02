using System;

namespace Tasks17_Task5
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 29383;
            for (int i = 29384; i <= 48493; ++i)
            {
                if ((i % 78 == 0) && (i % 7 != 0) && (i % 8 != 0) && (i % 12 != 0) && (i % 80 != 0))
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
