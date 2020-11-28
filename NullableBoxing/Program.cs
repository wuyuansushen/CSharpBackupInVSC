using System;

namespace NullableBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> noValue=new Nullable<int>();
            object noValueBoxing=noValue;

            Nullable<int> hasValue=new Nullable<int>(100);
            object hasValueBoxing=hasValue;

            Console.WriteLine($"noValue boxing is null? {noValueBoxing==null}\n"+
            $"Is noValue HasValue? {noValue.HasValue}\n"
            +$"hasValue boxing is {hasValueBoxing.GetType()}");
        }
    }
}
