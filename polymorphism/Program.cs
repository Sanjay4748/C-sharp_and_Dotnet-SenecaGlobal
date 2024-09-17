using System.Globalization;

class Program:MethodOverridingDemo
{
    // here add is virtual and overrided so that the child class overrides this method and perform child class mwthod 
    public override int Add(int i , int j){
        return i-j;
    }
    //  here difference method is not overrided and also it contains same name but no virtual or override its called as method hiding 
    public int Difference(int i , int j){
        return i - j;
    }
    static void Main(){
        Program p = new Program();
        Console.WriteLine(p.Add(5,2));
        //  here we can see we have initilized ob1 and ob2 2 instances of classs
        OperatorOverloadingDemo ob1 = new OperatorOverloadingDemo(5,5);
        OperatorOverloadingDemo ob2 = new OperatorOverloadingDemo(4,4);
        // here we have overloaded the + operator and added the 2 classes objects similar way can define the eq == operator and many other 
        OperatorOverloadingDemo ob3 = ob1+ob2;
        ob3.Display();
        
    }
    
}