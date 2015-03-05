using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._14._2013_Ev_Zerg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and splitting the zerg nunmbers
            string zergMessage = Console.ReadLine();
            string[] zergNumbers = {"Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", 
                                    "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", 
                                    "Zzzz", "Bauu", "Djav", "Myau", "Gruh"};
            long[] zergMessageArr = new long[zergMessage.Length / 4];
            string splitZergNumber = string.Empty;
            for (int i = 0; i < zergMessageArr.Length; i++)
            {
                splitZergNumber = zergMessage.Substring(0, 4);
                zergMessage = zergMessage.Remove(0, 4);
                for (int j = 0; j < zergNumbers.Length; j++)
                {
                    if (splitZergNumber == zergNumbers[j])
                    {
                        zergMessageArr[i] = j;
                    }
                }
            }

            // calculcating number
            long output = 0;
            long multiplication = 1;
            Array.Reverse(zergMessageArr);

            for (int i = 0; i < zergMessageArr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    multiplication *= 15;
                }
                output += zergMessageArr[i] * multiplication;
                multiplication = 1;
            }


            Console.WriteLine(output);
        }
    }
}
