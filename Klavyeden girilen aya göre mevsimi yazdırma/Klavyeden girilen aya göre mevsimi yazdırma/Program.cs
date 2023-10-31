using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_aya_göre_mevsimi_yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;

            Console.Write("Mevsimi giriniz(ilk harfi büyük olsun):");
            mevsim=Console.ReadLine();

            if(mevsim == "Kış")
            {
                Console.WriteLine("Kış mevsiminin ayları:Aralık,Ocak,Şubat");
            }
            else if(mevsim == "İlkbahar")
            {
                Console.WriteLine("İlkbahar mevsiminin ayları:Mart,Nisan,Mayıs");
            }
            else if(mevsim=="Yaz")
            {
                Console.WriteLine("Yaz mevsiminin ayları:Haziran,Temmuz,Ağustos");
            }
            else if(mevsim=="Sonbahar")
            {
                Console.WriteLine("Sonbahar mevsiminin ayları:Eylül,Ekim,Kasım");
            }
            else
            {
                Console.WriteLine("Hatalı mevsim girişi!");
            }
        }
    }
}
