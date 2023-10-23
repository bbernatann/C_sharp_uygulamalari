using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geriye_Deger_Donduren_Metotlar_Conole_App_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islem islem = new Islem();

            int num1, num2;
            
            Console.Write("1.sayıyı giriniz:");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz:");
            num2 = int.Parse(Console.ReadLine());

            islem.topla(num1,num2);
            Console.ReadLine();
        }
    }
}
