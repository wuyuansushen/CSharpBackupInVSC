using System;
using System.Collections.Generic;
using System.Linq;

namespace queryExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words={"abandon","deprecated","generic","query","hi","Guys"};
            IEnumerable<string> query=from word in words
            where word.Length>4
            orderby word
            select word.ToUpper();
            foreach(var value in query)
            {
                Console.WriteLine(value);
            }
        }
    }
}
