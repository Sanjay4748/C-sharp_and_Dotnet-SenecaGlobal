// to use the sorting or comparing of dicts in that are in the lists we use a interface icomparble which compares the values and used for sorting reverse and etc etc 

// to utilize the methods we need to inherit a interface icomparable 
using System.Runtime.CompilerServices;

class Employees:IComparable<Employees>{

    public string EmpName {get;set;}
    public int EmpID {get;set;}
    public string EmpManager {get;set;}
    public int EmpPhn{get;set;}

    public int CompareTo(Employees other) // not only empid we can give any other which we want to sort as here 
    {
        if(this.EmpID > other.EmpID){
            return 1;
        }
        else if(this.EmpID < other.EmpID){
            return -1;
        }
        else {
            return 0;
        }
    }
}

class IComparableDemo1 : IComparer<Employees> // this is used for when we want to write a override compare for predefined classes then this will be helpful
{
    public int Compare(Employees? x, Employees? y)
    {
       if(x.EmpID > y.EmpID){
        return 1;
       }
       else if(x.EmpID < y.EmpID){
        return -1;
       }
       else{
        return 0;
       }
    }
}


class IComparableDemo
{
    static void Main(){
        Employees e1 = new Employees{EmpID = 4,EmpName = "Sanjay",EmpManager = "Madhu",EmpPhn = 1234};
        Employees e2 = new Employees{EmpID = 2,EmpName = "Madhu",EmpManager = "Ngeswarao",EmpPhn = 5678};
        Employees e3 = new Employees{EmpID = 3,EmpName = "Kamala",EmpManager = "Gangaraju",EmpPhn = 9012};
        Employees e4 = new Employees{EmpID = 1,EmpName = "Jenny",EmpManager= "Madhu",EmpPhn = 3456};
        Employees e5 = new Employees{EmpID = 6,EmpName = "bhavs",EmpManager= "raju",EmpPhn = 7890};
        Employees e6 = new Employees{EmpID = 5,EmpName = "mallesh",EmpManager= "Gopalarao",EmpPhn = 1122};
        List<Employees> employelist = new List<Employees>{e1,e2,e3,e4,e5,e6};
        foreach(Employees ele in employelist) // before sorting we can see that the empids come in the order which we gave 
        Console.WriteLine(ele.EmpID);
        Console.WriteLine("  ");
        employelist.Sort();
        foreach(Employees ele in employelist) // after sorting we can get them in the right way and also we can change the sorting element according to or needs 
        Console.WriteLine(ele.EmpID);
        Console.WriteLine("  ");
        IComparableDemo1 ic1 = new IComparableDemo1();
        employelist.Sort(ic1);
        foreach(Employees ele in employelist) // this also works as we sorted the employee list using the students by creating another class 
        Console.WriteLine(ele.EmpID);

        
    }
}