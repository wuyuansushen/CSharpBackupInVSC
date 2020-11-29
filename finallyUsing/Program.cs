using System;
using System.Collections;
using System.Collections.Generic;

namespace finallyUsing
{
    class Program
    {
        static IEnumerable<string> Iterator()
        {
            try{
                Console.WriteLine("Before first yield");
                yield return "first";
                Console.WriteLine("Between yields");
                yield return "second";
                Console.WriteLine("After second yield");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }
        static void Main(string[] args)
        {
            foreach(string value in Iterator())
            {
                Console.WriteLine($"Received value: {value}");
            }
        }
    }
}
