using System;
using System.Threading;

namespace OS
{
    class ex4
    {
        static int resource = 10000;
        static void TestThread1(){
            int i;
            for (i = 0; i < 45555; i++){
                resource++;
                Console.Write(".");
            }
        }
        public static void execute()
        {
            Console.WriteLine("Experiment #4\n");
            Thread th1 = new Thread(TestThread1);
            th1.Start();
            // Thread.Sleep(10);
            th1.Join();
            Console.WriteLine("resource={0}", resource);
        }
    }
}

