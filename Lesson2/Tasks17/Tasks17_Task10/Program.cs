using System;

namespace Tasks17_Task10
{
    class Program
    {
        static bool isPrime(int x)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(x); ++i)
            {
                if (x % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
        static void Main()
        {
            var cnt = 0;
            var maxim = 3577;
            for (int i = 3578; i <= 8009; ++i)
            {
                if (isPrime(i) && (i % 10 == 7))
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
