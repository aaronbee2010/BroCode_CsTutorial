// 42. Polymorphism: Greek word that means to "have many forms"
//                   Objects can be identified by more than one type
//                   Ex. A Dog is also: Canine, Animal, Organism
using System;

namespace Polymorphism {
    class Program {
        static void Main(string[] args) {

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // If you want to fill an array with objects of different classes,
            // the array must be of the PARENT class of the objects in the array.
            Vehicle[] vehicles = { car, bicycle, boat };

            // Invoking Go() will net different results depending on which class it's being invoked from.
            // In other words, the Go() method has many forms.
            foreach (Vehicle vehicle in vehicles) {
                vehicle.Go();
            }
           
            Console.ReadKey();
        }
    }
    class Vehicle {
        public virtual void Go() {
            Console.WriteLine("The vehicle is moving!");
        }
    }
    class Car: Vehicle {
        public override void Go() {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle : Vehicle {
        public override void Go() {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat : Vehicle {
        public override void Go() {
            Console.WriteLine("The boat is moving!");
        }
    }
}