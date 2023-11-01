using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_sayıya_göre_renk_değiştirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı girin(0-15):");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor = renk;
            Console.Clear();
            Console.ReadLine();
        }
    }
}
