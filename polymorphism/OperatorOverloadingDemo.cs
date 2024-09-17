class OperatorOverloadingDemo
{
    int i, j;
    bool check;

    public OperatorOverloadingDemo(int i, int j)
    {
        this.i = i;
        this.j = j;
    }

    // Overloading the + operator to add two OperatorOverloadingDemo objects
    public static OperatorOverloadingDemo operator +(OperatorOverloadingDemo ob1, OperatorOverloadingDemo ob2)
    {
        return new OperatorOverloadingDemo(ob1.i + ob2.i, ob1.j + ob2.j);
    }
    //  we can also overload the == and != and - and * and so many operators 

    // Displaying the values of i and j
    public void Display()
    {
        Console.WriteLine($"i = {i}, j = {j}");
    }
}

