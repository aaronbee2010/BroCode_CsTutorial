// 31. Classes
using System;

namespace Classes {
    class Program {
        static void Main(string[] args) {
            // A "class" is a bundle of related code.
            // Classes can be used as a blueprint to create objects (OOP)
            Console.WriteLine();
            
            // We can invoke methods from another class (provided they're public) by invoking the class name
            // and the method name with a dot in between, as follows:
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
            Console.WriteLine();
        }
    }
    static class Messages {
        public static void Hello() {
            Console.WriteLine("Hello!");
        }
        public static void Waiting() {
            Console.WriteLine("Waiting...");
        }
        public static void Bye() {
            Console.WriteLine("Goodbye!");
        }
    }
}