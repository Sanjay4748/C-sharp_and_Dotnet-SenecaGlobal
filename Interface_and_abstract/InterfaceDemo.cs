using System.Net.NetworkInformation;

interface InetrfaceDemo
{
    //  interface is something that only contains abstract methods 
    void Display();
    public int Addition(int i,int j);
    public int Subtraction(int i,int j);
}

interface InterfaceDemo1:InetrfaceDemo{
    public int Multiply(int i,int j);
}

class InterfaceImplement:InterfaceDemo1{
    public void Display(){
        Console.WriteLine("heyy");
    }
    public int Addition(int i,int j){
        return i+j;
    }
    public int Subtraction(int i , int j){
        return i-j;
    }
    public int Multiply(int i , int j){
        return i*j;
    }
}