using System;

namespace Methods_Task3
{
    class Program
    {
        static double AVGeometric(double[] a)
        {
            var p = 1.0;
            for (int i = 0; i < 10; ++i)
            {
                p *= a[i];
            }

            var geom = Math.Pow(p, 1.0 / 10.0);

            return geom;
        }

        static void Main()
        {
            var a = new double[10];

            for (int i = 0; i < 10; ++i)
            {
                a[i] = double.Parse(Console.ReadLine());
            }

            var ans = AVGeometric(a);

            Console.WriteLine(ans);
        }
    }
}
