using System;

namespace Task3_B
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var line = new int[5];

            var maxim = -1;
            var maximp = -1;

            for (int i = 0; i < 5; ++i)
            {
                line[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 5; i < n; ++i)
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

                for (int j = 0; j < 5; ++j)
                {
                    line[j] = line[j + 1];
                }
                line[5] = x;
            }
            Console.WriteLine(maximp);
        }
    }
}