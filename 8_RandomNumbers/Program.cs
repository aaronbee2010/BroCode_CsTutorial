// 8. Random numbers
using System;

namespace RandomNumbers {
    class Program {
        static void Main(string[] args) {
            Random randomObject = new Random(); // Instantiate new object from "Random" class
            /*
                Returns random integer i, where 1 <= i < 7
                int num2 = randomObject.Next(1, 7); // In other words, a random integer than can be any of the following:
                int num3 = randomObject.Next(1, 7); // 1, 2, 3, 4, 5, 6
            */
            int num1 = randomObject.Next(1, 7);
            /*
                There are similar methods that return values of different types
            */
            long num2 = randomObject.NextInt64(1, 7);
            float num3 = randomObject.NextSingle(); // 0.0 <= x < 1.0
            double num4 = randomObject.NextDouble(); // 0.0 <= x < 1.0

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            Console.ReadKey();
        }
    }
}
