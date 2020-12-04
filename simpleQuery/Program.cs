using System;
using System.Collections.Generic;
using System.Linq;

namespace simpleQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words={"keys","coat","laptop","bottle"};
            IEnumerable<string> query=words.Where(word=>word.Length>4).OrderBy(word=>word).Select(word=>word.ToUpper());
            foreach(string value in query)
            {
                Console.WriteLine(value);
            }
        }
    }
}
