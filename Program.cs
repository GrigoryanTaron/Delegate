using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    delegate void Operation(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list = new List<string>();
            list.Add("jdy");
            list.Add("sth");
            list.Add("sytterthht");
            list.Add("uujmjgghm");
            list.Add("dyjhdhdas");
            list.Add("djhhgj");
           var result= list._Last(x=>x.Contains("j"));
            Operation op;
            op = Print;
            op(result);
           
        }
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
