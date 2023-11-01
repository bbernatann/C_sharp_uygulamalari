using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çok_boyutlu_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] dizi= new int[2,3];
            
            for(i=0;i<2;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.Write("Dizinin {0}{1} değerini giriniz:", i, j);
                    dizi[i,j] =int.Parse(Console.ReadLine());//.Parse burda girilen 12 sayısını ayırıp indislere koyar.
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0}", dizi[i, j]);
                }
            }

        }
    }
}
