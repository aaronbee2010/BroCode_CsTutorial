// 21. Arrays: variables that can store multiple values.

/*
    One key thing to note is that arrays are of a FIXED size.
    This means they can store a fixed amount of elements.

    We can either initialise an empty array (specifying the number of elements it can store)
    or we can initalise an array with values in it. Here, the size isn't specified as the size is
    inferred from the number of elements specified within the array.

    We declare an array using the following format:
    * Empty array:  <type_of_elements_in_array>[] <name_of_array> = new <type_of_elements_in_array>[<size_of_array>]
    * Filled array: <type_of_elements_in_array>[] <name_of_array> = {<element_1>, ..., <element_n>}
*/
using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine();

            string[] cars = new string[3];
            // String[] cars = {"Focus", "Astra", "Golf"};

            cars[0] = "Focus";
            cars[1] = "Astra";
            cars[2] = "Golf";

            for (int i = 0; i < cars.Length; i++) {
                Console.WriteLine( cars[i] );
            }

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
