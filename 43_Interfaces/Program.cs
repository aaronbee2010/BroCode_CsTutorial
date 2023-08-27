// 43. Interfaces: Define a "contract" that all the classes inheriting from should follow
//                 * An interface declares "what a class should have"
//                 * An inheriting class defines "how it should do it"
//                 * benefits = security + multiple inheritance + "plug-and-play"
using System;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
        interface IPrey {
            void Flee(); // Any class which inherits from IPrey MUST have a Flee() method with a "void" return type
        }
        interface IPredator {
            void Hunt(); // Any class which inherits from IPrey MUST have a Hunt() method with a "void" return type
        }
        class Rabbit : IPrey {
            // Commenting out the method below gives a CS0535 error as its inheritance from IPrey mandates a Flee() method
            // Setting the return type to something else gives a CS0738 error as IPrey mandates a void return type
            public void Flee() {
                Console.WriteLine("The rabbit runs away!");
            }
        }
        class Hawk : IPredator {
            public void Hunt() {
                Console.WriteLine("The hawk is searching for food!");
            }
        }
        class Fish : IPrey, IPredator {
            // As Fish inherits from both interfaces, both Flee() and Hunt()
            // methods with the void return type must be present within this class
            public void Flee() {
                Console.WriteLine("The fish swims away!");
            }
            public void Hunt() {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        } 
    }  
}