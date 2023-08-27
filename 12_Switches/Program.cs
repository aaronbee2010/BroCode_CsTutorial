// 12. Switches: an efficient alternative to multiple else if statements
using System;

namespace Switches {
    class Program {
        static void Main(string[] args) {
            string day;

            Console.Write("What day is it today? ");
            day = Console.ReadLine();
            Console.WriteLine();

            // A switch statement will traverse each case from top to bottom until a break keyword is reached:
            switch (day) {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                case "Sunday":
                    Console.WriteLine($"It's {day}!");
                    break;
                default:
                    Console.WriteLine($"{day} is not a day!");
                    break;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
