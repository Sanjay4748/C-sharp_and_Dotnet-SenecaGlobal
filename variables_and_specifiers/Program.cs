using System.Globalization;

class Program:SpecifiersDemo
{
    // if not declared the variable is it self a static variable 
    int i = 0;
    
    static int k=10;
    const float pi = 3.14f; // variable declared const cannot be changed at any point 

    readonly int j; // read only variables are instialised at only once and then next they cannot be modified so they are mostly initiliazed in constructor in self

    static void Main(string[] args){
        Program p = new Program(); // here p is the intsance of the class
        Program p1; // here p1 is the variable of the class
        p1 =  new Program();
        Console.WriteLine(p.i);
        //  here the method 2 is not available because its private method which cannot be accessible when inherited but all methods can be accessed
        p.Method1();
        p.Method3();
        p.Method4();
        p.Method5();
        // Console.WriteLine(i); here i cannot be accessed as its non static so it needs instanvce to access 
        Console.WriteLine(k); // k is accesed with out instance as it static variable 
        k = 20;
        Console.WriteLine(k);
        // pi = 22.22f; gives a error as pi is a constant 



    }
}