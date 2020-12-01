using System;
using System.Threading;

namespace OS
{
    class ex5
    {
        private static int x = 0;
        private readonly static Object myLock = new Object();
        static void FuncA(){
            
            int xx = 0;
            while (xx < 500) {lock(myLock){
                Console.WriteLine("FuncA: round:{0} x={1}", xx, x);
                x++;}
                xx++;
            }
            
        }
        static void FuncB(){
            
            int xx = 0;
            while (xx < 500) {lock(myLock){
                Console.WriteLine("FuncB: round:{0} x={1}", xx, x);
                x++;}
                xx++;
            }
            
        }
        public static void execute()
        {
            Console.WriteLine("Experiment #5\n");
            Thread th1 = new Thread(FuncA);
            Thread th2 = new Thread(FuncB);
            th1.Start();
            th2.Start();
        }
    }
}

