https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSanbox
{
    class Program
    {
        // Declare delegate to be used
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            // Instantiate delegate
            Del handler = DelegateMethod;

            // Call delegate
            handler("yo");

            // Pass delegate as a parameter
            MethodWithCallback(1, 2, handler);

            // Create delegates to non static methods
            NonstaticClass nsc = new NonstaticClass();
            Del d1 = nsc.NonstaticMethod1;
            Del d2 = nsc.NonstaticMethod2;
            Del d3 = DelegateMethod;

            // Encapsulate several delegates in one delegate to invoke at same time
            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;
            allMethodsDelegate("I have been passed");
            allMethodsDelegate -= d1;
            allMethodsDelegate("Second time around.");
            Del simpleDelegate = allMethodsDelegate - d1 - d2;
            simpleDelegate("Back to square one with me.");

            // Get delegate properties
            int invocationCount = allMethodsDelegate.GetInvocationList().GetLength(0);
            handler(invocationCount.ToString());



            Console.ReadKey();
        }

        // Create method for delegate
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("Sum: " + (param1 + param2).ToString());
        }
    }

    public class NonstaticClass
    {
        public void NonstaticMethod1(string message)
        {
            Console.WriteLine("NSM1 called");
        }

        public void NonstaticMethod2(string message)
        {
            Console.WriteLine("NSM2 called");
        }
    }
}
