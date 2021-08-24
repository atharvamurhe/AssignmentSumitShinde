using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentSumitShinde
{
    public class ThreadingAssignment
    {
        //Write a c# program using Thread.Join() for multiple threads
        public static void ThreadJoinExample1()
        {
            Thread job1 = new Thread(TableOf2);
            Thread job2 = new Thread(TableOf3);
            Thread job3 = new Thread(TableOf4);
            //Output 1
            job1.Start();
            job1.Join();
            job2.Start();
            job2.Join();
            job3.Start();
        }

        public static void ThreadJoinExample2()
        {
            Thread job1 = new Thread(TableOf2);
            Thread job2 = new Thread(TableOf3);
            Thread job3 = new Thread(TableOf4);
            //Output 2
            job3.Start();
            job3.Join();
            job2.Start();
            job2.Join();
            job1.Start();
        }

        public static void TableOf2()
        {
            Console.WriteLine("Printing Table of 2: ");
            for (int i = 1; i <= 10; i++)
            {
                int ans = 2 * i;
                Console.WriteLine($"2 * {i} = {ans}");
                Thread.Sleep(100);
            }
            Console.WriteLine("");
        }

        public static void TableOf3()
        {
            Console.WriteLine("Printing Table of 3: ");
            for (int i = 1; i <= 10; i++)
            {
                int ans = 3 * i;
                Console.WriteLine($"3 * {i} = {ans}");
                Thread.Sleep(100);
            }
            Console.WriteLine("");
        }

        public static void TableOf4()
        {
            Console.WriteLine("Printing Table of 4: ");
            for (int i = 1; i <= 10; i++)
            {
                int ans = 4 * i;
                Console.WriteLine($"4 * {i} = {ans}");
                Thread.Sleep(100);
            }
            Console.WriteLine("");
        }

        //Write a c# program to use all thread property and print result on console
        public static void ThreadPropertiesAndMethods()
        {
            Thread Job1 = new Thread(SomeTask); //Creates a new thread.
            Job1.IsBackground = true;  //Sets The thread as background thread.
            Job1.Name = "MyBackgroundThread";  //Sets the name of thread to 'MyBackgroundThread'.
            Job1.Priority = ThreadPriority.Highest; //Sets the name of thread to Highest.
            Job1.Start();  //Starts the thread.

            Thread Job2 = new Thread(SomeTask); //Creates a new thread.
            Job2.IsBackground = false;  //Sets The thread as foreground thread.
            Job2.Name = "MyForegroundThread";  //Sets the name of thread to 'MyForegroundThread'.
            Job2.Priority = ThreadPriority.Lowest; //Sets the name of thread to Lowest.
            Job1.Join();  //Joins job1 to job2.
            Job2.Start();  //Starts the thread.
        }

        public static void SomeTask()
        {
            Console.WriteLine("Thread started running.");
            Thread.Sleep(500); //Puts the thread to sleep for 0.5 second.

            //True if thread is alive
            Console.WriteLine("Is current thread Alive: {0}", Thread.CurrentThread.IsAlive);
            Thread.Sleep(500);

            //True if current thread is a background thread else false
            Console.WriteLine("Is current thread in backgroung: {0}",Thread.CurrentThread.IsBackground);
            Thread.Sleep(500);

            //Current Thread id
            Console.WriteLine("Managed thread id: {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);

            //Current Thread Priority
            Console.WriteLine("Current Thread Priority: {0}", Thread.CurrentThread.Priority);
            Thread.Sleep(1000);
        }
    }
}
