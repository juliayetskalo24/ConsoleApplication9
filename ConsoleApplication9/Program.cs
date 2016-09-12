using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[15][];

            jagged[0] = new int[] { 75 };
            jagged[1] = new int[] { 95, 64 };
            jagged[2] = new int[] { 17, 47, 82 };
            jagged[3] = new int[] { 18, 35, 87, 10 };
            jagged[4] = new int[] { 20, 04, 82, 47, 65 };
            jagged[5] = new int[] { 19, 01, 23, 75, 03, 34 };
            jagged[6] = new int[] { 88, 02, 77, 73, 07, 63, 67 };
            jagged[7] = new int[] { 99, 65, 04, 28, 06, 16, 70, 92 };
            jagged[8] = new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 };
            jagged[9] = new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 };
            jagged[10] = new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 };
            jagged[11] = new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 };
            jagged[12] = new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 };
            jagged[13] = new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 };
            jagged[14] = new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 };

            for (int i = jagged.Length-1; i > 0; --i)
            {
                // Во внутреннем цикле выполняется обращение к каждому элементу вложенного массива.
                for (int j = 0; j < jagged[i].Length-1; ++j)
                {
                        if (jagged[i][j]> jagged[i][j + 1])
                        {
                            jagged[i - 1][j] = jagged[i - 1][j] + jagged[i][j];

                        }
                        else
                            jagged[i - 1][j] = jagged[i - 1][j] + jagged[i][j+1];
                    
                }
            }
            Console.WriteLine("Максимальный путь={0}",jagged[0][0]);

        }
    }
}
