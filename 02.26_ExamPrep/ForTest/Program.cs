using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "     ";
            str = str.TrimStart();
            str = str.TrimEnd();

            Console.WriteLine(str + "!");
        }
    }
}
