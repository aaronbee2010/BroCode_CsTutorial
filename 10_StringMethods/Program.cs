// 10. string methods
using System;

namespace StringMethods {
    class Program {
        static void Main(string[] args) {
            string fullName = "Aaron Bee";
            string phoneNumber = "0789-123-4567";

            // We can convert all alphabet characters into either upper or lower case:
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());

            // We can replace all instances of a substring with a different value (or no value, as seen below)
            phoneNumber = phoneNumber.Replace("-","");
            Console.WriteLine(phoneNumber);

            // We can insert a substring into a string at a specified position within the string, and assign the new string
            // to a new variable. We can't assign the new string to the old variable as strings are immutable.
            // Format: <string_literal_or_variable_name>.Insert(<index_to_insert_substring>, <substring>);

            string userName = "Aaron Bee".Insert(0, "Mr. "); // Index 0 corresponds to the beginning of the string
            Console.WriteLine(userName);

            // We can return the number of characters in a string (in other words, the strings length) as follows:
            Console.WriteLine(fullName.Length);

            // We can return specific substrings of input strings as follows:
            // Format: <string_literal_or_variable_name>.Substring(<0-based index of start character>, <1-based index of end character>);

            Console.WriteLine(fullName.Substring(0, 3) ); // "Aar"
            Console.WriteLine(fullName.Substring(4, 4) );  // "n Be"

            Console.ReadKey();
        }
    }
}