using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2X2_matrislerde_determinant_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 2];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write("{1}X{0} değeri:", i + 1, j + 1);
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int determinant = (A[0, 0] * A[1, 1]) - (A[0, 1] * A[1, 0]);

            Console.WriteLine("Determinant=" + determinant);
        }
    }
}
