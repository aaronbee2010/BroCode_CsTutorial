// 40. Method overloading: provides a new version of a method inherited from a parent class.
//                         The inherited method must be: abstract, virtual, or already overriden.
//                         Used with ToString(), polymorphism.
using System;

namespace MethodOverloading {
    class Program {
        static void Main(string[] args) {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
            Console.WriteLine();
        }
    }
    class Animal {
        // We use the "virtual" keyword to make a method overridable by another method in a child class. We can also do this
        // with "abstract", but the parent class would need to be abstract as well.
        public virtual void Speak() {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal {
        // Note that unlike method overloading, method overriding occurs when two different methods have the SAME signature.
        // Here, we use the "override" keyword to prioritise the method in the child class over the parent class.
        public override void Speak() {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal {
        // Since no Speak() method exists here, invoking this method from a Cat object
        // will use the Speak() method located within the parent class, Animal.
    }
}