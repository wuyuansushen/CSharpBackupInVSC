using System;

namespace asNullable
{
    class Program
    {
        static void PrintValueAsInt32(object o)
        {
            int? nullable=o as int?;
            Console.WriteLine(nullable.HasValue?nullable.Value.ToString():"null");
        }
        static void Main(string[] args)
        {
            PrintValueAsInt32(5);
            PrintValueAsInt32("string");
        }
    }
}
