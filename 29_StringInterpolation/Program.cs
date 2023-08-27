// 29. string interpolation
using System;

namespace StringInterpolation {
    class Program {
        static void Main(string[] args) {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders
            string firstName = "Aaron";
            string lastName = "Bee";
            int age = 27;

            Console.WriteLine($"Hello {firstName} {lastName}.");

            // You can optionally specify the alignment of a given variable within a
            // an interpolated string literal.
            //
            // A positive value +x will add x-n spaces to the left of the variable and
            // a negative value -x will add x-n spaces to the right of the variable,
            // where "n" is the number of characters the variables value is represented by.
            Console.WriteLine($"You are {age, -10} years old.");

            Console.ReadKey();
        }
    }
}