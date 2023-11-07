using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yıldızlarla_Şekil_Oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dik üçgen oluşturma
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //Tersten dik üçgen oluşturma
            for(int i = 0; i < 10; i++)
            {
                for(int j=10;j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
