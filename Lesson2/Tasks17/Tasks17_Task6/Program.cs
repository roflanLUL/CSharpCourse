using System;

namespace Tasks17_Task6
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var maxim = 1233;
            for (int i = 1234; i <= 8765; ++i)
            {
                if ((i % 27 == 0) && (i % 4 != 0) && (i % 72 != 0) && (i % 81 != 0) && (i % 128 != 0))
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
