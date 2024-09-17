
//  delegates are used to call the functions wich have same structure like the methods of a class 
public delegate void SayName(string name);

public delegate int AddNumber(int x,int y);

public delegate double Percentage(double number);

class DelegateDemo
{
    public void SayHi(string name){
        Console.WriteLine("hi guys this is"+name);
    }

    public int Sum(int i,int j){
        return i+j;
    }

    static void Main(){
        DelegateDemo dd = new DelegateDemo();
        //  here we create a delegate instance for the methods which we want to call 
        SayName sn = new SayName(dd.SayHi);
        AddNumber an = new AddNumber(dd.Sum);
        // Percentage pc = new Percentage(dd.Sum); this shows error because the sum is int but we gave percentage deligate as double 
        sn("sanjay");
        //  can call in 2 ways with invoke function or using the direct way 
        sn.Invoke("sanjay");
        int num = an(5,5);
        int num1 = an.Invoke(5,5);
        Console.WriteLine(num);
        Console.WriteLine(num1);
    }
    
}