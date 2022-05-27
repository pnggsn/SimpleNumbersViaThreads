using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumbersApp
{
    class ParallelStream
    {
        private static void ThreadsSolution(List<int> array)//, int threadCount)
        {
            //List<int> arr = new List<int>() { };
            int trueCount = 0;

            Parallel.ForEach(array, (int elem) => {
                int def = (int)Math.Sqrt(elem);
                int del = 0;
                for(int j = 1; j <= def; j++)
                {
                    if (elem % j == 0)
                        del++;
                }
                if (del == 0 || elem == 1 || del == 1)
                    trueCount++;
            });

            if (trueCount != 0)
                Console.WriteLine("в массиве есть простые числа");
            else
                Console.WriteLine("в массиве нет простых чисел");
        }

        public static void Execute(List<int> arr)
        {
            ThreadsSolution(arr);
        }
    }
}
