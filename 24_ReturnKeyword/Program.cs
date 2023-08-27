// 24. "return" keyword - format: return <value>
// Assigns a value to the location where the corresponding method was invoked.
using System;

namespace ReturnKeyword {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("");

            double x;
            double y;
            double result;

            Console.Write("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            // Returns value from invocation of Multiply() and assigns it to "result" variable.
            result = Multiply(x, y);

            Console.WriteLine($"The result is: {result}");

            Console.ReadKey();
            Console.WriteLine("");            
        }
        // Here, we're specifying the type of the returned value before stating the method name.
        static double Multiply(double x, double y) {
            return x * y; // Value of (x * y) is returned to location where Multiply() was invoked
        }
    }
}
