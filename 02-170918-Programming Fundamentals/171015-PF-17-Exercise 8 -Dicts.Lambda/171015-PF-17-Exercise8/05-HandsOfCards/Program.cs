using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCards = Console.ReadLine();

            Dictionary<string, string[]> allPlayersAndCards = new Dictionary<string, string[]>();

            while (inputCards != "JOKER")
            {
                List<string> playerAndCards = inputCards.Split(':').ToList();

                string[] cards = playerAndCards[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();

                if (allPlayersAndCards.ContainsKey(playerAndCards[0]))
                {
                    allPlayersAndCards[playerAndCards[0]] = allPlayersAndCards[playerAndCards[0]].Concat(cards).ToArray();
                }
                else
                {
                    allPlayersAndCards[playerAndCards[0]] = cards;
                }

                inputCards = Console.ReadLine();
            }

            Dictionary<char, int> firstCard = new Dictionary<char, int>();
            Dictionary<char, int> secondCard = new Dictionary<char, int>();

            firstCard['2'] = 2;
            firstCard['3'] = 3;
            firstCard['4'] = 4;
            firstCard['5'] = 5;
            firstCard['6'] = 6;
            firstCard['7'] = 7;
            firstCard['8'] = 8;
            firstCard['9'] = 9;
            firstCard['1'] = 10;
            firstCard['J'] = 11;
            firstCard['Q'] = 12;
            firstCard['K'] = 13;
            firstCard['A'] = 14;

            secondCard['C'] = 1;
            secondCard['D'] = 2;
            secondCard['H'] = 3;
            secondCard['S'] = 4;

            Dictionary<string, int> cardsOfPlayers = new Dictionary<string, int>();

            foreach (KeyValuePair<string, string[]> player in allPlayersAndCards)
            {
                List<string> realCards = player.Value.Distinct().ToList();

                int[] sumCards = new int[realCards.Count];

                for (int i = 0; i < realCards.Count; i++)
                {
                    if (realCards[i].Length == 2)
                    {
                        sumCards[i] = firstCard[realCards[i][0]] * secondCard[realCards[i][1]];
                    }
                    else if (realCards[i].Length == 3)
                    {
                        sumCards[i] = firstCard[realCards[i][0]] * secondCard[realCards[i][2]];
                    }
                }

                if (cardsOfPlayers.ContainsKey(player.Key))
                {
                    cardsOfPlayers[player.Key] += sumCards.Sum();
                }
                else
                {
                    cardsOfPlayers[player.Key] = sumCards.Sum();
                }
            }

            foreach (var player in cardsOfPlayers)
            {
                Console.WriteLine("{0}: {1}", player.Key, player.Value);
            }
        }
    }
}

