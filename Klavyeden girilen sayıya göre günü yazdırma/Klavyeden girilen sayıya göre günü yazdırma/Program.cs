using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_sayıya_göre_günü_yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Sayıyı giriniz:");
            num=Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:Console.WriteLine("PAZARTESİ");break;
                case 2:Console.WriteLine("SALI");break;
                case 3:Console.WriteLine("ÇARŞAMBA");break;
                case 4:Console.WriteLine("PERŞEMBE");break;
                case 5:Console.WriteLine("CUMA");break;
                case 6:Console.WriteLine("CUMARTESİ");break;
                case 7:Console.WriteLine("PAZAR");break;
                default:Console.WriteLine("HATALI GİRİŞ!");break;
                
            }
            
        }
    }
}
