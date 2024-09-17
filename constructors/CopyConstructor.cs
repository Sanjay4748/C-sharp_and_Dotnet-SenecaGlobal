class CopyConstructor
{
    int x;
    // this is a normal explicit constructor 
    public CopyConstructor(int i){
        x = i;
    }
    // this is a copy constructor means copying a own constructor if we want to create a 2 instances of same values then copy constr can be used
    public CopyConstructor(CopyConstructor obj){
        x = obj.x;
    }

    static void Main(){
        // this is a explicit constructor called with one parameter 
        CopyConstructor cc = new CopyConstructor(10);
        Console.WriteLine(cc.x);
        // this is a copy constructor that is called with reference of 1st parameter 
        CopyConstructor cc1 = new CopyConstructor(cc);
        Console.WriteLine(cc1.x);
    }
}