using System;
using System.Collections;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
    static IEnumerable<int> Fibonacci()
    {
        int current=0;
        int next=1;
        while(true)
        {
            yield return current;
            int oldCurrent=current;
            current=next;
            next=next +oldCurrent;
        }
    }
        static void Main(string[] args)
        {
            foreach(int value in Fibonacci())
            {
                Console.WriteLine(value);
                if(value>1000)
                {
                    break;
                }
            }
        }
    }
}
