using System;

namespace Task3_A
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var max = -1;

            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 5; j < n; ++j)
                {
                    if (a[i] * a[j] > max)
                    {
                        max = a[i] * a[j];
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}