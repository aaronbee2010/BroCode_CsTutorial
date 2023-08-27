// 14. While loops: Repeat some code while a condition remains true
using System;

namespace WhileLoops {
    class Program {
        static void Main(string[] args) {
            string name = "";

            while (name == "") {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Hello {name}");

            // A do while loop is the same as a while loop, but the indented
            // code executes once before the condition is evaluated.
            //
            // After the code block executes once, it then behaves like a normal while loop.
            do {
                Console.WriteLine("This line will always be executed at least once!");
            } while ("a" == "b");

            Console.ReadKey();
        }
    }
}
