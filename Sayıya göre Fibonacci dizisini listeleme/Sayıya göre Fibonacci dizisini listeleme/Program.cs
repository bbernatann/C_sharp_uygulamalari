using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayıya_göre_Fibonacci_dizisini_listeleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen terim sayısına göre Fibonacci dizisini listeleme
            int i, num1 = 1, num2 = 1, temp;

            Console.Write("Fibonacci dizisinin kaçıncı terimini öğrenmek istediğinizi giriniz:");
            i = Convert.ToInt16(Console.ReadLine());

            if (i == 1)
            {
                Console.WriteLine("1");
            }
            else if (i == 2)
            {
                Console.WriteLine("1\n1");
            }
            else
            {
                Console.WriteLine("1\n1");
                for (int j = 3; j <= i; j++)
                {
                    temp = num1 + num2;
                    num1 = num2;
                    num2 = temp;
                    Console.WriteLine(temp);
                }
            }
        }
    }
}
