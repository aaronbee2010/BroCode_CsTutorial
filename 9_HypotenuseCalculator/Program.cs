// 9. Hypotenuse calculator
using System;

namespace HypotenuseCalculator {
    class Program {
        static void Main(string[] args) {
            double a;
            double a2;
            double b;
            double b2;
            double h;

            Console.WriteLine("*** Hypotenuse Calculator ***");

            Console.Write("Please enter a value for a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Great. Now please enter a value for b: ");
            b = Convert.ToDouble(Console.ReadLine());

            a2 = a * a;
            b2 = b * b;

            h = Math.Sqrt(a2 + b2);

            Console.WriteLine($"The length of the hypotenuse is: {h}");

            Console.ReadKey();
        }
    }
}