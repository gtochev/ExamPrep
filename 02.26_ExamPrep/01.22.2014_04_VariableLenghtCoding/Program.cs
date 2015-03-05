using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._22._2014_04_VariableLenghtCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input first row and convert to bin str
            string inputNum = Console.ReadLine();

            var splitNum = inputNum.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numBin = new List<int>();

            foreach (var item in splitNum)
            {
                numBin.Add(int.Parse(item));
            }

            StringBuilder codeBuild = new StringBuilder();
            foreach (var num in numBin)
            {
                codeBuild.Append(Convert.ToString(num, 2).PadLeft(8, '0'));
            }
            codeBuild.Append("0");
            string code = codeBuild.ToString();
            // Second input
            int n = int.Parse(Console.ReadLine());

            string[] dict = new string[n + 1];

            string input = string.Empty;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                char symbol = input[0];
                index = int.Parse(input.Substring(1));
                dict[index] = symbol.ToString();
            }

            // Logic
            int counter = 0;
            foreach (var item in code)
            {
                if (item == '1')
                {
                    counter++;
                }
                else
                {
                    Console.Write(dict[counter]);
                    counter = 0;
                }
                
            }


        }
    }
}
