// 46. Getters and Setters: add security to fields by encapsulation
//
// They're accessors found within properties
//
// properties = combine aspects of both fields and methods (share name with a field)
// get accessor = used to return the property value
// set accessor = used to assign a new value
// value keyword = defines the value being assigned by the set (parameter)
using System;

namespace GettersAndSetters {
    class Program {
        static void Main(string[] args) {            
            Car car = new Car(400);

            Console.WriteLine(car.Speed); // Invoke getter method

            car.Speed = 1_000_000_000; // Invoke setter method

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }   
    }
    class Car {
        // The "private" keyword prevents the value of a field within an object from being returned directly.
        // The value of the field would only be able to be returned via a getter method.
        //
        // This keyword also prevents the field from being directly modified within an object.
        // The field would only be able to be modified within that object via a setter method.
        private int speed;

        // Constructor
        public Car(int speed) {
            Speed = speed; // this.<property_name> = <field_name>
        }

        // A property, which contains a getter method and a setter method.
        // This is what the user needs to interact with in order to access our field.
        //
        // We can either provide just a get method (read-only), just a set method (write-only)
        // or both (read and write) to our property.
        //
        // It's considered good practice to name properties after their corresponding field,
        // but with an uppercase first letter, i.e. field = speed, property = Speed
        public int Speed {
            get {
                // We won't add any getter restrictions in this example.
                return speed;
            }
            set {
                // The "value" keyword represents the input value assigned to the property.
                // We can then make sure that the value is suitable, and modify it beforehand
                // if it's not, before assigning it to the corresponding field.
                if (value > 500) {
                    speed = 500;
                } else {
                    speed = value;
                }
            }
        }
    }
}