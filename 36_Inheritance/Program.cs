// 36. Inheritance: One or more child classes recieving fields, methods, etc. from a parent class
using System;

namespace Inheritance {
    class Program {
        static void Main(string[] args) {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine();

            // The Car class inherits the "speed" field from its parent class, Vehicle
            Console.WriteLine($"Speed of car: {car.speed}");
            Console.WriteLine($"Number of wheels: {car.wheels}");
            car.Go();

            Console.WriteLine();

            Console.WriteLine($"Speed of bicycle: {bicycle.speed}");
            Console.WriteLine($"Number of wheels: {bicycle.wheels}");
            bicycle.Go();

            Console.WriteLine();

            Console.WriteLine($"Speed of boat: {boat.speed}");
            Console.WriteLine($"Number of wheels: {boat.wheels}");
            boat.Go();

            Console.ReadKey();
            Console.WriteLine();
        }   
    }
    class Vehicle {
        public int speed = 30;

        public void Go() {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    // Inheritance syntax: class <name_of_child_class> : <name_of_parent_class>
    class Car : Vehicle {
        public int wheels = 4;
    }
    class Bicycle : Vehicle {
        public int wheels = 2;
    }
    class Boat : Vehicle {
        public int wheels = 0;
    }
}