// 3. Constants
using System;

namespace Constants {
    class Program {
        static void Main(string[] args) {
            // constants = immutable values which are known at compile time
            //             and do not change for the life of the program
            // Format: const <data_type> <variable_name> = <variable_value>;

            const double pi = 3.14; // Constants must be initialised on declaration

            //pi = 420; //can't change this constant

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}
