class Program
{
    // abstract method are methods with no body are called abstract methods 

    // if a abstract class is defined then the inherited classes should always have the method

    // interface contains only abstract methods and they need to be written when inherited to any classes 
    static void Main(){
        Rectangle rec = new Rectangle(10,20);
        Console.WriteLine(rec.Getarea());
        InterfaceImplement imp = new InterfaceImplement();
        Console.WriteLine(imp.Addition(2,4));
    }
    
}