using System;

namespace CodeList2_8
{
    class GenericCounter<T>
    {
        private static int value;
        static GenericCounter()
        {
            Console.WriteLine($"Initializing counter for {typeof(T)}");
        }
        public static void Increment()=>value++;
        public static void Display()=>Console.WriteLine($"Counter for {typeof(T)}: {value}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();
            GenericCounter<int>.Display();
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();
        }
    }
}
