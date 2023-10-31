using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizideki_Pozitif_ve_Tek_Sayıları_Listeleme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = {1,2,-8,7,-7,5,-12,17,22,25 };

            foreach (int i in dizi)
            {
                if(i>0 && i%2!=0) { 
                   Console.WriteLine(i);
                }
            }
        }
    }
}
