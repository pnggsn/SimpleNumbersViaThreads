using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumbersApp
{
    class ParallelStream
    {
        //public static List<int> Array = null;
        //private static int TrueCount = 0;

        //private static void main(List<int> array, int threadCount)
        //{
        //    Array = array;

        //    int elemsArray = Array.Count / threadCount;
        //    int elemsOut = Array.Count % threadCount;

        //    Parallel.For(1, threadCount, i =>
        //    {
        //        List<int> arr = Array.GetRange(0, elemsArray);
        //        Array.RemoveRange(0, elemsArray);
        //        solution(arr);
        //    });

        //    while (elemsOut != 0)
        //    {
        //        Parallel.For(1, threadCount, i =>
        //        {
        //            elemsArray = Array.Count / threadCount;
        //            elemsOut -= elemsArray;

        //            List<int> arr = Array.GetRange(0, elemsOut);
        //            Array.RemoveRange(0, elemsOut);
        //            solution(arr);

        //            elemsOut -= elemsOut;
        //        });
        //    }
        //}
        //private static void solution(object obj)
        //{
        //    if (obj is List<int> b)
        //    {
        //        int trueCount = 0;
        //        foreach (int i in b)
        //        {
        //            int def = (int)Math.Sqrt(i);
        //            int del = 0;
        //            for (int j = 2; j <= def; j++)
        //            {
        //                if (i % j == 0)
        //                    del++;
        //            }
        //            if (del == 0 || i != 1)
        //                trueCount++;
        //        }
        //        TrueCount += trueCount;
        //    }
        //}

        public static void Execute(List<int> arr, int count)
        {
            //main(arr, count);
            //if (TrueCount == 0)
            //    Console.WriteLine("Fasle: в массиве нет простых чисел чисел");
            //else
            //    Console.WriteLine("True: в массиве есть хотя бы одно простое число");
        }
    }
}
