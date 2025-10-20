using System;
using System.Threading;

public class MyThreadClass
{
    public static void Thread1()
    {
        for (int i = 0; i <= 2; i++)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
            Thread.Sleep(500);
        }
    }

    public static void Thread2()
    {
        for (int i = 0; i <= 5; i++)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
            Thread.Sleep(1500);
        }
    }
}
