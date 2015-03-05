using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02._05._2013_01_DurankulakNums
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var inputStr = new List<string>();
            string[] durNum = new string[168];

            #region NumbersInArray
            char firstChar = 'a';
            char secondChar = 'A';
            int counterSecond = 1;


            for (int i = 0; i < 26; i++)
            {
                secondChar = (char)('A' + i);
                durNum[i] = (secondChar).ToString();
            }
            secondChar = 'A';
            for (int i = 26; i < 168; i++)
            {
                durNum[i] = firstChar.ToString() + secondChar.ToString();
                secondChar = (char)('A' + counterSecond);
                counterSecond++;
                if (counterSecond == 27)
                {
                    counterSecond = 1;
                    secondChar = 'A';
                    firstChar = (char)(firstChar + 1);
                }
            }
            #endregion;

            #region ReadingTheInput
            string appendNumber = string.Empty;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    appendNumber = input[i].ToString() + input[i + 1].ToString();
                    i++;
                    inputStr.Add(appendNumber);
                }
                else
                {
                    inputStr.Add(((char)input[i]).ToString());
                }
            }
            #endregion;

            var numToCalc = new List<int>();

            for (int i = 0; i < inputStr.Count; i++)
            {
                for (int j = 0; j < durNum.Length; j++)
                {
                    if (inputStr[i] == durNum[j])
                    {
                        numToCalc.Add(j);
                    }
                }
            }

            numToCalc.Reverse();

            BigInteger output = 0;
            BigInteger multiply = 1;
            for (int i = 0; i < numToCalc.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    multiply *= 168;
                }
                output += numToCalc[i] * multiply;
                multiply = 1;
            }

            Console.WriteLine(output);
        }
    }
}
