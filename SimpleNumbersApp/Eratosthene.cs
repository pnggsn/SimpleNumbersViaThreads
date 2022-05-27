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
        private static int TrueCount = 0;
        private static bool solution(List<int> a)
        {
            int trueCount = 0;
            foreach (int i in a)
            {
                int def = (int)Math.Sqrt(i);
                int del = 0;
                for (int j = 2; j <= def; j++)
                {
                    if (i % j == 0)
                        del++;
                }
                if (del == 0 || i != 1)
                    trueCount++;
            }
            TrueCount += trueCount;

            if (TrueCount == 0)
                return false;
            else
                return true;
        }

        public static void Execute(List<int> a)
        {
            Console.WriteLine(solution(a));
        }
    }
}
