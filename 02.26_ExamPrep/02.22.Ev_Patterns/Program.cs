using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._22.Ev_Patterns
{
    class Program
    {
        static int CheckingPattern(int[,] matrix, int row, int col)
        {
            int count = 0;
            if (matrix[row, col] == matrix[row, col + 1] - 1 && matrix[row, col] == matrix[row, col + 2] -2 
                && matrix[row,col] == matrix[row + 1,col + 2] - 3 && matrix[row, col] == matrix[row + 2, col + 2] -4
                && matrix[row, col] == matrix[row + 2, col + 3] - 5&& matrix[row, col] == matrix[row + 2, col + 4] -6)
            {
                for (int i = 0; i < 7; i++)
                {
                    count += matrix[row,col] + i;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            // Reading the input and filling the matrix
            int rowCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowCol, rowCol];

            for (int i = 0; i < rowCol; i++)
            {
                string input = Console.ReadLine();
                string[] tempMatrix = input.Split(' ');
                for (int j = 0; j < rowCol; j++)
                {
                    matrix[i, j] = int.Parse(tempMatrix[j]);
                }
            }

            // Logic
            int biggest = 0;
            int temp = 0;
            for (int row = 0; row < rowCol - 2; row++)
            {
                for (int col = 0; col < rowCol - 4; col++)
                {
                    temp = CheckingPattern(matrix, row, col);
                    if (temp > biggest)
                    {
                        biggest = temp;
                    }
                }
            }
            int diagonal = 0;
            if (biggest > 0)
            {
                Console.WriteLine("YES {0}", biggest);
            }
            else
            {
                int col = 0;
                for (int row = 0; row < rowCol ; row++)
                {
                    diagonal += matrix[row, col];
                    col++;
                }
                Console.WriteLine("NO {0}", diagonal);
            }
        }
    }
}
