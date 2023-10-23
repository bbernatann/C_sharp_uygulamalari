using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_kullanarak_isim_yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisiler ks = new Kisiler();
            string ads;
            Console.Write("İsim Girin:");
            ads = Console.ReadLine();
            ks.kisiListesi(ads);
            Console.ReadLine();
        }
    }
}
