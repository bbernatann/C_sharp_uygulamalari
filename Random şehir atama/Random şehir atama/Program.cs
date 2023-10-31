using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_şehir_atama
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            string[] sehirler = { "Adana", "Samsun", "Eskişehir", "Antalya", "Edirne", "İzmir", "Elazığ", "Malatya", "İstanbul", "Aydın", "Şanlıurfa","Hatay"};

            int a=rastgele.Next(0,sehirler.Length);
            Console.WriteLine(a);
            Console.WriteLine(sehirler[a]);
        }
    }
}
