using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._24._2014_02_TwoGirlsOnePath_02
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] field = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger mollyTotalFlowers = 0;
            BigInteger dollyTotalFlowers = 0;

            BigInteger mollyCurrentFLowers = 0;
            BigInteger dollyCUrrentFlowers = 0;

            int mollyIndex = 0;
            int dollyIndex = field.Length - 1;

            BigInteger mollyCurrentFieldFLowers = 0;
            BigInteger dollyCurrentFieldFLowers = 0;

            while (true)
            {

                mollyCurrentFieldFLowers = field[mollyIndex];
                dollyCurrentFieldFLowers = field[dollyIndex];

                if (field[mollyIndex] != 0 && field[dollyIndex] == 0)
                {
                    mollyTotalFlowers += field[mollyIndex];
                    Console.WriteLine("Molly");
                    break;
                }
                if (field[mollyIndex] == 0 && field[dollyIndex] != 0)
                {
                    dollyTotalFlowers += field[dollyIndex];
                    Console.WriteLine("Dolly");
                    break;
                }
                if (field[mollyIndex] == 0 && field[dollyIndex] == 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                if (mollyIndex == dollyIndex)
                {

                    mollyCurrentFieldFLowers = field[mollyIndex];
                    dollyCurrentFieldFLowers = field[dollyIndex];

                    field[mollyIndex] = mollyCurrentFieldFLowers % 2;

                    mollyTotalFlowers += mollyCurrentFieldFLowers / 2;
                    dollyTotalFlowers += dollyCurrentFieldFLowers / 2;
                }
                else
                {
                    field[mollyIndex] = 0;
                    field[dollyIndex] = 0;

                    mollyTotalFlowers += mollyCurrentFieldFLowers;
                    dollyTotalFlowers += dollyCurrentFieldFLowers;
                }

                mollyIndex = (int)((mollyIndex + mollyCurrentFieldFLowers) % field.Length);
                dollyIndex = (int)(dollyIndex - (dollyCurrentFieldFLowers % field.Length));

                if (dollyIndex < 0)
	            {
		            dollyIndex += field.Length;
	            }
            }
            Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
        }
    }
}
