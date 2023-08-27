// 35. Overloaded constuctors: technique to create multiple constructors,
//                             with a different set of parameters.
//                             name + parameters = signature
using System;

namespace OverloadedConstructors {
    class Program {
        static void Main(string[] args) {
            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella");

            Console.ReadKey();
        }   
    }
    class Pizza {
        string bread;
        string sauce;
        string cheese;
        string topping;

        // It's possible to overload methods, and constructors are special
        // methods, so it's not surprising that we can overload methods.
        public Pizza(string bread) {
            this.bread = bread;
        }
        public Pizza(string bread, string sauce) {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(string bread, string sauce, string cheese) {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public Pizza(string bread, string sauce, string cheese, string topping) {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}