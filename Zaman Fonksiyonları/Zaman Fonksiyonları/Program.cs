using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaman_Fonksiyonları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman;
            zaman= DateTime.Now;

            int gun = zaman.Day;
            int ay = zaman.Month;
            int yil = zaman.Year;

            DayOfWeek haftaningunu = zaman.DayOfWeek;

            Console.WriteLine("GÜN:{0}", gun);
            Console.WriteLine("AY:{0}", ay);
            Console.WriteLine("YIL:{0}", yil);
            Console.WriteLine("HAFTANIN GÜNÜ:{0}", haftaningunu);

            //
            Console.WriteLine("\n********** Tarih Saat Fonksiyonları **********\n");
            Console.WriteLine("Kısa Tarih:{0:d}",zaman);
            Console.WriteLine("Uzun Tarih:{0:D}",zaman);
            Console.WriteLine("Tam Tarih:{0:f}",zaman);
            Console.WriteLine("Tam Tarih:{0:F}", zaman);
            Console.WriteLine("Sayısal Tarih:{0:g}", zaman);
            Console.WriteLine("Sayısal Tarih:{0:G}", zaman);
            Console.WriteLine("Ay:{0:m}", zaman);
            Console.WriteLine("Biçim:{0:r}", zaman);
            Console.WriteLine("Biçim:{0:s}", zaman);
            Console.WriteLine("Saat:{0:t}", zaman);
            Console.WriteLine("Saat:{0:T}", zaman);
            Console.WriteLine("Yıl:{0:Y}", zaman);
        }
    }
}
