// 50. Multithreading
//
// thread = an execution path of a program
//
//          We can use multiple threads to perform,
//          different tasks of our program at the same time.
//
//          Current thread running is "main" thread
//
//          using System.Threading;
using System;
using System.Threading;

namespace Multithreading {
    class Program {
        static void Main(string[] args) {
            Thread mainThread = Thread.CurrentThread; // Instantiate Thread object
            mainThread.Name = "Main Thread";
            // Console.WriteLine(mainThread.Name);

            // Thread thread1 = new Thread(CountDown);
            // Thread thread1 = new Thread(CountUp);
            //
            // The above only works if the CountDown and CountUp methods don't take any input parameters,
            // otherwise we need to specify a lambda function within the Thread() parentheses
            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            // These threads (and the methods contained therein) start and run simultaneously,
            // instead of the first one starting and the second one starting when the first one ends.
            thread1.Start();
            thread2.Start();

            Console.WriteLine($"{mainThread.Name} is complete!");

            Console.ReadKey();
        }  
        public static void CountDown(string name) {
            for (int i = 10; i >= 0; i--) {
                Console.WriteLine($"Timer #1: {i} seconds");
                Thread.Sleep(1000); // Parameter = time to sleep for (milliseconds)
            }
        }
        public static void CountUp(string name) {
            for (int i = 0; i <= 10; i++) {
                Console.WriteLine($"Timer #2: {i} seconds");
                Thread.Sleep(1000); // Parameter = time to sleep for (milliseconds)
            }
        }
    }
}
