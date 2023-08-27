// 34. "static" keyword: modifier to declare a static member, which belongs to
//                       the class itself rather than to any specific object
using System;

namespace StaticKeyword {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Car("Focus"); // Each invocation of the Car() constructor
            Car car2 = new Car("Astra"); // increments the "numberOfCars" field by 1
            Car car3 = new Car("Golf");

            Console.WriteLine(Car.numberOfCars);
            Car.StartRace();

            Console.ReadKey();
        }
    }
    class Car {
        string model;
        public static int numberOfCars = 0; // This attribute belongs to the class, and it's value
                                            // is INDEPENDENT of the objects derived from this class

        public Car(string model) {
            this.model = model;
            numberOfCars++; // Incremented each time an object is declared using this constructor.
        }

        public static void StartRace() {
            Console.WriteLine("The race has begun!");
        }
    }
}