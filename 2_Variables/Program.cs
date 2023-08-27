// 2. Variables
using System;

namespace Variables {
    class Program {
        static void Main(string[] args) {
            // We can declare a variable as follows: <data_type> <variable_name>;
            int x;

            // We can initialise a declared variable as follows: <variable_name> = <variable_value>;
            x = 123;

            // We can simultaneously declade and initalise a variable as follows: <data_type> <variable_name> = <variable_value>;
            int y = 321;

            // We can perform mathematical operations on variables.
            int z = x + y;

            // We can declare multiple variables within the same statement as long as they're of the same type
            int a = 1, b = 2, c = 3;

            // Here are some examples of data types in C#
            //
            // -- Integers
            // * byte: 8-bit unsigned integer
            // * sbyte: 8-bit signed integer
            // * short: 16-bit signed integer
            // * ushort: 16-bit unsigned integer
            // * int: 32-bit signed integer
            // * uint: 32-bit unsigned integer
            // * long: 64-bit signed integer
            // * ulong: 64-bit unsigned integer
            //
            // -- Floating-point numbers
            // * float: 32-bit floating-point number (suffixed with F)
            // * double: 64-bit floating-point number (suffixed with D)
            // * decimal: 128-bit decimal floating-point (suffixed with M)
            // Note that range of decimals is lower than floats or doubles (despite taking more space in memory)
            // however the precision of decimals is much higher than both floats and doubles
            //
            // -- Character types
            // * char: single UTF-16 character (16-bit)
            // * string: immutable sequence of char objects
            //
            // -- Boolean - can take one of two values
            // * true
            // * false (default value)

            int age = 27;
            decimal height = 178.35M;
            char symbol = '@';
            string name = "aaronbee2010";
            bool alive = true;
            string handle = symbol + name;

            // Normal strings
            Console.WriteLine("\nHello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + " cm");
            // Interpolated strings
            Console.WriteLine($"Are you alive? {alive}");
            Console.WriteLine($"Your symbol is: {symbol}");
            Console.WriteLine($"Your handle is: {handle}");

            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
