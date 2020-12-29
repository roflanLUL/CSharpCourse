namespace Arrays
{
    class Program
    {
        static void Main()
        {

            #region One-dimensional arrays

            int[] numbers;
            numbers = new int[3];

            int[] array1 = new int[3];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;

            var array2 = new int[3] { 1, 2, 3 };

            var array3 = new int[] { 1, 2, 3 };

            var array4 = new[] { 1, 2, 3 };

            int[] array5 = { 1, 2, 3 }; // здесь var не сработает

            int[] ErrorArr1 = new int[2];
            ErrorArr1[5] = 5; // Compilation error

            #endregion

            #region Multidimensional arrays

            // type [,,...] name;
            int[,] _numbers;
            // name = new type[size, size, ...];
            _numbers = new int[3, 3];

            int[,] _array1 = new int[2, 2];
            _array1[0, 0] = 1;
            _array1[0, 1] = 1;
            _array1[1, 0] = 1;
            _array1[1, 1] = 1;

            int[,] _array2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] _array3 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] _array4 = new[,] { { 1, 2 }, { 3, 4 } };
            int[,] _array5 = 
            { 
                { 1, 2 }, 
                { 3, 4 }
            };

            int[,] _ErrorArr1 = new int[2, 2];
            _ErrorArr1[5, 5] = 5; // Compilation error

            int[,] _ErrorArr2 = { { 1, 2 }, { 3, 4 } };
            _ErrorArr2[5, 5] = 5; // Compilation error

            var ThreeDimensionalArray = new int[5, 5, 5];
            var FourDimensionalArray  = new int[5, 5, 5, 5];
            var FiveDimensionalArray  = new int[5, 5, 5, 5, 5];
            var SixDimensionalArray   = new int[5, 5, 5, 5, 5, 5];

            #endregion

            #region Jagged arrays (Array of arrays)

            int[][] nums1 = new int[3][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1 },
                new int[] { 1, 2, 3 }
            };

            int[][,] nums2 = new int[3][,]
            {
                new int[,] { {1, 2}, { 3, 4 } },
                new int[,] { {1, 2}, { 3, 4 }, { 5, 6 }, { 7, 8 } },
                new int[,] { {1, 2}, { 3, 4 }, { 5, 6 } }
            };

            var num3 = new[]
            {
                new[] { 1, 2, 3, 4, 5 },
                new[] { 1 },
                new[] { 1, 2, 3 }
            };

            var nums4 = new[]
            {
                new[,] { { 1, 2 }, { 3, 4 } },
                new[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } },
                new[,] { { 1, 2 }, { 3, 5 }, { 5, 6 } }
            };

            #endregion
        }
    }
}
