//  indexers are we like virtual arrays we can access and modify them using it 

class IndexersDemo
{
    int id;
    string name;
    string fathername;
    string mothername;
    int ph;

    public IndexersDemo(int id,string name,string fathername,string mothername,int ph){
        this.id = id;
        this.name = name;
        this.fathername = fathername;
        this.mothername = mothername;
        this.ph = ph;
    }
    //  this method is useful for the indexing the values for getting and also we can write the same for set as well 
    public object this[int index]{
        get{
            if(index == 0){
                return id;
            }
            else if (index == 1){
                return name;
            }
            else if (index ==2){
                return fathername;
            }
            return null;
        }
    }
    // we can also use this if we want to know by name in here 
    public object this[string index]{
        get{
            if(index == "id"){
                return id;
            }
            else if (index == "name"){
                return name;
            }
            else if (index =="sfathername"){
                return fathername;
            }
            return null;
        }
    }

}