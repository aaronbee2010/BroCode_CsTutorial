// 7. Math class
using System;

namespace MathClass {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Math.Pow(7, 3)); // 343
            Console.WriteLine(Math.Sqrt(169)); // 13

            Console.WriteLine(Math.Abs(-35)); // 35

            Console.WriteLine(Math.Round(12.4F)); // 12
            Console.WriteLine(Math.Ceiling(23.1F)); // 24
            Console.WriteLine(Math.Floor(52.8F)); // 52

            Console.WriteLine(Math.Max(2, 4)); // 4
            Console.WriteLine(Math.Min(3, 5)); // 3

            Console.ReadKey();
        }
    }
}
