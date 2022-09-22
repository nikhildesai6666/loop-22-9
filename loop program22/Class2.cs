using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program22
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            //54321
            //5432
            //543
            //54
            //5

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j++)
                {
                    Console.WriteLine("i");
                }
                Console.WriteLine();

            }
        }
    }
}
