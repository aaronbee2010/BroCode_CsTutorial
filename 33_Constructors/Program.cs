// 33. Constructors: a special method in a class used to assign attribute values to an object as it's initialised. 
//                   Note that the constructor has the same name as the class it's located in.
using System;

namespace Constructors {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Car("Ford", "Focus", "Blue", 2021);
            Car car2 = new Car("Vauxhall", "Astra", "Red", 2022);

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    class Car {
        string make;
        string model;
        string colour;
        int year;

        // Constructor method. Note that constructor parameters don't have to have
        // the same name as their corresponding fields, but this is usually the case
        public Car(string make, string model, string colour, int year) {
            // "this" is a placeholder that refers to the name of the current object (instance of the class)
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.year = year;
        }

        public void Drive() {
            Console.WriteLine($"You drive a {year} {make} {model} in {colour}.");
        }
    }
}