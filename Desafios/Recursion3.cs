using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class Recursion3
    {
        static int factorial(int n)
        {
            if (n == 1)
            {
                return (1);
            }
            return n * factorial(n - 1);

        }
        /*
        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            Console.WriteLine(result);

        }*/
    }
}
