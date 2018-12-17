using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class ConditionalStatements
    {
        /*
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(processInput(N));
        }
        */
        private static string processInput(int input)
        {
            if (input % 2 > 0)
                return "Weird";
            else if (input >= 2 & input <= 5)
                return "Not Weird";
            else if (input >= 6 & input <= 20)
                return "Weird";
            else if (input > 20)
                return "Not Weird";

            return "Error";
        }
    }
}
