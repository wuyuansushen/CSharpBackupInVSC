using System;

namespace hashcodeTutorial
{
    public struct Number
    {
        public int n;
        public Number(int inputNumber)
        {
            n=inputNumber;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number n1=new Number(100);
            Number n2=n1;
            Console.WriteLine($"n1 hashcode is {n1.GetHashCode()}\nn2 hashcode is {n2.GetHashCode()}");
        }
    }
}
