class SpecifiersDemo
{
    //  public method is accessable for any place either its inherited or instance any where 
    public void Method1(){
        Console.WriteLine("Public Method is called");
    }
    //  private method is only for its class and cannot be inherited or used anywhere restricted only for the class
    private void Method2(){
        Console.WriteLine("private method is called");
    }
    //  protected method is ony available if the class is inherited and cannot be accessbile if the instance is created 
    protected void Method3(){
        Console.WriteLine("protected method is called");
    }
    // internal method is available if its called in the same project and cannot be accessable if called in another project
    internal void Method4(){
        Console.WriteLine("Internal method is called");
    }
    // protected internal method is accessable if either any one of protected or  internal are satisfied    
    protected internal void Method5(){
        Console.WriteLine("protected internal method is called");
    }
}