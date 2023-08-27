// 37. Abstract classes
using System;

namespace AbstractClasses {
    class Program {
        static void Main(string[] args) {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            // Vehicle vehicle = new Vehicle(); //can't create a vehicle object

            Console.ReadKey();
        }   
    }

    // In the context of classes, the "abstract" modifier indicates that
    // a class has missing components or an incomplete implementation.
    //
    // This prevents someone from instantiating an instance of the Vehicle class
    // when it is not ready.
    abstract class Vehicle {
        public int speed = 0;

        public void Go() {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle {
        public int wheels = 4;
        int maxSpeed = 120;
    }
    class Bicycle : Vehicle {
        public int wheels = 2;
        int maxSpeed = 30;
    }
    class Boat : Vehicle {
        public int wheels = 0;
        int maxSpeed = 70;
    }
}