//namespace Blackjack
//{
//    public class Card
//    {
//        public string Value { get; set; }
//        public string Suit { get; set; }

//        public Card(string value, string suit)
//        {
//            Value = value;
//            Suit = suit;
//        }

//        public override string ToString()
//        {
//            return $"{Value} {Suit}";
//        }

//        public int GetCardNumericValue()
//        {
//            if (int.TryParse(Value, out int val))
//                return val;
//            if (Value == "A")
//                return 11;
//            return 10;
//        }
//    }
//}
