using System;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.Name = "Main Thread ...";
            //Thread t = new Thread(WriteY);
            //t.Name = "Y Thread ...";
            //t.Start();
            //Console.WriteLine(Thread.CurrentThread.Name);
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write("x");
            //}

            Thread t = new Thread(WriteY);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended！");
        }
        static void WriteY()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }
    }
}
