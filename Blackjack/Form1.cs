using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int total = 0;
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

            string card = DrawCard();
            Player.Items.Add(card);

            int cardValue = GetCardValue(card.Split(' ')[0]);
            total += cardValue;

            scoreTotaal.Text = $"Total Score: {total}";

            if (total >= 21)
            {
                MessageBox.Show(total == 21 ? "Blackjack!" : "Busted!");
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
            total = 0;
            scoreTotaal.Text = "Total Score: 0";
            Player.Items.Clear();
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
    }
}
