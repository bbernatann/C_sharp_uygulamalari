using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Matrislerde_İşlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;

            Console.Write("Satır sayisini giriniz:");
            satir = Convert.ToInt16(Console.ReadLine());

            Console.Write("Sütün sayısını girinzi:");
            sutun= Convert.ToInt16(Console.ReadLine());

            int [,] A = new int [satir,sutun];

            for(int i=0; i < satir; i++)
            {
                for(int j=0; j < sutun; j++)
                {
                    Console.Write("Matrisini {0} X {1} değeri:", i + 1, j + 1);
                    A[i,j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            for (int k = 0; k < satir; k++)
            {
                for (int m = 0; m < sutun; m++)
                {
                    Console.Write(A[k, m] + " ");
                }
                Console.WriteLine();
            }

            //Transpoze
            int[,] B = new int[sutun, satir];


            for (int i=0; i < satir; i++)    
            {
                for(int j=0; j < sutun; j++)
                {
                    B[j, i] = A[i, j]; 
                }
                Console.WriteLine();
            }

            for(int k = 0;k < sutun; k++)
            {
                for(int m = 0;m < satir; m++)
                {
                    Console.Write(B[k, m] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //Kat sayı ile çarpma
            Console.Write("Matrisi çarpmak istediğiniz sayıyı giriniz:");
            int n = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < satir; i++)
            {
                for(int j= 0;j < sutun; j++)
                {
                    Console.Write(A[i, j] * n + " ");
                }
                Console.WriteLine() ;
            }

            
        }
    }
}
