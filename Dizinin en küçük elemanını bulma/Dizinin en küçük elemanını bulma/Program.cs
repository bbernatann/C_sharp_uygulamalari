using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizinin_en_küçük_elemanını_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Dizinin "+(i+1)+". elemanını giriniz:");
                dizi[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(dizi);

            Console.WriteLine("\nOluşturduğunuz dizinin en küçük elemanı:" + dizi[0]);
        }
    }
}
