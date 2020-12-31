using System;

namespace Methods_Task6_1
{
    class Program
    {
        static void Inc(ref int k)
        {
            k++;
        }

        static void Main()
        {
            var k = 0;
            Inc(ref k);
            Console.WriteLine(k);
        }
    }
}
