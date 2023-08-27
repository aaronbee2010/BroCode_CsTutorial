// 20. Arithmetic Calculator
using System;

namespace ArithmeticCalculator {
    class Program {
        static void Main(string[] args) {
            string response = "y";

            Console.WriteLine(" ----------------------- ");
            Console.WriteLine("| Arithmetic Calculator |");
            Console.WriteLine(" ----------------------- ");

            while (response == "y") {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                retry:

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine()) {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option. Please try again.");
                        goto retry;
                }

                Console.Write("Would you like to continue? [y/n] ");
                response = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
