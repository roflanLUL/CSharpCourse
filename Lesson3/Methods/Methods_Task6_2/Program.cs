using System;

namespace Methods_Task6_2
{
    class Program
    {
        static void Dec(ref int k)
        {
            k--;
            if (k == 0)
            {
                k = 10;
            }
        }

        static void Main()
        {
            var k = 10;
            Dec(ref k);
            Console.WriteLine(k);
        }
    }
}
