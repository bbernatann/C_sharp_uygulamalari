using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Abs fonksiyonuyla sayının mutlak değerini alıyoruz
            int sayi;
            Console.Write("Mutlak değerini almak istediğinin sayıyı giriniz:");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sayının mutlak değeri:" + Math.Abs(sayi));

            //Math.Ceiling fonksiyonu ile sayıyı üste yuvarlıyoruz
            double sayi2;
            Console.Write("Yuvarlamak istediğiniz sayıyı giriniz(Virgül kullanınız):");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayının üste yuvarlanmış hali:" + Math.Ceiling(sayi2));

            //Math.Floor fonksiyonu ile sayıyı alta yuvarlıyoruz
            Console.Write("\nSayının alta yuvarlanmış hali:" + Math.Floor(sayi2));

            //Math.Pow fonksiyonu ile sayının üssünü alıyoruz
            int us;
            Console.Write("\nGirdiğiniz ilk sayının kaçıcı üssünü almak istediğiniz giriniz:");
            us = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sonuç:"+Math.Pow(sayi,us));
            
            //Math.Sqrt fonksiyonu ile sayının karekökünü alıyoruz
            int sayi3=Math.Abs(sayi);
            Console.WriteLine("Girdiğinin ilk sayının mutlak değerinin karekökü:" + Math.Sqrt(sayi3));

            

            //İki sayıyı karşılaştırırken Math.Max fonksiyonu ile büyük olanı Math.Min fonksiyonu ile küçük olan sayıyı buluruz
            Console.WriteLine("Büyük olan sayı:" + Math.Max(sayi, sayi2));
            Console.WriteLine("Küçük olan sayı:"+Math.Min(sayi, sayi2));
        }
    }
}
