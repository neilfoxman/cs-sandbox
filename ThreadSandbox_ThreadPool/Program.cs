using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSandbox_ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an action - delegate that returns void
            Action<object> action = (object obj) =>
            {

            };

            //// Testing alternative declaration - works
            //Action<object> action1 = delegate (object obj)
            //{
            //    Console.WriteLine("");
            //};
        }
    }
}
