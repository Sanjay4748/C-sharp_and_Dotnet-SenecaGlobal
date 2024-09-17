class MultilevelInher
{
    public void Methodmultilevel(){
        Console.WriteLine("multilevel 1st class is called");
    }
}
class MultilevelInher1:MultilevelInher{

    public void Method1multilevel(){
        Console.WriteLine("Multilevel 2nd class is called");
    }
}

class MultilevelInher2:MultilevelInher1{
    
    public void Method2multilevel(){
        Console.WriteLine("multilevel 3rd class is called");
    }

    static void Main(){
        MultilevelInher2 m2 = new MultilevelInher2();
        //  this is multi level ineritance all the methods can be accesssed from here this is called multilevel inheritance 
        m2.Methodmultilevel();
        m2.Method1multilevel();
        m2.Method2multilevel();
    }
}