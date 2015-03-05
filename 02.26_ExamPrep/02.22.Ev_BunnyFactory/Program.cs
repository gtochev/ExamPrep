using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02._22.Ev_BunnyFactory
{
    class Program
    {


        static void Main(string[] args)
        {
            // Input 
            var strCages = new List<string>();
            string input = string.Empty;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                strCages.Add(input);
            }
            

            // Logic
            var concatedString = new List<string>();
            int firstCages = 0;
            int sum = 0;
            int counter = 1;
            int product = 1;
            StringBuilder cagesStr = new StringBuilder();

            while (true)
            {
                // Filling cagesArr with cages rabits
                int[] cages = new int[strCages.Count];

                for (int i = 0; i < cages.Length; i++)
                {
                    cages[i] = int.Parse(strCages[i]);
                }

                // First step
                int indexNextCages = counter;
                for (int i = 0; i < counter; i++)
                {
                    firstCages += cages[i];
                }

                // TODO Checking where the break is 
                if (firstCages > cages.Length - counter)
                {
                    Console.Write(cages[0]);
                    for (int i = 1; i < cages.Length; i++)
                    {
                        Console.Write(' ');
                        Console.Write(cages[i]);
                    }
                    
                    return;
                }

                // Sum and product
                for (int i = 0; i < firstCages; i++)
                {
                    sum += cages[indexNextCages];
                    product *= cages[indexNextCages];
                    indexNextCages++;
                }

                // Concatenation
                concatedString.Clear();
                concatedString.Add(sum.ToString());
                concatedString.Add(product.ToString());
                for (int i = indexNextCages; i < cages.Length; i++)
                {
                    concatedString.Add(cages[i].ToString());
                }
                // Moving to string
                strCages.Clear();
                cagesStr.Clear();

                for (int i = 0; i < concatedString.Count; i++)
                {
                    cagesStr.Append(concatedString[i]);
                }

                // Removing 0 and 1
                int temp = cagesStr.Length;
                for (int i = 0; i < temp; i++)
                {
                    if (cagesStr[i] == '1' || cagesStr[i] == '0' )
                    {
                        cagesStr.Remove(i,1);
                        temp--;
                        i--;
                    }
                }
                for (int i = 0; i < cagesStr.Length; i++)
                {
                    strCages.Add(cagesStr[i].ToString());
                }

                // Current status check
                //for (int i = 0; i < cagesStr.Length; i++)
                //{
                //    Console.Write(cagesStr[i]);
                //}
                sum = 0;
                product = 1;
                firstCages = 0;
                counter++;

            }
        }
    }
}
