// 15. For loops: repeat a block of code a FINITE number of times
using System;

namespace ForLoops {
    class Program {
        static void Main(string[] args) {
            // Count up to 10
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }

            // Count down from 10
            for (int i = 9; i > 0; i--) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Happy New Year!");

            Console.ReadKey();
        }
    }
}
