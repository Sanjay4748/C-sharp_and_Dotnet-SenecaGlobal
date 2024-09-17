//  delegates have predefined 3 generic delegates that are func,action,predict these are very useful we no need to define the delegate
// func if we have input and output formats 
// action if we have only input formats and no output format that is void 
//  predict if we have the output type as bool 
class GenericDelegates
{
    public static int AddNumbers(int i ,int j,int k){
        return i+j+k;
    }
    public static void SayHello(string str){
        Console.WriteLine($"hey guys i am action delegate written by {str}");
    }

    public static bool CheckLength(string name){
        if(name.Length>5){
            return true;
        }
        return false;
    }

    static void Main(){
        //  func here is used if we have return type and upro 16 parameters and any type of return
        Func<int ,int ,int ,int > obj = AddNumbers;
        int result = obj.Invoke(3,3,4);
        Console.WriteLine(result);
        //  action here is no return type and upto 16 inputs of any type 
        Action<string> objstr = SayHello;
        objstr.Invoke("sanjay");
        //  if the return type is bool and only with one parameter then predict we can use or we can go to func also 
        Predicate<string> onjbool = CheckLength;
        bool chckresult = onjbool.Invoke("sanjay");
        Console.WriteLine(chckresult);
        //  we can also use lamda function here as well 
        Func<int ,int ,int ,int > objlamda = (x,y,z) =>{
            return x+y+z;
        };
        Console.WriteLine(objlamda.Invoke(2,3,5));

        }
    
}