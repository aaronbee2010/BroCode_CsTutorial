// 49. Generics = "not specific to a particular data type"
//                add <T> to: classes, methods, fields, etc.
//                allows for code reusability for different data types
//
// You can think of generics being like variables, but for types instead of values!
using System;

namespace Generics {
    class Program {
        static void Main(string[] args) {
            int[] intArray = { 1, 2, 3 };
            string[] stringArray = { "one", "two", "three" };

            displayElements(intArray);
            displayElements(stringArray);

            Console.ReadKey();
        }

        // Thanks to generics, we don't need to create multiple methods for each data type!
        public static void displayElements<T>(T[] array) {
            foreach (T item in array) {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
