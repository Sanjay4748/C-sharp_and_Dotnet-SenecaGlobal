using System;
using System.Threading;
class ThreadLockingDemo
{
    public void Display(){
        lock (this) // by this method the thread cannot enter the block until the complete block is finished executing 
        // now using this we can get the desired product 
        {
            Console.Write("hi everyone this is ");
            Thread.Sleep(5000);
            Console.WriteLine("sanjay");
        }
    }

    static void Main(){
        ThreadLockingDemo tld = new ThreadLockingDemo();
        Thread t1 = new Thread(tld.Display);
        Thread t2 = new Thread(tld.Display);
        Thread t3 = new Thread(tld.Display);
        // here by calling method like this the first thread executes and doesnt wait till completion of next block of code 
        // so to overcome the problem to check that certain amount code is executed without fail we can lock that particular amount of code 
        t1.Start();t2.Start();t3.Start();
    }
}