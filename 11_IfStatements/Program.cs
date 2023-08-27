// 11. If statements: a basic form of decision making
using System;

namespace IfStatements {
    class Program {
        static void Main(string[] args) {
            string userName;

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            if (userName == "") {
                Console.WriteLine("You did not enter your name!"); // Executes only if condition 1 is true
            } else if (userName == "Aaron") {
                Console.WriteLine("Welcome back master!"); // Executes only if condition 1 is false and condition 2 is true
            } else {
                Console.WriteLine($"Greetings {userName}!"); // Executes only if all conditions above are false
            }

            Console.ReadKey();
        }
    }
}
