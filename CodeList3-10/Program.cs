using System;
using System.Collections.Generic;

namespace CodeList3_10
{
    class Program
    {
        static void Main(string[] args)
        {
        static List<Action> CreateCountingActions()
        {
            List<Action> actions=new List<Action>();
            int outerCounter=0;
            for(int i=0;i<2;i++)
            {
                int innerCounter=0;
                Action action=()=>{//This is item in List<Action> actions
                    Console.WriteLine($"Outer:{outerCounter}; Inner:{innerCounter}");
                    outerCounter++;
                    innerCounter++;
                };
                actions.Add(action);
            }
            return actions;
        }
        List<Action> actions=CreateCountingActions();
        actions[0]();
        actions[0]();
        actions[1]();
        actions[1]();
        }
    }
}
