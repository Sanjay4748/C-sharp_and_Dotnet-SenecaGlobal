// basically the exceptions are 2 types system exceptions and application exceptions
// system exceptions are exceptions that are given or raised by clr during the runtime and trows it 
//  application exceptions are exceptions that are created by the developer and we can use them to show the exception  

public class NoOddSumException:ApplicationException{
    //  we can also create a class and create a override for readonly property message and can throw it 
    public override string Message
    {
    get{
        return "Sorry sum is odd";
    }
    }
}

class ApplicationExceptionDemo
{
    static void Main(){
        try{
            Console.WriteLine("enter 1st number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int j = int.Parse(Console.ReadLine());
            int z = i+j;
            if(z %2 != 0){
                
                // throw new ApplicationException("sorry no odd sum"); // here we can see that we have thrown a new coustmized exception that performs if the condition is true
                
                throw new NoOddSumException();
                
            } // so like this we can create our own exceptions 
        }
        finally{
            Console.WriteLine("executed finally");
        }
    }
}