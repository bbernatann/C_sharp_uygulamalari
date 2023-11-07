using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elmas_Şekli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Elmas şekli sayısı:");
            num = Convert.ToInt16(Console.ReadLine());

            for(int i=1;i<=num; i++) 
            {
                Console.WriteLine();
                for(int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int y=1; y<=i; y++)
                {
                    Console.Write("* ");
                }
            }

            Console.WriteLine();

            for(int i=1 ; i<=num ; i++)
            {
                for (int j = 1; j <= i; j++)                 
                {
                    Console.Write(" ");
                }
                for (int y = num; y >i; y--)
                {
                    Console.Write("*"+" ");                    
                }                                                                   

                Console.WriteLine();
            }

        }
    }
}
