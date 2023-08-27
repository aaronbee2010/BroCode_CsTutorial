// 45. List of objects
//
// As with primitive data types (i.e. int, char) and strings, we can also store objects within a list
using System;
using System.Collections.Generic;

namespace ListOfObjects {
    class Program  {
        static void Main(string[] args) {
            List<Player> players = new List<Player>();

            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            foreach (Player player in players) {
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }

    class Player {
        public string username;

        // Constructor
        public Player(string username) {
            this.username = username;
        }
        public override string ToString() {
            return username;
        }
    }
}