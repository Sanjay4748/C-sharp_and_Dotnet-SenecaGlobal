struct StructureDemo
{
    //  inheritence is not supported in structures 
    
    //  structures are used basically for representing the small entities beacuse they are value type so memory is stored in stack 
    
    //  there are 2 important points to be noted is that in early version of c# initilization of variables at starting is not allowed 
    //  but now we can initilize the values now at newer version of c# 
    //  and in struct we cannot define the explicit constructor without parameters itt will show an error but in newer versions we can define it 
    int i = 10;
    public void Display(){
        Console.WriteLine("method in structure called"+i);
    }
    // even if parameterised constructor is initilized then also the implicit constructor will call 
    public StructureDemo(){
        Console.WriteLine("value of i is ");
    }
    
}

