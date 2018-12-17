using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class ArrayDS
    {
        static void reverseArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[a.Length - i-1]+ " ");
            }

    }
        /*
        static void Main(string[] args)
        {

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            reverseArray(arr);
           
            
        }*/
    }
}
