class MultipleInher
{
    public void Method1(){
        Console.WriteLine("Method1 from a class 1");
    }
}

class MultipleInher1{

    public void Method2(){
        Console.WriteLine("Method2 from a class 2");   
    }
}

// class MultipleInher2:MultipleInher,MultipleInher1{
//     //  here it will show the error as c# doesnt support multiple inheritence 
// }