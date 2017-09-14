using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int a = int.MaxValue;
        a *= 2; 
        
        try
        {
            Console.WriteLine(a);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        
        
        
    }
}


