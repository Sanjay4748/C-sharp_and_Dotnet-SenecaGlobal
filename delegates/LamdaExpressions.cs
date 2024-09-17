
// lamda expression are the short form of anonymous function these are represented with => lamda expression 
class LamdaExpressions
{
    static void Main(){
    
        SayHello obj =  (name) =>{
            return "heyy hi every one from "+name;
        };
        string anonygreeting = obj.Invoke("sanjay");
        Console.WriteLine(anonygreeting);
        
    }
}