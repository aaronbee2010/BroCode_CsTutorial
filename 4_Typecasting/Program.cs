// 4. Typecasting: Converting a value to a different data type
//                 Useful when we accept user input (string)
//                 Different data types can do different things
using System;

namespace Typecasting {
    class Program {
        static void Main(string[] args) {
            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            string f = Convert.ToString(e);

            string g = "$";
            char h = Convert.ToChar(g);

            string i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}
