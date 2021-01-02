using System;

namespace Tasks17_Task9
{
    class Program
    {
        static void Main()
        {
            var cnt = 0;
            var minim = 8010;
            for (int i = 3578; i <= 8009; ++i)
            {
                if ((i % 17 == 0) && (i % 93 != 0) && (i % 100 == 11))
                {
                    if (i < minim)
                    {
                        minim = i;
                    }
                    cnt++;
                }
            }
            Console.WriteLine($"{cnt} {minim}");
        }
    }
}
