// 38. Array of objects
using System;

namespace ArrayOfObjects {
    class Program {
        static void Main(string[] args) {
            // We can create arrays whose members are of the Car class. In other words, these members are objects of the Car class.
            Car[] garage = { new Car("Focus"), new Car("Astra"), new Car("Golf") };

            foreach (Car car in garage) {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }   
    }
    class Car {
        public string model;

        public Car(string model) {
            this.model = model;
        }
    }
}
