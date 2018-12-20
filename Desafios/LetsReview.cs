using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class LetsReview
    {
     /*   static void Main(String[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();
                Console.WriteLine(decodeString(s));
            }
        }*/

        private static String decodeString(string s)
        {
            String letterOdd = "";
            String letterEven = "";

            for (int i =0; i<= s.Length - 1; i++)
            {
            if (i % 2 == 0)
                {
                    letterEven = letterEven + s[i];

                }
                else
                {
                    letterOdd = letterOdd + s[i];
                }
            }

            return letterEven + " " + letterOdd;
        }
    }
}
