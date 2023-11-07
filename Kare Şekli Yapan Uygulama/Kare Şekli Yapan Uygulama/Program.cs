using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kare_Şekli_Yapan_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar;

            Console.Write("Karenin kenar uzunluğunu giriniz:");
            kenar = Convert.ToInt16(Console.ReadLine());

            
            //Üst kenar
             for(int j = 0;j < kenar; j++)
             {
                Console.Write("* ");
             }
             Console.WriteLine();
            
            //Yan kenarlar
             for(int j = 0; j < kenar-2; j++)                     
             {
                Console.Write("*");
                for(int i = 0; i < kenar-2; i++)   
                {                                  
                    Console.Write("  ");            
                }                                  
                Console.WriteLine(" *");
             }
             //Alt kenar
             for(int j = 0; j < kenar; j++)
            {
                Console.Write("* ");
            }


             Console.WriteLine();

        }
    }
}
