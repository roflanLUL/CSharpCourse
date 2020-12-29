using System;
using System.Globalization;

namespace Variables
{
    class Program
    {
        static void Main()
        {
            #region Intro

            // type name;
            // type name = value;

            int a = 5;

            Int32 fullName = 0; // Class name
            int nickname = 0;   // Alias

            #endregion

            #region Types

            // ссылочные типы
            #region Reference Type

            /* Main */
            string str = "Hi"; // Class String
            object obj = "Hi"; // Class Object

            /* Other */
            // delegate
            // interface

            // null
            string null1 = null;
            object null2 = null;

            #endregion

            // значимые типы
            #region Value Type

            /* Main */
            int b1 = 0;         // Class Int32
            double b2 = 1.2;       // Class Double
            char b3 = '3';       // Class Char

            char ch1 = '\u0420';    // Unicode
            char ch2 = '\x10';      // ASCII
            char ch3 = '\n';        // End of Line
            char ch4 = '\t';        // Tab

            bool b4 = true;      // Class Boolean
            decimal b5 = 1.5M;      // Class Decimal
                                    // enum
                                    // struct

            /* Other */
            byte c1 = 3; // Class Byte
            sbyte c2 = -3; // Class SByte
            uint c3 = 4294; // Class UInt32
            long c4 = -4294; // Class Int64
            ulong c5 = 4294; // Class UInt64
            float c6 = 1.5F; // Class Float

            int bin = 0b1010; // 10
            int oct = Convert.ToInt32("31", 8); // 25
            int hex = 0x1E; // 30

            Console.WriteLine(bin + " " + oct + " " + hex);

            // int nullIntWrong = null;

            #endregion

            #endregion

            #region Var
            int number1;
            number1 = 0;

            int number2 = 25; // Int
            var number3 = 25; // Int

            // var u

            #endregion

            #region Dynamic 

            dynamic dyn = 5; // int
            // dyn.qwerty(); // компилятор пока ничего не знает про этот метод, 
                          // поскольку это динамический тип данных и может меняться

            int iNumber = 5;
            // iNumber.qwerty(); // компилятор знает что у int нет такого метода

            #endregion

            #region Conversion

            int intNumber = 45;
            double doubleNumber = 34.56;

            doubleNumber = intNumber; // Implicit Conversion
            intNumber = (int)(34.56); // Explicit Conversion
            intNumber = (int)Math.Round(34.67);

            long longInteger = 4000000000;
            // intNumber     = 4000000000;
            // intNumber     = longInteger;
            intNumber = (int)longInteger; // Overflow

            Console.WriteLine(intNumber); // выведет отрицательное число

            checked
            {
                intNumber = (int)longInteger; // выдаст ошибку в случае overflow
            }

            #endregion

            #region Strings

            string str1 = "text";
            var b = str1.Substring(0, 2); // te
            Console.WriteLine(b);

            var helloWorldStr = "Hello, world!";

            var helloWorldArr = new[] {'H', 'e', 'l', 'l', 'o', ',', ' ', 'w', 'o', 'r', 'l', 'd', '!'};

            char firstSym;
            firstSym = helloWorldStr[0]; // H
            firstSym = helloWorldArr[0]; // H

            var concatenate = "Hello" + " " + "world";

            // var exNumber = (int)"42"; // так не получится
            var number = int.Parse("42");
            var number4 = Convert.ToInt32("42");

            // var exNumString = (string)42; // так тоже
            var numString = 42.ToString();
            var numString2 = Convert.ToString(42);

            var doubleNumber1 = double.Parse("34,42");
            var invariantNumber = double.Parse("34.42", CultureInfo.InvariantCulture);

            Console.WriteLine(doubleNumber);    // 34,42
            Console.WriteLine(invariantNumber); // 34,42

            Console.WriteLine(invariantNumber.ToString(CultureInfo.InvariantCulture)); // 34.42

            #endregion

            Console.ReadKey();
        }
    }
}
