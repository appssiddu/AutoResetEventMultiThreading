using System;
using System.Threading;
class Program
{
    static AutoResetEvent _auto1 = new AutoResetEvent(false);
    static AutoResetEvent _auto2 = new AutoResetEvent(false);
    
    static void Main()
    {
        PrintUpperLetter();
        PrintLowerLetter();
    }
    
    public static void PrintUpperLetter(){
        
        foreach(char c in "ABCED")
        {
            Console.WriteLine(c);
            _auto2.Set();
            _auto1.WaitOne();
        }
        
    }
    
    public static void PrintLowerLetter(){
        foreach(char c in "ABCED")
        {
             _auto2.WaitOne();
            Console.WriteLine(c.ToString().ToLower());
            _auto1.Set();
        }
         _auto1.Set();
    }
}
