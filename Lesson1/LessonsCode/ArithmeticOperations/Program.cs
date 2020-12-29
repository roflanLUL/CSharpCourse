using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main() 
        {
            int a = 23;
            int b = 45;

            var integerNumber = a / 2; // int
            var doubleNumber = a / 2d; // double
            var floatNumber = a / 2f; // float

            double d1 = 2.012345678901234; // максимум 15 символов после запятой
            float f1 = 2.01234567f; // максимум 8 символов после запятой
            decimal dd1 = 2.123213232132132131M; // максимум 30 символов после запятой


            var c = b = a = 4;

            a -= 4; // a = a - 4
            a += 2;
            a *= 2;
            a &= 2;

            a++; // a = a + 1, суффиксный
            a--;
            ++a; // a = a + 1, префиксный
            --a;

            a = 5;
            Console.WriteLine(a++); // 5

            a = 5;
            Console.WriteLine(++a); // 6

            Console.ReadKey();
        }
    }
}