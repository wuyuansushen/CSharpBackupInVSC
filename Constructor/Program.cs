using System;

namespace Constructor
{
    public class Taxi
{
    public bool IsInitialized;
    public Taxi()
    {
        IsInitialized = true;
        Console.WriteLine($"Initialized");
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi=new Taxi();
        }
    }
}
