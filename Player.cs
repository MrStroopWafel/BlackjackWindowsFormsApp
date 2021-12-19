using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackFormsApp
{
    public partial class Player : Form
    {
        public string Name;
        public bool IsPlaying = true;
        public int Value, Money, HandMoney;
        public List<Card> Hand = new List<Card>();
        protected List<CardDeck> deckList;
        private Card revealedDealerCard;


        public Player(int _Money, string _PlayerName)
        {
            InitializeComponent();
            Money = _Money;
            Name = _PlayerName;
        }

        /// <summary>
        /// Method that loops till the play has made all moves
        /// the method checks for blackjack (21); if the payer goes over 21;
        /// </summary>
        /// <param name="_DeckList">the decklist is given so Hit() can pull a card from the deck</param>
        /// <param name="_RevealedDealerCard">revealed dealer card is given to display on screen (console)</param>
        public void PlayHand(List<CardDeck> _DeckList, Card _RevealedDealerCard)
        {
            revealedDealerCard = _RevealedDealerCard;
            deckList = _DeckList;
            IsPlaying = true;
            while (IsPlaying)
            {
                int x = CalculateValue();
                if (x > 21)
                {
                    Over21();
                    IsPlaying = false;
                }
                else if (x == 21)
                {
                    BlackJack();
                    IsPlaying = false;
                }
                else
                {
                    AskMove();
                }
            }
        }
        /// <summary>
        /// method asks for input, this can be: Hit; Stand; Double;
        /// and runs those functions
        /// </summary>
        private void AskMove()
        {
            string text = $"Dealer Card value: {revealedDealerCard.Number}\n";
            if (revealedDealerCard.Type == Card.CardType.Nummer)
            {
                text += $"Dealer Card 1: {revealedDealerCard.Color} {revealedDealerCard.Number} \n\n";
            }
            else
            {
                text += $"Dealer Card 1: {revealedDealerCard.Color} {revealedDealerCard.Type} \n\n";
            }

            text += $"Player: {Name} \nMoney: {Money} \nBetted money: {HandMoney} \nCard value: {CalculateValue()}\n";
            text += Hand[0].FormatCardToText(Hand) + "\n\nKies een van de volgende opties:";
            label1.Text = text;
            btn_Double.Visible = true;
            btn_Stand.Visible = true;
            btn_Hit.Visible = true;
            btn_Continue.Visible = false;
            this.ShowDialog();
        }
        private void btn_Hit_Click(object sender, EventArgs e)
        {
            PullPlayerCard();
            this.Hide();
        }
        private void btn_Stand_Click(object sender, EventArgs e)
        {
            IsPlaying = false;
            this.Hide();
        }
        private void btn_Double_Click(object sender, EventArgs e)
        {
            Money += HandMoney * -1;
            HandMoney += HandMoney;
            PullPlayerCard();
            IsPlaying = false;
            string text = $"Player: {Name} \nCard value: {CalculateValue()}\n";
            text += Hand[0].FormatCardToText(Hand) + "\n\n";
            text += "Hit enter om door te gaan.";
            label1.Text = text;
            btn_Double.Visible = false;
            btn_Stand.Visible = false;
            btn_Hit.Visible = false;
            btn_Continue.Visible = true;
        }
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// method to display text on screen when the players goes over 21 
        /// </summary>
        private void Over21()
        {
            string text = $"Player: {Name} \nCard value: {CalculateValue()}\n";
            text += Hand[0].FormatCardToText(Hand) + "\n\n";
            text += "Helaas over 21! Hit enter om door te gaan.";
            label1.Text = text;
            btn_Double.Visible = false;
            btn_Stand.Visible = false;
            btn_Hit.Visible = false;
            btn_Continue.Visible = true;
            this.ShowDialog();
        }
        /// <summary>
        /// method to display text on screen when the player gets blackjack (21)
        /// </summary>
        private void BlackJack()
        {
            string text = $"Player: {Name} \nCard value: {CalculateValue()}\n";
            text += Hand[0].FormatCardToText(Hand) + "\n\n";
            text += "BlackJack!!! Hit enter om door te gaan.";
            label1.Text = text;
            btn_Double.Visible = false;
            btn_Stand.Visible = false;
            btn_Hit.Visible = false;
            btn_Continue.Visible = true;
            this.ShowDialog();
        }

        /// <summary>
        /// method to add a card to the player hand
        /// </summary>
        protected void PullPlayerCard()
        {
            //pulls a temp card
            Card tempCard = deckList[0].PullCard(deckList);
            //checks if its a fail card
            if (tempCard.Number != 9999)
            {
                Hand.Add(tempCard);
            }
            else //failcard; means something went wrong or deck needs to be shuffled
            {
                deckList[0].Shuffle(deckList);
                Hand.Add(tempCard);
            }
        }
        /// <summary>
        /// calculates the value of cards in a players hand
        /// can change the value of a ace if the value of the hand is over 10 or 21
        /// </summary>
        /// <returns>the value of the cards in the players hands</returns>
        public int CalculateValue()
        {
            bool highAce = false;
            Value = 0;
            foreach (Card card in Hand)
            {
                if (card.Type == Card.CardType.Aas)
                {
                    //if the hand value is over 10, the added ace needs to be counted as a 1
                    if (Value > 10)
                    {
                        Value += 1;
                        //turns a 11 point ace into a 1 point ace if the player value goes over 21
                        if (highAce && Value > 21)
                        {
                            Value += -10;
                            highAce = false;
                        }
                    }
                    else
                    {
                        Value += card.Number;
                        highAce = true;
                    }
                }
                else
                {
                    Value += card.Number;
                    //turns a 11 point ace into a 1 point ace if the player value goes over 21
                    if (highAce && Value > 21)
                    {
                        Value += -10;
                        highAce = false;
                    }
                }
            }
            return Value;
        }
        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form form being disposed
        }
    }
}
