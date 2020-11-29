using System;
using System.Collections;
using alias=System.Collections.Generic;

namespace finallyUsing
{
    class Program
    {
        static global::System.Collections.Generic.IEnumerable<string> Iterator()
        {
            try{
                global::System.Console.WriteLine("Before first yield");
                yield return "first";
                global::System.Console.WriteLine("Between yields");
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
            global::System.Console.WriteLine("End!");
        }
    }
}
