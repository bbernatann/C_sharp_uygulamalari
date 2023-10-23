using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_kullanarak_isim_yazdırma
{
    internal class Kisiler
    {
        public void kisiListesi(string adSoyad)
        {
            for(int i = 1; i <= 5;i++)
            {
                Console.WriteLine(adSoyad);
            }
        }
    }
}
