using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emlak emlk = new Emlak();

            emlk.SEMT = "Tekkköy";
            emlk.RENK = "Beyaz";
            emlk.ODASAYISI = -4;
            emlk.KATSAYISI = 2;
            emlk.ALAN = 55;

            Console.WriteLine("Evin bulunduğu semt:" + emlk.SEMT);
            Console.WriteLine("Evin rengi:" + emlk.RENK);
            Console.WriteLine("Evin oda sayısı:" + emlk.ODASAYISI);
            Console.WriteLine("Evin bulunduğu kat:" + emlk.KATSAYISI);
            Console.WriteLine("Evin alanı:" + emlk.ALAN);
        }
    }
}
