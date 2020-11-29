using System;
using System.Collections;
using System.Collections.Generic;

namespace yieldTutorial
{
    class Program
    {
        static IEnumerable<int> CreateSimpleIterator()
        {
            yield return 10;
            for(int i=0;i<3;i++)
            {
                yield return i;
            }
            yield return 20;
        } 
        static void Main(string[] args)
        {
            IEnumerable<int> enumerable=CreateSimpleIterator();
            using(IEnumerator<int> enumerator=enumerable.GetEnumerator())
            {
                while(enumerator.MoveNext())
                {
                    int value=enumerator.Current;
                    Console.WriteLine(value);
                }
            }
        }
    }
}
