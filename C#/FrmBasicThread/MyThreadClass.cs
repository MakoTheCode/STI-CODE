using System;
using System.Threading;

namespace BasicThreadApp
{
    public static class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            for (int loopCount = 0; loopCount <= 5; loopCount++)
            {  
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);
                Thread.Sleep(1500);
            }
        }
    }
}
