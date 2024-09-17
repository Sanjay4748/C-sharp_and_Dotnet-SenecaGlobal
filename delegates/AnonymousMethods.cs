// anonymous methods are methods with no method name and these are used for very less code cases 

public delegate string SayHello(string name);
class AnonymousMethods
{
    public static string Hello(string name){
        return "heyy hi every one from "+name;
    }
    static void Main(){
        //  here is the normal way of calling the delegate by declaring a function and calling the delegate 
        SayHello obj1 = new SayHello(Hello);
        string greeting = obj1.Invoke("sanjay");
        Console.WriteLine(greeting);
        //  here is the anonymous function easliy by writing here and no need to declare the function again in class 
        //  as we can see the anonymous function has no name just the body 
        SayHello obj = delegate (string name){
            return "heyy hi every one from "+name;
        };
        string anonygreeting = obj.Invoke("sanjay");
        Console.WriteLine(anonygreeting);
        
    }
}