interface Interface1{
    void Add();
    void Display();
}
interface Interface2{
    void Sub();
    void Display();
}
interface Interface3:Interface1,Interface2{
    // multiple inheritance is supported in interfaces 

    void Multi();
}

class MultipleInheritenceSupport:Interface1,Interface2{
    // multiple inheritance is supported with classes as well 
    public void Add(){
        Console.WriteLine(2+3);
    }
    public void Sub(){
        Console.WriteLine(9-3);
    }
    //  here both will satify with one method itself 
    public void Display(){
        Console.WriteLine("which method callled");
    }
}