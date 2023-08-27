// 44. Lists: data structure that represents a list of elements that can be accessed by index.
//     * Similar to array, but can dynamically increase/decrease in size (the size of arrays is fixed)
//     * Located within the System.Collections.Generic namespace;
using System;
using System.Collections.Generic;

namespace Lists {
    class Program {
        static void Main(string[] args) {
            // Like arrays, all items in a list must be of the same type
            List<string> fastFoods = new List<string>();

            // Elements can be added using the Add() list method
            fastFoods.Add("pizza");
            fastFoods.Add("hamburger");
            fastFoods.Add("hotdog");
            fastFoods.Add("fries");

            // Count the number of elements in a list using the Count property
            Console.WriteLine(food.Count);

            // Iterate through elements in a list
            foreach (string item in fastFoods) {
                Console.WriteLine(item);
            }

            // Various list methods
            fastFoods.Sort(); // Sort elements within a list by their value
            fastFoods.Reverse(); // Reverse order of elements within a list
            fastFoods.Clear(); // Delete all elements in a list, but not the list itself
            food.Remove("fries"); // Delete the FIRST occurence of an element within a list
            food.Insert(0, "sushi"); // Insert an element into a list at a specified index (position)
            
            Console.WriteLine(food.IndexOf("pizza"));
            Console.WriteLine(food.LastIndexOf("fries"));
            Console.WriteLine(food.Contains("pizza"));

            foreach (string item in fastFoods) {
                Console.WriteLine(item);
            }

            // Generate array from list
            string[] foodArray = fastFoods.ToArray();

            Console.ReadKey();
        }
    }
}