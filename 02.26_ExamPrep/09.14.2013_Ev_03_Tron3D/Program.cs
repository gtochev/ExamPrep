using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._14._2013_Ev_03_Tron3D
{
    class Program
    {

        static void Main(string[] args)
        {
            #region ReadingInput
            // Readming the input
            string inputDimentions = Console.ReadLine();
            string[] dimentions = inputDimentions.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] xyz = new int[3];

            for (int i = 0; i < 3; i++)
            {
                xyz[i] = int.Parse(dimentions[i]);
            }

            int x = xyz[0];
            int y = xyz[1];
            int z = xyz[2];

            int fieldRows = x + 1;
            int fieldCols = 2 * y + 2 * z + 4;

            int[,] field = new int[fieldRows, fieldCols];

            int redStartRow = fieldRows / 2;
            int redStarCol = y / 2;
            int blueStartRow = fieldRows / 2;
            int blueStartCol = fieldCols - y / 2 - 1;

            int distanceRow = redStartRow;
            int distanceCol = redStarCol;

            // Moving input

            string inputRedMoves = Console.ReadLine();
            string inputBlueMoves = Console.ReadLine();


            string redMoves = "tor"; //ArrangingIputMoves(inputRedMoves).ToString();
            string blueMoves = "tor tor|"; // ArrangingIputMoves(inputBlueMoves).ToString();

            int red = redMoves.Length;
            int blue = blueMoves.Length;
            #endregion;
            // Red player position
            field[redStartRow, redStarCol] = 1;
            field[blueStartRow, blueStartCol] = 1;

            #region BoolVARS
            // Red bool logic
            bool winsRed = false;
            bool winsBlue = false;

            #endregion;
            int directionRed = 1;
            int directionBlue = 3;
            int movin = 0;

            while (true)
            {
                #region TurningLogic
                // Red turning LEFT
                if (redMoves[movin] == 'L')
                {
                    directionRed++;
                    if (directionRed > 3)
                    {
                        directionRed = 0;
                    }
                }
                // Red turning RIGHT
                if (redMoves[movin] == 'R')
                {
                    directionRed--;
                    if (directionRed < 0)
                    {
                        directionRed = 3;
                    }
                }
                // Blue turning LEFT
                if (blueMoves[movin] == 'L')
                {
                    directionBlue++;
                    if (directionBlue > 3)
                    {
                        directionBlue = 0;
                    }
                }
                // Blue turning RIGHT
                if (blueMoves[movin] == 'R')
                {
                    directionBlue--;
                    if (directionBlue < 0)
                    {
                        directionBlue = 3;
                    }
                }
                #endregion;

                #region RedMovingLogic
                // Red moving logic

                

                //----------

                if (redMoves[movin] == 'M')
                {
                    switch (directionRed)
                    {
                        case 0: redStartRow++; break;
                        case 1: redStarCol++; break;
                        case 2: redStartRow--; break;
                        case 3: redStarCol--; break;

                        default:
                            break;
                    }
                    // Passing Left to right
                    // Red
                    if (redStarCol > fieldCols - 1)
                    {
                        redStarCol = 0;
                    }
                    if (redStarCol < 0)
                    {
                        redStarCol = fieldCols - 1;
                    }
                    // Hitting shit
                    if (field[redStartRow, redStarCol] == 1)
                    {
                        winsBlue = true;
                    }
                    field[redStartRow, redStarCol] = 1;
                }
                #endregion;

                #region BlueMovingLogic
                // Blue Moving logic
                if (blueMoves[movin] == 'M')
                {
                    switch (directionBlue)
                    {
                        case 0: blueStartRow++; break;
                        case 1: blueStartCol++; break;
                        case 2: blueStartRow--; break;
                        case 3: blueStartCol--; break;
                        default:
                            break;
                    }
                    // Passing Left to right                
                    // Blue
                    if (blueStartCol > fieldCols - 1)
                    {
                        blueStartCol = 0;
                    }
                    if (blueStartCol < 0)
                    {
                        blueStartCol = fieldCols - 1;
                    }
                    // Hitting shit
                    if (field[blueStartRow, blueStartCol] == 1)
                    {
                        winsRed = true;
                    }
                    field[blueStartRow, blueStartCol] = 1;
                }

                #endregion;

                #region TestingTheMatrix
                // Testing the Matrix
                for (int i = 0; i < fieldRows; i++)
                {
                    for (int j = 0; j < fieldCols; j++)
                    {
                        Console.Write(field[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
                #endregion;

                movin++;
                #region WinLogic
                if ((winsRed && !winsBlue) || blueStartRow < 0 || blueStartRow > fieldRows - 1)
                {
                    Console.WriteLine("RED");
                    break;
                }
                else if (winsRed && winsBlue)
                {
                    Console.WriteLine("DRAW");
                    break;
                }
                else if ((!winsRed && winsBlue) ||redStartRow < 0 || redStartRow > fieldRows - 1)
                {
                    Console.WriteLine("BLUE");
                    break;
                }

                #endregion;
                
                if (movin > redMoves.Length - 1)
                {
                    redMoves = redMoves + "M";
                    blueMoves = blueMoves + "M";
                }
                
            }

            int outputDistance = Math.Abs(distanceRow - redStartRow) + Math.Abs(distanceCol - redStarCol) + 1;
            Console.WriteLine(outputDistance);
        }
    }
}
