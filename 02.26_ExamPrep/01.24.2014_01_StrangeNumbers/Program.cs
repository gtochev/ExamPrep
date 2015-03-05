using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01._24._2014_01_StrangeNumbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> strangeNumbers = new List<int>();

            // Reading the number and adding to the List
            #region AddingToList
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    if (input[i] == 'f')
                    {
                        strangeNumbers.Add(0);
                    }
                    if (input[i] == 'b')
                    {
                        strangeNumbers.Add(1);
                    }
                    if (input[i] == 'o')
                    {
                        strangeNumbers.Add(2);
                    }
                    if (input[i] == 'm')
                    {
                        strangeNumbers.Add(3);
                    }
                    if (input[i] == 'l')
                    {
                        strangeNumbers.Add(4);
                    }
                    if (input[i] == 'p')
                    {
                        strangeNumbers.Add(5);
                    }
                    if (input[i] == 'h')
                    {
                        strangeNumbers.Add(6);
                    }
                }
            }
            #endregion;

            strangeNumbers.Reverse();

            BigInteger stepenuvane = 1;
            BigInteger output = 0;

            for (int i = 0; i < strangeNumbers.Count; i++)
			{
                for (int j = 0; j < i; j++)
			    {
			        stepenuvane *= 7;
			    }
                output += strangeNumbers[i] * stepenuvane;
                stepenuvane = 1;
			}

            Console.WriteLine(output);
        }
    }
}
