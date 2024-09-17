static class ExtensionMethodDemo
{
    public static void Test(this Program p){ // here the this keyword binds with the program 
        Console.WriteLine("hello");
    }
    public static void SameMethod(this Program p){ // extension method with same name of extension method of parent class 
        Console.WriteLine("method in extension class is called");
    }
    public static void ExtensionParam(this Program p,int i){ // extension method with parameters 
        Console.WriteLine("your number is "+i);
    }
    public static long Factorial(this Int32 x){ // we can also add methods to different classes that are not in the project as well 
        if(x == 1){
            return 1;
        }
        else if(x==2){
            return 2;
        }
        else{
            return x * Factorial(x-1);
        }
    }
    public static string AddPullStop(this String str){ // here the String class is a sealed class and also we can add the method to it
        if (str.Trim().Length>0){
            string newstr = str + ".";
            return newstr;
        }
        return str;
    }
}