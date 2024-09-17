// extension methods are useful in cases when if i have a class and want to add some methods to that class then there are possibilities that 
//  1. we can inherit and define methods in child class and so that when we create a instance of child class all the methods of parent and child class includes 
//  problems with inheritence 
//  if the parent class is sealed or its structure we cannot inherit it so to overcome this problem 
//  we create a class and extend the methods to the parent class by using this keyword
//  
using System.Drawing;

class Program
{
    public void SameMethod(){
        Console.WriteLine("method in parent class called");
    }
    static void Main(){
        Program p = new Program();
        p.Test(); // we can see here that the test method is called we did not inherit it but we did bind it with that
        p.SameMethod(); // here the method is present in both the parent class and the extension method as well so at that cases the parent class methoad overrides the extension class method 
        p.ExtensionParam(10); // here the method is having a parameter that is we can also define methods with parameters 
        int i = 5;
        long result = i.Factorial(); // we can see here the method is added to the class int32 
        Console.WriteLine(result);
        string s = "sanjay";
        string newstr = s.AddPullStop(); // we can see here the method is added to sealed class as well here 
        Console.WriteLine(newstr);
    }
    
}