using System;
using System.Linq;
using System.Collections.Generic;

namespace nonExtendedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words={"keys","coat","laptop","bottle"};
            IEnumerable<string> query=Enumerable.Select(Enumerable.OrderBy(Enumerable.Where(words,word=>word.Length>4),word=>word),word=>word.ToUpper());
            foreach(var value in query)
            {
                Console.WriteLine(value);
            }
        }
    }
}
