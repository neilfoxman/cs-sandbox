

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSandbox
{


    class Program
    {

        static void Main(string[] args)
        {
            // Instantiate calculation class as examples are non static
            // examples executed with constructor
            CalcsClass c = new CalcsClass();
        }
    }

    class CalcsClass
    { 
        public CalcsClass()
        {
            //// Example 1
            //TestArea();

            // Example 2
            TestArea2();

            Console.ReadKey();
        }

        /*
         * Ex 1 Using a thread
         * //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/threading/parameters-and-return-values-for-multithreaded-procedures
         * */

        // Create class that calculates area
        class AreaClass
        {
            public double Base;
            public double Height;
            public double Area;

            public void CalcArea()
            {
                // calculate triangle area
                Area = 0.5 * Base * Height;
                MessageBox.Show("The area is " + Area.ToString());
            }
        }

        // Create thread and do calculation on that thread
        // Area is not checked on main thread as calculation is not guaranteed to be done
        protected void TestArea()
        {
            AreaClass AreaObject = new AreaClass();
            System.Threading.Thread Thread = new System.Threading.Thread(AreaObject.CalcArea);
            AreaObject.Base = 30;
            AreaObject.Height = 40;
            Thread.Start();
        }



        /*
         * Ex 2 - Using a BackgroundWorker
         * */
        class AreaClass2
        {
            public double Base;
            public double Height;
            public double CalcArea()
            {
                return (0.5 * Base * Height);
            }
        }

        private System.ComponentModel.BackgroundWorker BackgroundWorker1 =
            new System.ComponentModel.BackgroundWorker();

        private void TestArea2()
        {
            InitializeBackgroundWorker();

            // Create Areaobject and initialize parameters
            AreaClass2 AreaObject2 = new AreaClass2();
            AreaObject2.Base = 30;
            AreaObject2.Height = 40;

            // Start the Asynchronous Operation
            // pass AreaObject to Backgroundworker as argument
            BackgroundWorker1.RunWorkerAsync(AreaObject2);
        }

        private void InitializeBackgroundWorker()
        {
            // Create delegates to our custom event handlers and attach those delegates
            // to the BackgroundWorker Object
            BackgroundWorker1.DoWork +=
                new System.ComponentModel.DoWorkEventHandler(BackgroundWorker1_DoWork);
            BackgroundWorker1.RunWorkerCompleted +=
                new System.ComponentModel.RunWorkerCompletedEventHandler(BackgroundWorker1_RunWorkerCompleted);
        }

        private void BackgroundWorker1_DoWork(
            object sender,
            System.ComponentModel.DoWorkEventArgs e)
        {
            // Load the object that was passed as an argument
            AreaClass2 AreaObject2Internal = (AreaClass2)e.Argument;

            // Run the calculation and store the result through the result property
            e.Result = AreaObject2Internal.CalcArea();
        }

        private void BackgroundWorker1_RunWorkerCompleted(
            object sender,
            System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // The work has been completed
            //  Access the result through the result property
            double Area = (double)e.Result;
            MessageBox.Show("The area is " + Area.ToString());
        }







    }

    
}
