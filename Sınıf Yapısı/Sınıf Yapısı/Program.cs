using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Yapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba arabsnf = new Araba();

            arabsnf.renk = "Siyah";
            arabsnf.fiyat = 1987000;
            arabsnf.model = "2018";
            arabsnf.vites = "Otomatik";
            arabsnf.plaka = "55 BT 1903";

            Console.WriteLine("\nArabanın rengi:" + arabsnf.renk);
            Console.WriteLine("Arabanın fiyatı:" + arabsnf.fiyat);
            Console.WriteLine("Arabanın model:" + arabsnf.model);
            Console.WriteLine("Arabanın vites:" + arabsnf.vites);
            Console.WriteLine("Arabanın plaksı:" + arabsnf.plaka);

            arabsnf.renk = "Beyaz";
            arabsnf.fiyat = 2987000;
            arabsnf.model = "2023";
            arabsnf.vites = "Otomatik";
            arabsnf.plaka = "55 HT 1979";

            Console.WriteLine("\n\nArabanın rengi:" + arabsnf.renk);
            Console.WriteLine("Arabanın fiyatı:" + arabsnf.fiyat);
            Console.WriteLine("Arabanın model:" + arabsnf.model);
            Console.WriteLine("Arabanın vites:" + arabsnf.vites);
            Console.WriteLine("Arabanın plaksı:" + arabsnf.plaka);

        }
    }
}
