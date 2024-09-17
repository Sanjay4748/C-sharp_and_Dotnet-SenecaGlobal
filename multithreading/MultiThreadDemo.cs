// multithread model is better in performance as well as in time excumption compared to single thread model 
class MultiThreadDemo
{
     public static void Test1(){
        for (int i=0 ; i < 50 ; i++)
        {
            Console.WriteLine("test1 - "+i);
        }
    }
    public static void Test2(){
        for(int i=0;i<50;i++){
            Console.WriteLine("test2 - "+i);
        }
    }
    public static void Test3(){
        for(int i=0;i<50;i++){
            Console.WriteLine("test3 - "+i);
        }
    }

    static void Main(){
        Console.WriteLine("main thread started");
        Thread t1 = new Thread(Test1); // these are threads and we assign each function to each thread so they execute now for some time which is operated by os
        Thread t2 =  new Thread(Test2);
        Thread t3 = new Thread(Test3);
        t1.Start();
        t2.Start();
        t3.Start();// after assigning to multithreads the main thread is exited from the programe and it closes 
        ThreadStart t4 = new ThreadStart(Test1); // we can also write like this the parameter passing inside the thread is a deligate so we can explicitly declare the deligate or clr does it for us 
        Thread t5 = new Thread(t4);
        t5.Start();
        // here what happens is that the main thread is exited before the completion of all threads which should not happen so to over come that we join the threads
        t1.Join();t2.Join();t3.Join();t5.Join(); // with this the main thread will be exited after completion of all threads 
        Console.WriteLine("main thread exited");
    }
}   