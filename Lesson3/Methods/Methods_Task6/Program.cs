using System;

namespace Methods_Task6
{
    class Program
    {
        static void Inc(ref int k)
        {
            k++;
        }

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
            var cnt_inc = 0;
            var cnt_dec = 10;
            Inc(ref cnt_inc);
            Dec(ref cnt_dec);
            Console.WriteLine(cnt_inc);
            Console.WriteLine(cnt_dec);
        }
    }
}
