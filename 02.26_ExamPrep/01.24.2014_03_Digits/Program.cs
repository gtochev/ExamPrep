using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._24._2014_03_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lineCount = int.Parse(Console.ReadLine());
            string[] text = new string[lineCount];
            string parsingLinesStr = string.Empty;

            StringBuilder parsingLines = new StringBuilder();

            int counterWords = 0;
            int[] wordCount = new int[text.Length];


            for (int i = 0; i < lineCount; i++)
            {
                string[] temp = Console.ReadLine().Trim().Split(new[] { ' ', ',', '.', '(', ')', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j].ToLower() == word.ToLower())
                    {
                        temp[j] = temp[j].ToUpper();
                        counterWords++;
                        
                    }
                    parsingLines.Append(temp[j] + " ");
                }
                wordCount[i] = counterWords;
                counterWords = 0;
                text[i] = parsingLines.ToString().Trim();
                parsingLines.Clear();

            }

            int maxWordsInLine = 0;
            int indexForPrint = 0;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (maxWordsInLine < wordCount[j] && wordCount[j] > 0)
                    {
                        indexForPrint = j;
                        maxWordsInLine = wordCount[j];
                        
                    }
                }
                wordCount[indexForPrint] = -1;
                maxWordsInLine = -1;
                Console.WriteLine(text[indexForPrint]);
            }
        }
    }
}
