using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrislerde_Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 10, 22, 18, 7 }, { 15, 13, 56, 87 }, { 24, 78, 49, 22 }, { 21, 2, 55, 47 } };
            int[,] B = { { 41, 78, 23, 42 }, { 56, 33, 16, 54 }, { 26, 98, 52, 8 }, { 27, 3, 69, 72 } };
            int[,] toplam = new int[4,4];


            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    toplam[i,j]= A[i, j] + B[i,j];
                }
            }

            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine();
                for (int m = 0;m< 4; m++)
                {
                    Console.Write(toplam[k,m] + "  " );
                }
            } 
        }
    }
}
