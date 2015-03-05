using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._05._2013_03_Laser
{
    class Program
    {

        static void Main(string[] args)
        {
            // Input

            string inputFirst = Console.ReadLine();
            var inputSplitFirst = inputFirst.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int W = Convert.ToInt16(inputSplitFirst[0]);
            int H = Convert.ToInt16(inputSplitFirst[1]);
            int D = Convert.ToInt16(inputSplitFirst[2]);

            string inputSecond = Console.ReadLine();
            var inputSplitSecond = inputSecond.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int startW = Convert.ToInt16(inputSplitSecond[0]) - 1;
            int startH = Convert.ToInt16(inputSplitSecond[1]) - 1;
            int startD = Convert.ToInt16(inputSplitSecond[2]) - 1;

            string inputThird = Console.ReadLine();
            var laserDirection = inputThird.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int laserW = Convert.ToInt16(laserDirection[0]);
            int laserH = Convert.ToInt16(laserDirection[1]);
            int laserD = Convert.ToInt16(laserDirection[2]);

            //-------------

            int[, ,] cube = new int[W, H, D];

            cube[startW, startH, startD] = 1;

            #region SettingEdges.
            //1
            for (int i = 0; i < D; i++)
            {
                cube[0, 0, i] = 1;
            }
            //2
            for (int i = 0; i < H; i++)
            {
                cube[0, i, 0] = 1;
            }
            //3
            for (int i = 0; i < W; i++)
            {
                cube[i, 0, 0] = 1;
            }
            //4
            for (int i = 0; i < D; i++)
            {
                cube[W - 1, 0, i] = 1;
            }
            //5
            for (int i = 0; i < H; i++)
            {
                cube[W - 1, i, 0] = 1;
            }
            //6
            for (int i = 0; i < W; i++)
            {
                cube[i, H - 1, D - 1] = 1;
            }
            //7
            for (int i = 0; i < D; i++)
            {
                cube[0, H - 1, i] = 1;
            }
            //8
            for (int i = 0; i < H; i++)
            {
                cube[W - 1, i, D - 1] = 1;
            }
            //9
            for (int i = 0; i < W; i++)
            {
                cube[i, 0, D - 1] = 1;
            }
            //10
            for (int i = 0; i < H; i++)
            {
                cube[0, i, D - 1] = 1;
            }
            //11
            for (int i = 0; i < D; i++)
            {
                cube[W - 1, H - 1, i] = 1;
            }
            //12
            for (int i = 0; i < W; i++)
            {
                cube[i, H - 1, 0] = 1;
            }


            #endregion;

            while (true)
            {
                int endW = startW + 1;
                int endH = startH + 1;
                int endD = startD + 1;

                if (cube[startW + laserW, startH + laserH, startD + laserD] == 1)
                {
                    Console.WriteLine("{0} {1} {2}", endW, endH, endD);
                    break;
                }

                startW += laserW;
                startH += laserH;
                startD += laserD;

                cube[startW, startH, startD] = 1;

                // Testing
                /// end testing
                // Testing for D
                if (startD + laserD > D - 1)
                {
                    laserD *= -1;
                }
                if (startD + laserD < 0)
                {
                    laserD *= -1;
                }
                // Testing for H
                if (startH + laserH > H - 1)
                {
                    laserH *= -1;
                }
                if (startH + laserH < 0)
                {
                    laserH *= -1;
                }
                // Testing for W
                if (startW + laserW > W - 1)
                {
                    laserW *= -1;
                }
                if (startW + laserW < 0)
                {
                    laserW *= -1;
                }
            }
            #region PrintingCube
            //for (int i = 0; i < D; i++)
            //{
            //    for (int j = 0; j < W; j++)
            //    {
            //        Console.Write(cube[j, 5, i]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion;
        }
    } 
}
