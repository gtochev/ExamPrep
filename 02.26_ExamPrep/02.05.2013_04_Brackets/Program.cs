using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._05._2013_04_Brackets
{
    class Program
    {
        static int tabCount = 0;
        static string tab = string.Empty;
        static string tempText = string.Empty;
        static string input = string.Empty;

        // Checking and appending text without brackets
        static StringBuilder TextWithoutBrackets(string text)
        {
            var line = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '{')
                {
                    line.Append(text[i]);
                }
            }
            input = input.Remove(0, line.Length);
            return line;
        }
        // ----------




        // MAIN -------------------------------------------------------------------------------------
        static void Main()
        {
            // Input
            int lines = int.Parse(Console.ReadLine());
            tab = Console.ReadLine();
            // End Input

            // Reading the input lines to format
            for (int rows = 0; rows < lines; rows++)
            {
                input = Console.ReadLine();

                #region InitialFormatting
                // Removing empty end and beginning
                input = input.TrimEnd();
                input = input.TrimStart();
                // Removing empty lines
                if (input == string.Empty)
                {
                    break;
                }
                // Removing more than one space!!! Input is changed !!!
                int counter = input.Length - 1;
                for (int i = 0; i < counter; i++)
                {
                    if (input[i] == input[i + 1] && input[i] == ' ')
                    {
                        while (input[i] == input[i + 1])
                        {
                            input = input.Remove(i + 1, 1);
                            counter--;
                        }
                    }
                }
                #endregion;


                tempText = TextWithoutBrackets(input).ToString();

                if (tempText != string.Empty)
                {
                    for (int i = 0; i < tabCount; i++)
                    {
                        Console.Write(tab);
                    }
                    Console.WriteLine(tempText);
                }
                Console.WriteLine(input);
               
                

            }
        }
    }
}
