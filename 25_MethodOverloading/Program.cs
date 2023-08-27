/*
    25. Method Overloading

    You can have multiple methods with the same name, provided all of them have unique signatures
    A methods signature consists of its name and parameters (the ordered combination of types of each parameter)
*/
using System;

namespace MethodOverloading {
    class MyMethods {
        static void Main(string[] args) {
            Console.WriteLine("");

            double total;
            
            total = Multiply(6, 7);
            Console.WriteLine(total);

            total = Multiply(2, 3, 4);
            Console.WriteLine(total);

            Console.ReadKey();
            Console.WriteLine("");
        }
        static double Multiply(double a, double b) {      
            return a * b;
        }

        static double Multiply(double a, double b, double c) {
            return a * b * c;
        }
    }
}
