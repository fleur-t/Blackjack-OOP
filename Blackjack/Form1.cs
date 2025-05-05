using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int totalSpeler1 = 0;
        private int totalSpeler2 = 0;
        private List<string> deck = new List<string>();

        private List<string> cardValues = new List<string>()
            {
                "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
            };

        private List<string> suits = new List<string>() { "♠", "♥", "♦", "♣" };
        public Form1()
        {
            InitializeComponent();
            buttonReset.Click += buttonReset_Click;
            InitializeDeck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl.Text = "Hello";
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DeelKaart_Click(object sender, EventArgs e)
        {

            //if (total >= 21)
            //{
            //    MessageBox.Show("Game over! Click Reset to start a new round.");
            //    return;
            //}

            string card1 = DrawCard();
            Player.Items.Add(card1);
            int cardValue1 = GetCardValue(card1.Split(' ')[0]);
            totalSpeler1 += cardValue1;

            // Speler 2
            string card2 = DrawCard();
            Player2.Items.Add(card2);
            int cardValue2 = GetCardValue(card2.Split(' ')[0]);
            totalSpeler2 += cardValue2;

            // Score bijhouden (eventueel per speler opslaan als je dat nog niet doet)
            scoreTotaal.Text = $"Total Score: {totalSpeler1}";
            scoreTotaal2.Text = $"Total Score: {totalSpeler2}";

            if (totalSpeler1 >= 21 || totalSpeler2 >= 21)
            {
                string message = "";

                if (totalSpeler1 == 21)
                    message += "Speler 1 heeft Blackjack!\n";
                else if (totalSpeler1 > 21)
                    message += "Speler 1 is busted!\n";

                if (totalSpeler2 == 21)
                    message += "Speler 2 heeft Blackjack!";
                else if (totalSpeler2 > 21)
                    message += "Speler 2 is busted!";

                MessageBox.Show(message);
            }
        }

        private string DrawCard()
        {
            if (deck.Count == 0)
            {
                InitializeDeck();
            }

            int index = random.Next(deck.Count);
            string card = deck[index];
            deck.RemoveAt(index);

            return card;
        }

        private int GetCardValue(string card)
        {

            string cardValue = new string(card.TakeWhile(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(cardValue))
            {
                cardValue = card.Substring(0, 1);
            }

            if (int.TryParse(cardValue, out int value))
                return value;

            if (cardValue == "A")
                return 11;

            return 10;
        }

        private void Player_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scoreTotaal_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            totalSpeler1 = 0;
            totalSpeler2 = 0;
            scoreTotaal.Text = "Total Score: 0";
            scoreTotaal2.Text = "Total Score: 0";

            Player.Items.Clear();
            Player2.Items.Clear();

            InitializeDeck();
        }

        private void InitializeDeck()
        {
            deck.Clear();
            foreach (string suit in suits)
            {
                foreach (string value in cardValues)
                {
                    deck.Add($"{value} {suit}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scoreTotaal2_Click(object sender, EventArgs e)
        {

        }
    }
}