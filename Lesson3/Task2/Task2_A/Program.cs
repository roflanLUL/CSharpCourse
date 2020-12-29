using System;

namespace Task2_A
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = 0;
            var a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 7; j < n; ++j)
                {
                    if (a[i] * a[j] % 3 == 0)
                    {
                        k++;
                    }
                }
            }
            Console.WriteLine(k);
        }
    }
}