class StaticConstructor
{
    public int i;
    //  static constructor is called first at execution even if instance is created or not it will be called first 
    static StaticConstructor(){
        Console.WriteLine("static constructor is called");
    }
    //  explicit constructor is called after instance is created only or else no 
    public StaticConstructor(){
        Console.WriteLine("Constructor is called");
    }
    // static constructors cannot have parameters because they are called first so no chance of creating a variables using this
    // in the life cycle of class the static constructor is called only one time of the executing 
    //  but non static will be called if called n times if n instances are created 

}