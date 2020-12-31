using System;

namespace Methods_Task2
{
    class Program
    {
        static double Average(int[] a)
        {
            var sum = 0;

            for (int i = 0; i < 10; ++i)
            {
                sum += a[i];
            }

            return sum / 10;
        }
        static void Main()
        {
            var a = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            var ans = Average(a);

            Console.WriteLine(ans);
        }
    }
}
