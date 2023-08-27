// 32. Objects
using System;

namespace Objects {
    class Program {
        static void Main(string[] args) {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)
            Console.WriteLine();

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat();
            human1.Sleep();
            human1.StateAge();

            Console.WriteLine();

            human2.Eat();
            human2.Sleep();
            human2.StateAge();

            Console.ReadKey();
            Console.WriteLine();
        }
    }
    class Human {
        // Fields: Variables that exist within a class
        public string name; 
        public int age;

        // Methods: Functions that exist within a class
        public void Eat() {
            Console.WriteLine($"{name} is eating");
        }
        public void Sleep() {
            Console.WriteLine($"{name} is sleeping");
        }

        public void StateAge() {
            Console.WriteLine($"{name} is {age} years old");
        }
    }
}