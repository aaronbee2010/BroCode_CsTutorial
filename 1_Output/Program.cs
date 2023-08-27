// 1. Output

// This is a single-line comment

/*
    This is a multi-line comment
*/

// Invoke the "System" namespace, so we can use methods within it without prepending
// "System" to those methods. If you omitted the using statement below, then you would need to
// type "System.Console.WriteLine()" instead of "Console.WriteLine()".
using System;

// A namespace is a container for classes that we can use to organise classes based on similar
// functionality or a common purpose.
namespace Output {
    // A class contains methods (such as the Main() method where a C# program starts at)
    // and attributes. We'll delve into classes in more details later.
    class Program {
        // The Main() method is the entry point for a C# program. "string[] args" refers to
        // parameters that can be specified when the program is invoked from the command line.
        static void Main(string[] args) {
            Console.WriteLine("This is a line.");  // Input string has newline appended (CRLF [\r\n] for Windows/DOS, LF [\n] for Unix)
            Console.Write("This is also a line."); // Input string does NOT have newline appended
            Console.WriteLine("");                 // Invoking WriteLine with an empty string prints a newline

            // Escape characters in C# consist of a backslash "\" followed by a character.
            // For example, "\t" is a tab, "\r" is a carriage return and "\n" is a line feed.
            Console.WriteLine("This sentence is\tseparated by a tab. This sentence is\nseparated by a line feed");

            // Interpolated strings are proceeded by a dollar sign and let you insert variables within curly braces
            string myName = "Aaron";
            Console.WriteLine($"My name is {myName}");

            // You can integrate program arguments into your code by invoking a specific value of the "args" array
            // Input:  dotnet.exe run Program.cs Aaron
            // Output: "My name is Aaron"
            // Console.WriteLine($"My name is {args[1]}");

            // We can use ReadKey to keep console window open until user inputs a key.
            Console.ReadKey();
        }
    }
}