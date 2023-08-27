// 19. Goto statement
using System;

namespace GotoStatement {
    class Program {
        static void Main(string[] args) {
            retry: // This is a label. A goto statement that specifies this label will jump
                   // to where this lavel is located when the goto statement is reached

            Console.Write("Enter a number less than 10: ");
            int num = Convert.ToInt32(Console.ReadLine());  

            if (num >= 10) {
                goto retry; // Tells program to jump to location of specified label. This is an example of a goto statement.
            }

            Console.WriteLine(num + " is less than 10.");
            Console.ReadKey();
        }
    }
}
