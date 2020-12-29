using System;

namespace Task2_B
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var line = new int[7];
            int ans = 0, k3 = 0;
            for (int i = 0; i < 7; ++i)
            {
                line[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 7; i < n; ++i)
            {
                var x = int.Parse(Console.ReadLine());
                
                if (line[0] % 3 == 0)
                {
                    k3++;
                }

                if (x % 3 == 0)
                {
                    ans += i - 8;
                }
                else
                {
                    ans += k3;
                }

                for (int j = 0; j < 7; ++j)
                {
                    line[j] = line[j + 1];
                }
                line[7] = x;
            }
            Console.WriteLine(ans);
        }
    }
}