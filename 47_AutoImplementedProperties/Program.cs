// 47. Auto-Implemented properties: shortcut when no additional logic is required in the property.
//
//     We do not have to define a field for a property, and
//     we only have to write get and/or set inside the property.
using System;

namespace AutoImplementedProperties {
    class Program {
        static void Main(string[] args) {                    
            Car car = new Car("Focus");

            Console.WriteLine(car.Model); // Focus

            Console.ReadKey();
        }
    }

    class Car {
        // private string model;
        public string Model {get; set;}
        // public string Model {
        //     get { return model; }
        //     set { model = value; }
        // }

        // Constructor
        public Car(string model) {
            this.Model = model; // this.<property_name> = <field_name>
        }
    }
}
