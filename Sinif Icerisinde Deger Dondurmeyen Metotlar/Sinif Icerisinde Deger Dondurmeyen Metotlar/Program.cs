using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Icerisinde_Deger_Dondurmeyen_Metotlar
{
    internal class Program : Mesaj
    {
        static void Main(string[] args)
        {
            Mesaj msj = new  Mesaj();
            msj.metin();
            Console.Read();
        }
    }
}
