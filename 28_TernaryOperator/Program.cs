// 28. Ternary operator
using System;

class Program {
    static void Main(string[] args) {
        // conditional operator = used in conditional assignment if a condition is true/false
        // <condition to evaluate> ? <value to return if true> : <value to return if false>
        Console.WriteLine();
        
        double temperature = 20;
        string message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

        Console.WriteLine(message);

        Console.ReadKey();
        Console.WriteLine();
    }
}
