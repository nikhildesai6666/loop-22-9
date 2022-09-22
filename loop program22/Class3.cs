using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program22
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            //12345
            //1234
            //123
            //12
            //1

            for (int i = 1; i <=5; i--)
            {
                for (int  j = 1;  j <=i;  j--)
                {
                    Console.WriteLine("i");

                }
                Console.WriteLine();

            }
        }
    }
}
