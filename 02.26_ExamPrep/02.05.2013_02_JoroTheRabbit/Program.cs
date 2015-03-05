using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._05._2013_02_JoroTheRabbit
{
    class Program
    {
        static void Main()
        {
            // Input and parsing the input
            string input = Console.ReadLine();

            var inputSplit = input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            int[] field = new int[inputSplit.Length];

            for (int i = 0; i < inputSplit.Length; i++)
            {
                field[i] = Convert.ToInt16(inputSplit[i]);
            }

            int jumps = 0;
            int maxJumps = 0;
            int index = 0;
            int nextStep = 0;
            

            for (int i = 1; i < field.Length; i++)
            {
                int jumpLenght = i;
                for (int j = 0; j < field.Length; j++)
                {
                    index = j;
                    nextStep = (index + jumpLenght) % field.Length;
                    while (field[index] < field[nextStep])
                    {
                        jumps++;
                        index = (index + jumpLenght ) % field.Length;
                        nextStep = (nextStep + jumpLenght) % field.Length;
                    }
                    if (jumps > maxJumps)
                    {
                        maxJumps = jumps;
                    }
                    jumps = 0;
                }

            }
            Console.WriteLine(maxJumps + 1);
        }
    }
}
