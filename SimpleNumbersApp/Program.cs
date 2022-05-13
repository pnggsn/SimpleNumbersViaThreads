using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SimpleNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = FileReadArray(); //считывание массива с файла
            Console.Read();

            if (array != null)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Для выхода из программы нажмите ESC");
                    Stopwatch time = new Stopwatch();

                    Console.WriteLine("Последовательное решение");
                    time.Start();
                    Eratosthene.Execute(array);
                    time.Stop();
                    TimeCount(time);

                    Console.WriteLine("С двумя потоками");
                    time.Start();
                    ThreadsEratosthene.Execute(array, 2);
                    time.Stop();
                    TimeCount(time);

                    Console.WriteLine("С тремя потоками");
                    time.Start();
                    ThreadsEratosthene.Execute(array, 3);
                    time.Stop();
                    TimeCount(time);

                    Console.WriteLine("ParallelStream с двумя итерациями");
                    time.Start();
                    ParallelStream.Execute(array, 2);
                    time.Stop();
                    TimeCount(time);

                } while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Выход...");
            }
        }

        private static void TimeCount(Stopwatch st)
        {
            TimeSpan ts = st.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00} \n", 
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            st.Reset();
        }
        private static List<int> FileReadArray()
        {
            List<int> array = new List<int>();
            try
            {
                string path = "array.txt";
                using (StreamReader reader = new StreamReader(path))
                {
                    string text = reader.ReadToEnd();
                    //Console.WriteLine(text);
                    array = text.Split(" ").Select(Int32.Parse).ToList();
                }
                return array;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Массив не удалось считать с файла");
                return array = null;
            }
            finally
            {
                Console.WriteLine("Массив удалось считать с файла");
            }
        }
    }
}