using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetik_4_İşlem_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, toplama,cikarma,carpma;
            double bolme;

            Console.Write("1. sayiyi giriniz:");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayiyi giriniz:");
            num2=Convert.ToInt32(Console.ReadLine());

            toplama = num1 + num2;
            cikarma = num1 - num2;
            carpma = num1 * num2;
            bolme=(double)num1/(double)num2;

            Console.Write("\nTOPLAM:"+toplama+"\nÇIKARMA:"+cikarma+"\nÇARPMA:"+carpma+"\nBÖLME:"+bolme+"\n");

        }
    }
}
