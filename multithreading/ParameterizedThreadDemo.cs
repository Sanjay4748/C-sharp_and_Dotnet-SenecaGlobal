class ParameterizedThreadDemo
{
     static void Test1(object num){
        int num1 = Convert.ToInt32(num);
        for(int i = 0;i<num1;i++){
            Console.WriteLine("number os test "+ i);
        }
    }
    static void Main(){
        ParameterizedThreadStart pmts = new ParameterizedThreadStart(Test1);
        Thread t1 = new Thread(pmts);
        t1.Start(20);
    }
}