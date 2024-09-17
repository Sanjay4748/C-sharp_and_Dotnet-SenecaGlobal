using System;
using System.Threading;
// thread is a process that executes if a main method then a single thread executes 
// in a single thread every method executes one by one by order 
// every proess is a single thread application by default 
class SingleThread
{
    public static void Test1(){
        for (int i=0 ; i < 50 ; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void Test2(){
        for(int i=0;i<50;i++){
            Console.WriteLine(i);
        }
    }
    public static void Test3(){
        for(int i=0;i<50;i++){
            Console.WriteLine(i);
        }
    }

    static void Main(){
        // in a single thred process the execution takes place line by line and its take long time 
        Console.WriteLine("main thread execution started");
        Test1(); // first this execution takes places 
        Thread.Sleep(5000);// this will stop the process for 5 seconds 
        Test2(); // next this execution takes place
        Test3(); // next this execution tales place 
        Console.WriteLine("main thread exited");
    }   
 }