// 13. Logical operators: Can be used to check if more than 1 condition is true/false
using System;

namespace LogicalOperators {
    class Program {
        static void Main(string[] args) {
            int temp;

            Console.Write("What's the temperature outside (*C)? ");

            temp = Convert.ToInt32(Console.ReadLine());

            // &&: AND, ||: OR
            if (temp >= 10 && temp <= 25) {
                Console.WriteLine("It's nice outside!");
            } else if (temp <= -10 || temp >= 50) {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            } else {
                Console.WriteLine("It's not particularly nice outside.");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
