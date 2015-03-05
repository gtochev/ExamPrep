using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09._14._2013_Ev_05_TheyAreGreen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            string[] letters = new string[n];
            for (int i = 0; i < n; i++)
            {
                letters[i] = Console.ReadLine();
            }
            // ---

            int sameLetters = 0;
            int singleSameLetters = 0;
            int singleCountTemp = 1;

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = i + 1; j < letters.Length; j++)
                {
                    if (letters[i] == string.Empty)
                    {
                        continue;
                    }
                    if (letters[i] == letters[j])
                    {
                        letters[j] = string.Empty;
                        sameLetters++;
                        singleCountTemp++;

                    }
                }
                if (singleCountTemp > singleSameLetters)
                {
                    singleSameLetters = singleCountTemp;
                }
                singleCountTemp = 1;
            }

            // Logic
            int factorial = 0;
            BigInteger output = 1;



            if (letters.Length % 2 == 0 && letters.Length / 2 >= singleSameLetters && letters.Length - sameLetters > 0)
            {
                factorial = letters.Length - sameLetters;
                for (int i = 1; i <= factorial; i++)
                {
                    output *= i;
                }
                Console.WriteLine(output);
            }
            else if (letters.Length % 2 != 0 && letters.Length / 2 + 1 >= singleSameLetters && letters.Length - sameLetters > 0)
            {
                factorial = letters.Length - sameLetters - 1;
                for (int i = 1; i <= factorial; i++)
                {
                    output *= i;
                }
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
