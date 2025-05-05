//using System;
//using System.Collections.Generic;

//namespace Blackjack
//{
//    public class Deck
//    {
//        private List<Card> cards = new List<Card>();
//        private Random random = new Random();

//        private static readonly List<string> cardValues = new List<string>()
//        {
//            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
//        };

//        private static readonly List<string> suits = new List<string>() { "♠", "♥", "♦", "♣" };

//        public Deck()
//        {
//            InitializeDeck();
//        }

//        public void InitializeDeck()
//        {
//            cards.Clear();
//            foreach (string suit in suits)
//            {
//                foreach (string value in cardValues)
//                {
//                    cards.Add(new Card(value, suit));
//                }
//            }
//        }

//        public Card DrawCard()
//        {
//            if (cards.Count == 0)
//            {
//                InitializeDeck();
//            }

//            int index = random.Next(cards.Count);
//            Card drawn = cards[index];
//            cards.RemoveAt(index);
//            return drawn;
//        }
//    }
//}
