// 23. Methods: Functions that belong to the class they're defined in.
//
// Methods contain a block of code that runs whenever the method is invoked.
// The key benefit is that it lets us reuse code w/o writing it multiple times.
// It's considered good practice to capitalise method names.
using System;

namespace Methods {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("");

            string name = "Aaron";
            int age = 27;

            SingHappyBirthday(name, age);

            Console.ReadKey();
        }
        // Example of a method:
        // Multiple parameters can be taken, each with its own type
        static void SingHappyBirthday(string inputName, int inputAge) {
            Console.WriteLine( "Happy birthday to you!");
            Console.WriteLine( "Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {inputName}!");
            Console.WriteLine($"You are {inputAge} years old!");
            Console.WriteLine( "Happy birthday to you!");
            Console.WriteLine( "");
        }
    }
}
