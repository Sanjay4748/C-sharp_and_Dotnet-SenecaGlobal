class Program:Class1
{
    public Program(){
        Console.WriteLine("constructor of parent class is called ");
    }

    public void ParentMethod(){
        Console.WriteLine("parent class method is called");
    }

    static void Main(){
        Program p = new Program();
        // constructer of first child class will be called and then the constructor of parent class will be called 
        Class1 c1 = new Class1();
        // child class instance have access to only child class methods only 
        c1.Method1();
        //  parent class instance have access to all methods including child class as well as it own class 
        p.Method1();
        p.ParentMethod();
    }
}