using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            int sum = 0;
            string[] hand = Console.ReadLine()
                .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string name = "";
            List<string> cards = new List<string>();

            while (hand[0] != "JOKER")
            {
                name = hand[0];
                cards = hand.Skip(1).ToList();
                cards = cards.Distinct().ToList();
                if(players.ContainsKey(name))
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                    players[name] = players[name].Distinct().ToList();


                }
            }

        }
    }
}
