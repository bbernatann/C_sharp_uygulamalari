using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_ve_Set_Kullanıımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrnc = new Ogrenci();

            ogrnc.ADI = "Oğuz Ali";
            ogrnc.SOYAD = "Deniz";
            ogrnc.YAS = 25;
            ogrnc.ALAN = "Matematik";

            Console.WriteLine("Öğrencinin Adı:" + ogrnc.ADI);
            Console.WriteLine("Öğrencinin Soyadı:" + ogrnc.SOYAD);
            Console.WriteLine("Öğrencinin Yaşı:" + ogrnc.YAS);
            Console.WriteLine("Öğrencinin Alanı:" + ogrnc.ALAN);
        }
    }
}
