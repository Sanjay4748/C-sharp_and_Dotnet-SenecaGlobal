class Program
{
    static void Main(){
        PropertiesDemo pd = new PropertiesDemo();
        // this is how we define or change any virables 
        pd.Name = "sanjay";
        Console.WriteLine(pd.Name);
        pd.Evennumber = EvenNumbers.Two;
        Console.WriteLine((int)pd.Evennumber);

        // pd.Oddnum = 1; shows a error because we gave access specifier protected there 
        Console.WriteLine(pd.Oddnum);
        IndexersDemo idemo = new IndexersDemo(1,"sanjay","madhu","kamala",12344);
        // indexing the elements like arrays is used in indexing 
        Console.WriteLine(idemo[0]);
        Console.WriteLine(idemo[1]);

    }
}