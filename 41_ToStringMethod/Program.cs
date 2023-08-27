// 41. Tostring method: converts an object to its string representation so that it is suitable for display.
using System;

namespace Tostring {
    class Program {
        static void Main(string[] args) {
            Car car = new Car("Ford", "Focus", 2022, "blue");

            // The ToString() method belongs to all objects
            Console.WriteLine(car.ToString()); // Input: <object_name>.ToString();, Output: ToString.Car (<namespace>.<class_name>)

            Console.ReadKey();
        }
    }
    class Car {
        string make;
        string model;
        int year;
        string colour;

        public Car(string make, string model, int year, string colour) {
            this.make = make;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }

        public override string ToString() {       
            return $"This is a {year} {make} {model} in {colour}.";
        }
    }
}