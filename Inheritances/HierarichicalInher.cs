class HierarichicalInher
{
    public void MethodHierarichical(){
        Console.WriteLine("Hirerichichal method child is called ");
    }
}

class HierarichicalInher1:HierarichicalInher{

    public void MethodHierarichical1(){
        Console.WriteLine("Hirerichichal method 1 parent is called ");
    }
}

class HierarichicalInher2:HierarichicalInher{
    public void MethodHierarichical2(){
        Console.WriteLine("Hirerichichal method 2 parent is called ");
    }

    static void Main(){
        HierarichicalInher2 hl = new HierarichicalInher2();
        // this is hierarichal inheritance that is a child can be inherited to multiple parents 
        hl.MethodHierarichical();
        hl.MethodHierarichical2();
    }
}