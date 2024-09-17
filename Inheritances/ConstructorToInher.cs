class ConstructorToInher
{
    int x;
    public ConstructorToInher(int i){
        x = i;
    }

}

class ConstructorToInherMain : ConstructorToInher
{
    // here like this inheritance if child class have a constructor then parent class should also have constructor 
    public ConstructorToInherMain(int i) : base(i)
    {
        Console.WriteLine("The value from child class is"+i);
    }
}