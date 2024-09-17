public delegate void FigureMeasures(int i,int j);
class MultiCastDelegate
{
    public void Area(int height,int width){
        Console.WriteLine($"the area is {height*width}");
    }
    public void Perimeter(int height,int width){
        Console.WriteLine($"the perimeter is {height+width}");
    }

    static void Main(){
        MultiCastDelegate mcd = new MultiCastDelegate();
        // multi cast deligates are useful for invoking the void functions with same parameters 
        FigureMeasures fm;
        fm = mcd.Area;
        //  like here we can add the function to it and can invoke the both functions at same time 
        fm += mcd.Perimeter;
        //  its not good to use same type functions as well because only the last function will be executed as the return values overrides 
        fm.Invoke(5,5);
        fm.Invoke(10,10);
    }

}
