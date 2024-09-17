// these are generic methods which we give as the type as a genric and the variables are automatically converted into the type that we gave generic 
class GenericMethods<T>
{
     public bool Compare(object a, object b){
        if(a.Equals(b)){
            return true;
        }
        return false;
    }

    public bool CompareGenrics<T>(T a,T b){ // this feature of taking the type as the parameter type is called as generics 
        if(a.Equals(b)){
            return true;
        }
        return false;
    }

    public void Add<T>(T a,T b){ // we know var(implicit variable) it executes at the tym of compilation tym but dunamic executes at the time of runtime
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1+d2);
    }

    // static void Main(){
    //     GenericMethods<int> gm = new GenericMethods<int>(); // we can also give the generic for class if every method in class is a generic 
    //     Console.WriteLine(gm.Compare(10,10));
    //     Console.WriteLine(gm.CompareGenrics<int>(4,3));
    // }

}