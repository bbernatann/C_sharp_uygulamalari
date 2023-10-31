using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Komutu
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 ile 10 arasında rastgele satı üretir
            Random rastgele = new Random();
            int a=rastgele.Next(0,10);
            Console.WriteLine(a);
            //0 ile 50 arasında bir sayı üretir
            int b = rastgele.Next(50);
            Console.WriteLine(b);
            //Değişkenin sahip olduğu aralıktan rastegele bir değer döndürür
            int c = rastgele.Next();
            Console.WriteLine(c);

        }
    }
}
