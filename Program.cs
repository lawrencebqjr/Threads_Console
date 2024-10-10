using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread ct1 = new Thread(new ThreadStart(RunMe1));
            Thread ct2 = new Thread(new ThreadStart(RunMe2));
            ct1.Name = "Child 1";
            ct2.Name = "Child 2";

            ct2.Start();
            ct1.Start();

            ct2.Join(); // Make sure na taops na si child2
            ct1.Join();// Make sure na taops na si child1

            Console.WriteLine("Main Thread po Ako!!");

            Console.ReadKey();
        }

        private static void RunMe1()
        {
            for (int i = 0; i < 50; i++) 
            {
                Thread.Sleep(100);
                Console.WriteLine("ct1:" +i);
            }
        }
        private static void RunMe2()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("ct2:" + i);
            }
        }
    }
}
