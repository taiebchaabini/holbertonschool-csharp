using System;
class Test
{
    static public void Main(String[] args)
    {
        double[] m = { 1, 2 };
        var res = VectorMath.CrossProduct(m, m);
        
        foreach(var elem in res){
            Console.WriteLine(elem);
        }
    }
}