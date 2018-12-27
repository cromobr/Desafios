using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    class Array2D
    {/*
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            Console.WriteLine(hourglasseSum(arr).ToString());
            Console.Read();
        }*/

        private static int hourglasseSum(int[][] arr)
        {
            int soma = 0;
            int atual = 0;


            for (int i=0; i < 4; i++)
            {
                for (int j=0;j < 4 ; j++)
                {

                    atual = arr[i][j] + arr[i][1 + j] + arr[0 + i][2 + j]
                                     + arr[1 + i][1 + j]
                        + arr[2 + i][j] + arr[2 + i][1 + j] + arr[2 + i][2 + j];

                    if (i == 0 & j == 0)
                    {
                        soma = atual;
                    } else if (soma <= atual){
                        soma = atual;
                    }

                  

                }
            }

            return soma;
        }
    }
}
