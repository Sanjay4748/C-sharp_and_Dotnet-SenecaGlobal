using System.Text;
using System.Diagnostics;
//  string builders are more efficient in c# as they are mutable and there are various operations and on concatinating in string builder 
//  we dont take multiple locations we have only one memory place allocated to it 
class StringBuildersDemo
{
    static void Main(){
        Stopwatch sw = new Stopwatch(); // stopwatch a class from diagnostics lib which is useful in calculating the time between 
        sw.Start();

        StringBuilder sb = new StringBuilder("sanjay"); // this is how stringbuilder creates 
        Console.WriteLine(sb);
        sb.Append("thatipaka");
        Console.WriteLine(sb);
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds); // gives the number of time taken between start and stop 
    }
}