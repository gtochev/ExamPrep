using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._24._2014_02_TwoGirlsOnePath
{
    class Program
    {
        static void Main()
        {
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger mollyF = 0;
            BigInteger dollyF = 0;

            mollyF = numbers[0];
            dollyF = numbers[numbers.Length - 1];

            int mollyNextIndex = 0;
            int dollyNextIndex = 0;

            mollyNextIndex = (int)numbers[0];
            dollyNextIndex = (int)((numbers.Length - 1) - (numbers[numbers.Length - 1] % numbers.Length));
            int indexCurrField = 0;
            BigInteger currFieldF = 0;

            numbers[0] = 0;
            numbers[numbers.Length - 1] = 0;

            while (true)
            {
                // If they step on the same field
                if (numbers[mollyNextIndex] == numbers[dollyNextIndex])
                {
                    indexCurrField = mollyNextIndex;
                    currFieldF = numbers[mollyNextIndex];
                    mollyNextIndex = (int)((mollyNextIndex + numbers[mollyNextIndex]) % numbers.Length);
                    dollyNextIndex = (int)(dollyNextIndex - (numbers[dollyNextIndex] % numbers.Length));
                    mollyF += currFieldF / 2;
                    dollyF += currFieldF / 2;
                    numbers[indexCurrField] = currFieldF % 2;
                }
                // If they step on field 0
                else if (numbers[mollyNextIndex] == 0 && numbers[dollyNextIndex] == 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                else if (numbers[mollyNextIndex] == 0 && numbers[dollyNextIndex] != 0)
                {
                    dollyF += numbers[dollyNextIndex];
                    Console.WriteLine("Dolly");
                    break;
                }
                else if (numbers[dollyNextIndex] == 0 && numbers[mollyNextIndex] != 0)
                {
                    mollyF += numbers[mollyNextIndex];
                    Console.WriteLine("Molly");
                    break;
                }
                else
                {
                    indexCurrField = mollyNextIndex;
                    mollyF += numbers[mollyNextIndex];
                    mollyNextIndex = (int)((mollyNextIndex + numbers[mollyNextIndex]) % numbers.Length);
                    numbers[indexCurrField] = 0;

                    indexCurrField = dollyNextIndex;
                    dollyF += numbers[dollyNextIndex];
                    dollyNextIndex = (int)(dollyNextIndex - (numbers[dollyNextIndex] % numbers.Length));
                    numbers[indexCurrField] = 0;

                    if (dollyNextIndex < 0)
                    {
                        dollyNextIndex = numbers.Length + dollyNextIndex;
                    }
                }

            }
            Console.WriteLine("{0} {1}", mollyF, dollyF);
        }
    }
}
