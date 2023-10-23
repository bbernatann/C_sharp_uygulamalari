using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Yapıcı__Metotlar_Ornek_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();

            kml.AD = "Berna";
            kml.SOYAD = "TAN";
            kml.YAS = 21;

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);

            Console.Read();

        }
    }
}
