// 27. Exception handling
using System;

namespace ExceptionHandling {
    class Program {
        static void Main(string[] args) {
            // exception = errors that occur during execution
            //
            //        try     = try some code that is considered "dangerous"
            //        catch   = catches and handles exceptions when they occur
            //        finally = always executes regardless if exception is caught or not
            int x;
            int y;
            double result;
            // Code block to evaluate for errors. Statements located after exception occurs
            // will not be executed
            try {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            } 
            // Catch specific exceptions
            catch (FormatException e) {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            } catch (DivideByZeroException e) {
                Console.WriteLine("You can't divide by zero! IDIOT!");
            }
            // Catch all other exceptions
            catch (Exception e) { 
                Console.WriteLine("Something went wrong!");
            }
            // Note that the exceptions within a catch statement always end with " e"
            //
            // Always executes regardless of whether or not an exception had occured
            finally {
                Console.WriteLine("Thanks for visiting!");
            }

            Console.ReadKey();
        }
    }
}