// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/anonymous-functions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousSandbox
{
    class Program
    {
        // Declare delegates
        delegate void Del(string s);


        static void DumbMethod(string s)
        {
            Console.WriteLine("Dumb: " + s);
        }

        static void Main(string[] args)
        {
            

            // Original syntax of delegate initialization
            Del d1 = DumbMethod;
            Del d1_5 = new Del(DumbMethod);

            // Initialize delegate with inline code or "anonymous method"
            Del d2 = delegate (string s) { Console.WriteLine("anonymous: " + s); };

            // Initialize delegate with a lambda expression
            Del d3 = (x) => { Console.WriteLine("labmda: " + x); };

            Del allThaMethods = d1 + d1_5 + d2 + d3;
            allThaMethods("string parameter");




            Console.ReadKey();
        }
    }
}
