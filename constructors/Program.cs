class Program
{
    public int i;
    // implicit constructor every class have a implicit cinstructor which initilizes the values it self like 0 or null or false
    public int j;
    // explict constructor which we define so that i value will be what was given by user 
    public Program(int i){
        Console.WriteLine("Constructor is called");
        this.i = i;
    }

    static void Main(string[] args){
        // given 1 so i value is 1 
        Program p = new Program(1);
        Console.WriteLine(p.i);
        // given 2 so i value will be 2
        Program p1 = new Program(2);
        Console.WriteLine(p1.i);
        // constructor is not given for j so it will be initilised by implicit constructor as 0 
        Console.WriteLine(p.j);
        
        

    }
}