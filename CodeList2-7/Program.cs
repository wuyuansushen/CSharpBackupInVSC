using System;
using System.Collections.Generic;

namespace CodeList2_7
{
    class Program
    {
        static void PrintType<T>()
        {
            Console.WriteLine($"typeof(T) = {typeof(T)}");
            Console.WriteLine($"typeof(List<T>) = {typeof(List<T>)}");
        }
        static void Main(string[] args)
        {
            PrintType<string>();
            PrintType<int>();
            Console.WriteLine($"typeof(List<>) = {typeof(List<>)}");
            Console.WriteLine($"typeof(Tuple<>) = {typeof(Tuple<>)}");
            Console.WriteLine($"typeof(Tuple<,>) = {typeof(Tuple<,>)}");
            Console.WriteLine($"typeof(Tuple<,,>) = {typeof(Tuple<,,>)}");
        }
    }
}
