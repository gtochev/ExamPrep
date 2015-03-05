using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._14._2013_Ev_02_MovingLetters
{
    class Program
    {

        static void Main(string[] args)
        {
            //--------------------------
            string input = Console.ReadLine();
            string[] words = input.Split(' ').ToArray();
            StringBuilder sequenceLetters = new StringBuilder();

            int maxWordLenght = words[0].Length;

            for (int i = 1; i < words.Length; i++)
            {
                if (maxWordLenght < words[i].Length)
                {
                    maxWordLenght = words[i].Length;
                }
            }

            // Appending letters
            for (int j = 0; j < maxWordLenght; j++)
            {
                for (int i = 0; i < words.Length; i++)
                {

                    if (words[i].Length == 0)
                    {
                        continue;
                    }
                    sequenceLetters.Append(words[i][words[i].Length - 1]);
                    words[i] = words[i].Remove(words[i].Length - 1);
                }
            }


            //--------------------------
            char tempLetter;
            int index = 0;

            // Moving letters
            for (int i = 0; i < sequenceLetters.Length; i++)
            {
                index = i;
                tempLetter = sequenceLetters[i];
                index = ((index + (char.ToLower(sequenceLetters[i]) - 'a')) + 1) % sequenceLetters.Length;
                sequenceLetters = sequenceLetters.Remove(i, 1);
                sequenceLetters = sequenceLetters.Insert(index, tempLetter.ToString());
            }
            Console.WriteLine(sequenceLetters);
        }
    }
}
