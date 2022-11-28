using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 17. Вычислить частичную сумму ряда S=1/(1*2*3)+1 / (2 * 3 * 4) + 1 / (4 * 5 * 6) +⋯
Вычисление прекратить, когда сумма ряда станет больше 1. */

namespace Lab_3_1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal S = 0;
            decimal n = 0;
            decimal K;
            while (S < 1)
            {
                K = 1 / ((n + 1) * (n + 2) * (n + 3));
                Console.WriteLine($"n+1={n + 1}, n+2={n + 2}, n+3={n + 3},");
                S += K;
                n++;
                Console.WriteLine($"n={n}, K={K}, S={S}");                
            }
            Console.ReadKey();
        }
    }
}
