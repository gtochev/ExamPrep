using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._22._2014_05_Ev_HelpDoge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] coords = input.Split(' ');
            int x = int.Parse(coords[0]);
            int y = int.Parse(coords[1]);
            BigInteger[,] field = new BigInteger[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    field[i, j] = 1;
                }
            }

            string inputF = Console.ReadLine();
            string[] coordsF = inputF.Split(' ');
            int fx = int.Parse(coordsF[0]);
            int fy = int.Parse(coordsF[1]);

            
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                string inputDog = Console.ReadLine();
                string[] coordsDog = inputDog.Split(' ');
                int xDog = int.Parse(coordsDog[0]);
                int yDog = int.Parse(coordsDog[1]);
                field[xDog, yDog] = 0;
            }

            
            // Filling first row
            field[0, 0] = 1;
            for (int i = 1; i < y; i++)
			{
                if (field[0,i] == 0)
	            {
		            continue;
	            }
			    field[0,i] = field[0,i-1];
			}
            // Filling first col
            for (int i = 1; i < x; i++)
			{
                if (field[i,0] == 0)
	            {
		            continue;
	            }
			    field[i,0] = field[i - 1,0];
			}

            // Filling the matrix with bad dogs
            for (int row = 1; row < x; row++)
            {
                for (int col = 1; col < y; col++)
                {
                    if (field[row,col] == 0)
                    {
                        continue;
                    }
                    field[row, col] = field[row - 1, col] + field[row, col -1];
                }
            }
            Console.WriteLine(field[fx,fy]);
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(" " + field[i,j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
