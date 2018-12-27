using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class Scope
    {
        class Difference
    {
        private int[] elements;
        public int maximumDifference;

            public Difference(int[] a)
            {
                this.elements = a;
            }
            public void computeDifference()
            {
                 this.maximumDifference = 0;
                int calc = 0;

                for (int i =0; i < elements.Length-1; i++)
                {
                   
                    for (int j = i; j < elements.Length; j++)
                    {
                        calc = Math.Abs(elements[i] - elements[j]);
                        if (maximumDifference < calc)
                        {
                            maximumDifference = calc;
                        }
                    }
                }
           }

        } 
    
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
