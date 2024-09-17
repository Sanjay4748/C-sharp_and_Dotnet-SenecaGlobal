
//  when definig a thread we can also give the priority for the thread like lowest, below normal, normal, above normal, highest
//  where normal is the default of all threads  
class ThreadPrioritiesDemo
{
    public static long count1,count2;
    public static void IncereaseCount1(){
        while(true){
            count1+=1;
        }
    }
    public static void IncereaseCount2(){
        while(true){
            count2+=1;
        }
    }

    static void Main(){
        Thread t1 = new Thread(IncereaseCount1);
        Thread t2 = new Thread(IncereaseCount2);
        ThreadPriority threadPriority = ThreadPriority.Highest; // by declaring like this the thread priority can be given and it will be treated accordingly 
        t1.Start(threadPriority);t2.Start();
        Thread.Sleep(5000);
        t1.Abort(); // this is used to stop and terminate the thread 
        t2.Abort();
        Console.WriteLine("count 1 value is "+count1);
        Console.WriteLine("count 2 value is "+count2);

    }
}