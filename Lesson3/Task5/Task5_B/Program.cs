using System;

namespace Task5_B
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var line = new int[2];

            var maxim = -1;
            var maximp = -1;

            for (int i = 0; i < 2; ++i)
            {
                line[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 2; i < n; ++i)
            {
                var x = int.Parse(Console.ReadLine());

                if (x * maxim > maximp)
                {
                    maximp = x * maxim;
                }

                if (line[0] > maxim)
                {
                    maxim = line[0];
                }

                line[0] = line[1];
                line[1] = x;
            }
            Console.WriteLine(maximp);
        }
    }
}