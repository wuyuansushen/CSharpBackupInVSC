using System;
using System.Linq.Expressions;

namespace expressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterExpression xParameter=Expression.Parameter(typeof(int),"x");
            ParameterExpression yParameter=Expression.Parameter(typeof(int),"y");
            Expression body=Expression.Add(xParameter,yParameter);
            ParameterExpression[] parameters=new[] {xParameter,yParameter};
            Expression<Func<int,int,int>> addr=Expression.Lambda<Func<int,int,int>>(body,parameters);
            Console.WriteLine(addr);
        }
    }
}
