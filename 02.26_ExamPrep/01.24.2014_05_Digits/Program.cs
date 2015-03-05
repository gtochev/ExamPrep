using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._24._2014_05_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                string[] temp = Console.ReadLine().Split(new[] { ' ' }).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = Convert.ToInt16(temp[col]);
                }
            }

            int sum = 0;

            for (int row = 0; row < size - 4; row++)
            {
                for (int col = 0; col < size -2; col++)
                {
                    // 1
                    if (matrix[row, col + 2] == 1 &&
                        matrix[row + 1, col + 1] == 1 && matrix[row + 1, col + 2] == 1 &&
                        matrix[row + 2, col] == 1 && matrix[row + 2, col + 2] == 1 &&
                        matrix[row + 3, col + 2] == 1 &&
                        matrix[row + 4, col + 2] == 1)
                    {
                        sum += 1;
                    }
                    // 2
                    if (matrix[row, col + 1] == 2 &&
                        matrix[row + 1, col] == 2&& matrix[row + 1, col + 2] == 2 &&
                        matrix[row + 2, col + 2] == 2 &&
                        matrix[row + 3, col + 1] == 2 &&
                        matrix[row + 4, col] == 2 && matrix[row + 4, col + 1] == 2 && matrix[row + 4, col + 2] == 2)
                    {
                        sum += 2;
                    }
                    // 3
                    if (matrix[row, col] == 3 && matrix[row, col + 1] == 3 && matrix[row, col + 2] == 3 &&
                        matrix[row + 1, col + 2] == 3 &&
                        matrix[row + 2, col + 1] == 3 && matrix[row + 2, col + 2] == 3 &&
                        matrix[row + 3, col + 2] == 3 &&
                        matrix[row + 4, col] == 3 && matrix[row + 4, col + 1] == 3 && matrix[row + 4, col + 2] == 3 )
                    {
                        sum += 3;
                    }
                    // 4
                    if (matrix[row, col] == 4 && matrix[row, col + 2] == 4 &&
                        matrix[row + 1, col] == 4&& matrix[row + 1, col + 2] == 4 &&
                        matrix[row + 2, col] == 4 && matrix[row + 2, col + 1] == 4 && matrix[row + 2, col + 2] == 4 &&
                        matrix[row + 3, col + 2] == 4 &&
                        matrix[row + 4, col + 2] == 4)
                    {
                        sum += 4;
                    }
                    // 5
                    if (matrix[row, col] == 5 && matrix[row, col + 1] == 5 && matrix[row, col + 2] == 5 &&
                        matrix[row + 1, col] == 5 &&
                        matrix[row + 2, col] == 5 && matrix[row + 2, col + 1] == 5 && matrix[row + 2, col + 2] == 5 &&
                        matrix[row + 3, col + 2] == 5 &&
                        matrix[row + 4, col] == 5 && matrix[row + 4, col + 1] == 5 && matrix[row + 4, col + 2] == 5)
                    {
                        sum += 5;
                    }
                    // 6
                    if (matrix[row, col] == 6 && matrix[row, col + 1] == 6 && matrix[row, col + 2] == 6 &&
                        matrix[row + 1, col] == 6 &&
                        matrix[row + 2, col] == 6 && matrix[row + 2, col + 1] == 6 && matrix[row + 2, col + 2] == 6 &&
                        matrix[row + 3, col] == 6 &&matrix[row + 3, col + 2] == 6 &&
                        matrix[row + 4, col] == 6 && matrix[row + 4, col + 1] == 6 && matrix[row + 4, col + 2] == 6)
                    {
                        sum += 6;
                    }
                    // 7
                    if (matrix[row, col] == 7 && matrix[row, col + 1] == 7 && matrix[row, col + 2] == 7 &&
                        matrix[row + 1, col + 2] == 7 &&
                        matrix[row + 2, col + 1] == 7 &&
                        matrix[row + 3, col + 1] == 7 &&
                        matrix[row + 4, col + 1] == 7)
                    {
                        sum += 7;
                    }
                    // 8
                    if (matrix[row, col] == 8 && matrix[row, col + 1] == 8 && matrix[row, col + 2] == 8 &&
                        matrix[row + 1, col] == 8&& matrix[row + 1, col + 2] == 8 &&
                        matrix[row + 2, col + 1] == 8&&
                        matrix[row + 3, col] == 8&& matrix[row + 3, col + 2] == 8 &&
                        matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8)
                    {
                        sum += 8;
                    }
                    // 9
                    if (matrix[row, col] == 9 && matrix[row, col + 1] == 9 && matrix[row, col + 2] == 9 &&
                        matrix[row + 1, col] == 9 && matrix[row + 1, col + 2] == 9 &&
                        matrix[row + 2, col + 1] == 9 && matrix[row + 2, col + 2] == 9 &&
                        matrix[row + 3, col + 2] == 9 &&
                        matrix[row + 4, col] == 9 && matrix[row + 4, col + 1] == 9 && matrix[row + 4, col + 2] == 9)
                    {
                        sum += 9;
                    }
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
