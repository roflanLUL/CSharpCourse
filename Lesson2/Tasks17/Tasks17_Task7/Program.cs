using System;

namespace Tasks17_Task7
{
    class Program
    {
        static void Main()
        {
            var maxim = 2764;
            var predmax = 2763;
            for (int i = 2765; i <= 9525; ++i)
            {
                if ((i % 205 == 0) && (i % 10 != 0) && (i % 16 != 0) && (i % 82 != 0))
                {
                    if (i > maxim)
                    {
                        predmax = maxim;
                        maxim = i;
                    }
                    else if (i > predmax)
                    {
                        predmax = i;
                    }
                }
            }
            Console.WriteLine($"{predmax} {maxim}");
        }
    }
}
