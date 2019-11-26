using System;
using System.Collections.Generic;

namespace _5.Hands_of_Cards_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "JOKER")
                {
                    break;

                }
                string[] tokens = line.Split(':');

                string[] playerName = tokens[0];
                string[] cards = tokens[1].Trim().Split(", ");

                if (players.ContainsKey(playerName) == false)
                {
                    players.Add(playerName, new List<string>());
                }
                players[playerName].AddRange(cards);


            }
        }
    }
}
