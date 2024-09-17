class Program
{
    static void Main(){
        StructureDemo str = new StructureDemo();
        str.Display();
        //  various methods for getting the values from enum
        Days days = Days.saturday;
        Days d1 = 0;
        Days d2 = (Days)1;
        Console.WriteLine(days);
        Console.WriteLine((int)days);
        Console.WriteLine(d1);
        Console.WriteLine(d2);
        //  various methods for getting the value defined enums 
        Birthdays bdays = Birthdays.sanjay;
        Birthdays b1 = Birthdays.madhu;
        Console.WriteLine(bdays);
        Console.WriteLine((int)b1);
        Console.WriteLine("..................");
        foreach (string i in Enum.GetNames(typeof(Birthdays)))
        {
             Console.WriteLine(i);
        }
        Console.WriteLine("--------------");
        foreach (int i in Enum.GetValues(typeof(Birthdays)))
        {
             Console.WriteLine(i);
        }
    }
}