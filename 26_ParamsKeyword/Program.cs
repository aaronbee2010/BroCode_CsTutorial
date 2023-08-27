// 26. "params" keyword = A method parameter that takes a variable number of arguments.
//                        The parameter type must be a single - dimensional array
using System;

namespace ParamsKeyword {
    class Program {
        // The "params" keyword lets us specify a variable number of arguments
        // (think of *args in Python). The arguments are then stored in an array
        // defined immediately after the "params" keyword and can be accessed by
        // code within the method.
        static double CheckOut(params double[] prices) {
            double total = 0;

            foreach (double price in prices) {
                total += price;
            }
            return total;
        }
        static void Main(string[] args) {
            double total;
            
            total = CheckOut(15, 1.00, 10.25);
            Console.WriteLine(total);

            total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}