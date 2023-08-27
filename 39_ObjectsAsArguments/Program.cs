// 39. Objects as arguments
using System;

namespace ObjectsAsArguments {
    class Program {
        static void Main(string[] args) {
            Car car1 = new Car("Focus","Blue");
            Car car2 = Copy(car1);

            Console.WriteLine($"{car2.colour} {car2.model}");

            Console.ReadKey();
        }

        // Arguments taken are a Car object and string (representing the new colour to be assigned to the "colour" field)
        public static void ChangeColor(Car car, string colour) {
            car.colour = colour;
        }

        public static Car Copy(Car car) {
            return new Car(car.model, car.colour);
        }
    }
    class Car {
        public string model;
        public string colour;

        public Car(string model, string colour) {
            this.model = model;
            this.colour = colour;
        }
    }
}