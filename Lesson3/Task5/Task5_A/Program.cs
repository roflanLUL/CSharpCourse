using System;

namespace Task5_A
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var maxim = -1;

            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 2; j < n; ++j)
                {
                    if (a[i] * a[j] > maxim)
                    {
                        maxim = a[i] * a[j];
                    }
                }
            }
            Console.WriteLine(maxim);
        }
    }
}