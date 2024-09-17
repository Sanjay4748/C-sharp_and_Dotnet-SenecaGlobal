class MethodOverridingDemo
{
    // here add is virtual and overrided so that the child class overrides this method and perform child class mwthod 

    public virtual int Add(int i,int j){
        return i+j;
    }

    public int Difference(int i,int j){
        return i-j;
    }
}