class MethodOverloadingDemo
{
    //  method overloading is something related to polymorphism that a function name can be same until it have different parameters

    //  here we can see that the all functions down here are with same name but have different works at dfferent times 
    public int Method(int i){
        return i; 
    }
    
    public int Method(){
        return 2+3;
    }

    public string Method(string s){
        return s;
    }

    public int Method(int j, string s){
        int n = Convert.ToInt32(s);
        return j+n;
    }

    public int Method(string s , int j){
        Console.WriteLine(s);
        return j;
    }
}