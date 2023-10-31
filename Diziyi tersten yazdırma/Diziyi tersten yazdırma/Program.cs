using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziyi_tersten_yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Dizinin " + (i + 1) + ". elamanını giriniz:");
                dizi[i] = Convert.ToInt16(Console.ReadLine());
            }

            Array.Reverse(dizi);

            foreach(int i in dizi)
            {
                Console.WriteLine(i);
            }
        }
    }
}
