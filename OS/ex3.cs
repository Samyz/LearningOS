using System;
using System.Threading;

namespace OS
{
    class ex3
    {
        static int resource = 10000;
        static void TestThread1(){
            resource = 55555;
        }
        static void TestThread2(){
            int i;
            for (i = 0; i < 45555; i++){
                resource++;
                Console.Write(".");
            }
        }
        public static void execute(int dot)
        {
            Console.WriteLine("Experiment #3\n");
            if(dot == 0){
                Thread th1 = new Thread(TestThread1);
                th1.Start();
                // Thread.Sleep(10);
                Console.WriteLine("resource={0}", resource);
            }
            else{
                Thread th1 = new Thread(TestThread2);
                th1.Start();
                Thread.Sleep(10);
                Console.WriteLine("resource={0}", resource);
            }
        }
    }
}

