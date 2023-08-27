// 22. Foreach loop: a simpler way to iterate over an array, but it's less flexible.
using System;

namespace ForeachLoop {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("");

            string[] cars = {"Focus", "Astra", "Golf"};

            // We declare a temporary variable "car", whose value will cycle across all of the elements in the array from first to last
            foreach (string car in cars) {
                Console.WriteLine(car);
            }

            // Unlike a standard for loop, a foreach loop always iterates over all elements from first to last. We cannot iterate over
            // every nth element where n > 1, and we cannot iterate in reverse (in the direction from the last to the first element)

            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
