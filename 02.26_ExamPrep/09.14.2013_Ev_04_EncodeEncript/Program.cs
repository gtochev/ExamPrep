using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._14._2013_Ev_04_EncodeEncript
{
    class Program
    {

        static void Main(string[] args)
        {
            // Input
            StringBuilder message = new StringBuilder(Console.ReadLine());
            StringBuilder cypher = new StringBuilder(Console.ReadLine());
            int cypherLenghtOutput = cypher.Length;


            // Applying the CYPHER on the MESSAGE
            StringBuilder cypherText = new StringBuilder();
            int converting = 0;
            int cypherCounter = 0;


            if (message.Length >= cypher.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    converting = (int)(((message[i] - 'A') ^ (cypher[cypherCounter] - 'A')) + 65);
                    cypherText.Append((char)converting);
                    cypherCounter++;
                    if (cypherCounter == cypher.Length)
                    {
                        cypherCounter = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    converting = (int)(((message[i] - 'A') ^ (cypher[i] - 'A')) + 65);
                    int shit = i + message.Length;
                    while (shit < cypher.Length)
	                {
                        converting = (int)((((char)converting - 'A') ^ (cypher[shit] - 'A')) + 65);
                        shit += message.Length;
	                }
                    cypherText.Append((char)converting);
                }
            }

            cypherText.Append(cypher);
            // ENCRIPTING
            StringBuilder encriptedMessage = new StringBuilder();

            int repeatingLetter = 1;

            for (int i = 0; i < cypherText.Length - 1; i++)
            {
                if (cypherText[i] == cypherText[i + 1])
                {
                    repeatingLetter++;
                    continue;
                }
                if (cypherText[i] != cypherText[i + 1] && repeatingLetter > 2)
                {
                    encriptedMessage.Append(repeatingLetter.ToString() + cypherText[i].ToString());
                    repeatingLetter = 1;
                    continue;
                }
                if (cypherText[i] != cypherText[i + 1] && repeatingLetter == 2)
                {
                    encriptedMessage.Append(cypherText[i].ToString() + cypherText[i].ToString());
                    repeatingLetter = 1;
                    continue;
                }
                if (cypherText[i] != cypherText[i + 1] && repeatingLetter < 2)
                {
                    encriptedMessage.Append(cypherText[i].ToString());
                    repeatingLetter = 1;
                    continue;
                }
            }

            // Checking last letter
            if (cypherText[cypherText.Length - 2] != cypherText[cypherText.Length - 1])
            {
                encriptedMessage.Append(cypherText[cypherText.Length - 1].ToString());
            }
            if (cypherText[cypherText.Length - 2] == cypherText[cypherText.Length - 1])
            {
                encriptedMessage.Append(cypherText[cypherText.Length - 1].ToString() + cypherText[cypherText.Length - 1].ToString());
            }
            // Appending output

            StringBuilder output = new StringBuilder();

            output.Append(encriptedMessage);
            output.Append(cypherLenghtOutput.ToString());
            Console.WriteLine(output.ToString());
        }
    }
}
