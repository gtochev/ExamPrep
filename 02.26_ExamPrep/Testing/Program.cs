using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersArr = { "+NOL", "-KV", "DACA*", "MIM^", "|KIRE", "&YES", ">>YME", "LET/", "NOD<<" };

            BigInteger earthNum = BigInteger.Parse(Console.ReadLine());
            int index = 0;
            string output = string.Empty;

            while (true)
            {
                index = (int)(earthNum % 9);
                output = output + numbersArr[index];
                earthNum = earthNum / 9;
                if (earthNum < 9)
                {
                    index = (int)earthNum;
                    if (index == 0)
                    {
                        break;
                    }
                    output = output + numbersArr[index];
                    break;
                }
            }
            string newOutput = string.Empty;

            for (int i = output.Length - 1; i >= 0; i--)
            {
                newOutput = newOutput + output[i];
            }
            Console.WriteLine(newOutput);
        }
    }
}
