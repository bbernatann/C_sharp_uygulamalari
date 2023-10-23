using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Yapıcı__Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string blg;
            
            Console.Write("Ad soyad ve kulüp bilgisini giriniz:");
            blg=Console.ReadLine();

            Ogrenci ogr = new Ogrenci(blg);


        }
    }
}
