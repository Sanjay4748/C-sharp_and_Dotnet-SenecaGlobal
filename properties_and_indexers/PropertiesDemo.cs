//  properties means getters and setters which will be useful in changing the private variables and accessing and changing them

using System.Security.Cryptography.X509Certificates;

public enum EvenNumbers
{
    Two = 2,
    Four = 4,
    Six = 6,
    Eight = 8,
    Ten = 10
}

class PropertiesDemo
{
    string _Name;   
    int _PrimeNum;
    int _Number; 

    EvenNumbers _Evennum;

    int _Oddnum;
    public string Name{
        get{
            return _Name; // this is the getter for the variable
        }
        set{
            _Name = value; // this is the setter for the variable
        }
    }
    //  we can also give either only getter and either only setter as well 
    public int PrimeNum{
        get{
            return _PrimeNum;
        }
    }
    //  we can give conditions as well 
    public int Number
    {
        get{
            if(Number > 10){
                return _Number; // we can also give the conditions in the getter and setter 
            }
            return 0;
        }
        set {
            if (value > 10){
                _Number = value;
            }
        }

    }

    // we can use enum for the easy access of the values 
    public EvenNumbers Evennumber{
        get{
            return _Evennum;
        }
        set{
            _Evennum = value;
        }
    }

    //  we can also give access specifiers for the getters and setters 
    public int Oddnum{
        get{
            return _Oddnum;
        }
        protected set{
            _Oddnum = value;
        }
    }
    public void Display(){
        Console.WriteLine("the name is "+_Name);
    }
}