using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotla_sayının_üssünü_alma
{
    class Program
    {
        private static int KupAlma(int num1,int us)
        {
            int snc=1;
            if (us == 0)
            {
                snc = 1;
            }
            else
            {
                for(int i = 1; i <= us; i++)
                {
                    snc = snc * num1;
                }
            }
            return snc;
        }
        static void Main(string[] args)
        {
            int num, us;

            Console.Write("Sayıyı giriniz:");
            num = Convert.ToInt16(Console.ReadLine());

            Console.Write("Üssü giriniz:");
            us = Convert.ToInt16(Console.ReadLine());

            int sonuc=KupAlma(num, us);

            Console.WriteLine("Sonuç:"+sonuc);
        }
    }
}
