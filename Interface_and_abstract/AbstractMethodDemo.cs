
abstract class Figure{
    //  abstract class contains methods of both abstract methods and non abstract methods as well 
     const double pi = 3.14;
     public abstract int Getarea();

     public int Display(){
        return 1;
     }
}
class Rectangle:Figure
{
    int height ,width;
    public Rectangle(int height,int width){
        this.height = height;
        this.width = width;  
    }
    public override int Getarea()
    {
        return height*width;
    }
}