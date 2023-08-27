//  5. User input
/* 
    User input can be taken as follows:
    * ReadLine: Reads next line of characters, stops reading when Enter key is pressed, and returns the inputted line as a "string"
    * Read:     Reads next character and returns its ASCII value as an "int"
    * ReadKey:  Reads next key pressed and returns it as a "ConsoleKeyInfo" struct
*/
using System;

namespace UserInput {
    class Program {
        static void Main(string[] args) {
            string userName;
            int userAscii;
            ConsoleKeyInfo userKey; 

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            Console.Write("Now please enter a character: ");
            userAscii = Console.Read();

            Console.Write("Finally, please press a key: ");
            userKey = Console.ReadKey();

            Console.Write(     $"\nYour name is {userName}, "                                                         );
            Console.Write(     $"your character (\"{Convert.ToChar(userAscii)}\") has an ASCII value of {userAscii} " );
            Console.WriteLine( $"and the key you last pressed was \"{userKey.Key}\"."                                 );
        }
    }
}