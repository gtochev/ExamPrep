using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02._26_ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numbersArr = new string[256];
            char upperNum = 'A';

            for (int i = 0; i < 26; i++)
            {
                numbersArr[i] = upperNum.ToString();
                upperNum++;
            }
            char lowerNum = 'a';
            upperNum = 'A';
            for (int i = 26; i < 256; i++)
            {
                numbersArr[i] = upperNum + lowerNum.ToString();
                upperNum++;

                if (upperNum > 'Z')
                {
                    lowerNum++;
                    upperNum = 'A';
                }
            }

            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int index = 0;
            string output = string.Empty;

            while (true)
            {
                index = (int)(number % 256);
                output = output + numbersArr[index];
                number = number / 256;
                if (number < 256)
                {
                    index = (int)number;
                    if (index == 0)
                    {
                        break;
                    }
                    output = output + numbersArr[index];
                    break;
                }
            }

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
