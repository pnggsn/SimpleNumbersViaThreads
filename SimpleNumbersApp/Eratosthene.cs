using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumbersApp
{
    class Eratosthene
    {
        //последовательное решение поиска
        private static bool solution(int a)
        {
            int b = a;
            int del = 0;
            for (int i = 2; i <= b; i++)
            {
                if (b % i == 0)
                del++;
            }
            if (del == 1)
                return true;
            return false;
        }

        public static void Execute(int a)
        {
            Console.WriteLine(solution(a));
        }
    }
}
