using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleNumbersApp
{
    class ThreadsEratosthene
    {
        public static List<int> Array = null;
        static int TrueCount = 0;

        private static void ThreadsSolution(List<int> array, int threadCount)
        {
            Array = array;
            List<Thread> threads = new List<Thread>();

            int elemsArray = Array.Count / threadCount;
            int elemsOut = Array.Count % threadCount;

            for (int i = 0; i < threadCount; i++)
            {
                List<int> arr = Array.GetRange(0, elemsArray);
                Array.RemoveRange(0, elemsArray);

                Thread thread = new Thread(solution);
                threads.Add(thread);
                threads[i].Name = "Поток номер " + (i + 1);
                threads[i].Start(arr);
                threads[i].Join();
            }

            while (elemsOut != 0)
            {
                for (int i = 0; i < threadCount; i++)
                {
                    if (!threads[i].IsAlive)
                    {
                        elemsArray = Array.Count / threadCount;
                        elemsOut -= elemsArray;

                        List<int> arr = Array.GetRange(0, elemsOut);
                        Array.RemoveRange(0, elemsOut);
                        threads.RemoveAt(i);

                        Thread thread = new Thread(solution);
                        threads.Insert(i, thread);
                        threads[i].Name = "Поток номер " + (i + 1);
                        threads[i].Start(arr);
                        threads[i].Join();

                        elemsOut -= elemsOut;
                        if (elemsOut <= 0)
                            break;
                    }
                }
            }
        }

        private static void solution(object obj)
        {
            if (obj is List<int> b)
            {
                int trueCount = 0;
                foreach (int i in b)
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
            }
        }

        public static void Execute(List<int> arr, int count)
        {
            ThreadsSolution(arr, count);
            if (TrueCount == 0)
                Console.WriteLine("Fasle: в массиве нет простых чисел чисел");
            else
                Console.WriteLine("True: в массиве есть хотя бы одно простое число");
        }
    }
}

