using System;
using System.Threading;

namespace OS
{
    class ex6
    {
        private static string x = "";
        private static int exitflag = 0;
        private static bool Write = true;
        private readonly static Object myLock = new Object();
        static void ThReadX(Object i){
            while (exitflag == 0){
                lock (myLock){
                if (!Write){
                // lock (myLock){
                // while (Write)
                //     Monitor.Wait(myLock);
                if(x != "exit"){
                    Console.WriteLine("Thread {0} X = {1}", i, x);
                    Write = true;
                }
                // }
                }
                else{
                    Monitor.Wait(myLock);
                }
                }
            }
            Console.WriteLine("Thread {0} exit", i);
        }
        static void ThWriteX(){
            string xx;
            while (exitflag == 0) {
                // if(Write){
                lock (myLock){
                    Console.Write("Input: ");
                    xx = Console.ReadLine();
                    if (xx == "exit"){
                        exitflag = 1;
                    }
                    // else{
                    x = xx;
                    Write = false;
                    // }
                    Monitor.PulseAll(myLock);
                     
                }
                Thread.Sleep(100); 
                // }
            }
            Console.WriteLine("Thread Write exit");
        }
        public static void execute()
        {
            Console.WriteLine("Experiment #6\n");
            Thread A = new Thread(ThReadX);
            Thread B = new Thread(ThWriteX);
            Thread C = new Thread(ThReadX);
            Thread D = new Thread(ThReadX);
            A.Start(1);
            B.Start();
            C.Start(2);
            D.Start(3);
        }
    }
}

