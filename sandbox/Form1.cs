using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSleepTest_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
        }

        private void btnPrintTest_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked Print Test");
        }

        private BackgroundWorker bgw1 = new BackgroundWorker();

        private void btnUseBackgroundWorker_Click(object sender, EventArgs e)
        {
            // Initialize Background worker
            // create delegate for each custom handler and attach to main event handler
            bgw1.DoWork += new DoWorkEventHandler(bgw1_DoWork);
            bgw1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw1_RunWorkerCompleted);

            bgw1.RunWorkerAsync();
        }

        private void bgw1_DoWork(
            object sender,
            DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
        }

        private void bgw1_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Long task done!");
        }
    }
}
