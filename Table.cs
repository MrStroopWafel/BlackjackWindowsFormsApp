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
    public partial class Table : Form
    {
        private List<Player> playerList = new List<Player>();
        private List<CardDeck> deckList = new List<CardDeck>();
        private House house = new House(0, "Dealer");
        public Table(Settings _settings)
        {
            TableInit(_settings);
            InitializeComponent();
            TableRound();
        }

        /// <summary>
        /// function to initialize the table
        /// </summary>
        /// <param name="_Settings"></param>
        private void TableInit(Settings _Settings)
        {
            //loop for the amount of players given and add them to the player list
            for (int i = 0; i < _Settings.Players; i++)
            {
                PlayerInit playerInit = new PlayerInit(i, _Settings.Money);
                Application.Run(playerInit);
                playerList.Add(playerInit.Player);
            }
            //loop for the amount of card decks given and add them to the deck list
            for (int i = 0; i < _Settings.Decks; i++)
            {
                deckList.Add(new CardDeck());
            }
        }

        /// <summary>
        /// the method that runs every round
        /// </summary>
        private void TableRound()
        {
            //INFINITE LOOP TILL WIN AND LOSE CONDITIONS ARE ADDED                     <------------------------------------------------------------------
            while (true)
            {
                PlaceBets();
                DealCards();

                foreach (Player player in playerList)
                {
                    player.PlayHand(deckList, house.Hand[0]);
                }

                house.HousePlay(deckList);

                string text = $"Dealer: \nCard value: {house.CalculateValue()} \n{house.Hand[0].FormatCardToText(house.Hand)}\n";
                //loops though the players to show cards bets and money earned
                foreach (Player player in playerList)
                {
                    text += $"Player: {player.Name} \nMoney: {player.Money} \nBetted money: {player.HandMoney} \nCard value: {player.CalculateValue()}  \n{player.Hand[0].FormatCardToText(player.Hand)}\n";
                    text += CheckWin(player);
                }
                label1.Text = text;
                ClearHand();
                this.ShowDialog();
            }
        }
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// method to ask players input to ask bets
        /// </summary>
        private void PlaceBets()
        {
            foreach (Player player in playerList)
            {
                AddBet addBet = new AddBet(player);
                Application.Run(addBet);
            }
        }
        /// <summary>
        /// method to give every player 2 card at the start of the round
        /// </summary>
        private void DealCards()
        {
            //add 2 starting cards for each player
            foreach (Player player in playerList)
            {
                for (int i = 0; i < 2; i++)
                {
                    //pulls a temp card
                    Card tempCard = deckList[0].PullCard(deckList);
                    //checks if its a fail card
                    if (tempCard.Number != 9999)
                    {
                        player.Hand.Add(tempCard);
                    }
                    else //failcard; means something went wrong or deck needs to be shuffled
                    {
                        deckList[0].Shuffle(deckList);
                        player.Hand.Add(tempCard);
                    }
                }
            }
            //add 2 starting cards for the house
            for (int i = 0; i < 2; i++)
            {
                //pulls a temp card
                Card tempCard = deckList[0].PullCard(deckList);
                //checks if its a fail card
                if (tempCard.Number != 9999)
                {
                    house.Hand.Add(tempCard);
                }
                else //failcard; means something went wrong or deck needs to be shuffled
                {
                    deckList[0].Shuffle(deckList);
                    house.Hand.Add(tempCard);
                }
            }
        }

        private void ClearHand()
        {
            foreach (Player player in playerList)
            {
                player.Hand.Clear();
            }
            house.Hand.Clear();
        }

        private string CheckWin(Player _Player)
        {
            //check if player is under 21 or 21
            if (_Player.CalculateValue() < 21 || _Player.CalculateValue() == 21)
            {
                //check if dealer is under 21 or 21
                if (house.CalculateValue() < 21 || house.CalculateValue() == 21)
                {
                    //checks if the player has higher cards then the dealer
                    if (_Player.CalculateValue() > house.CalculateValue())
                    {
                        //checks for blackjack and gives this higher payout
                        if (_Player.CalculateValue() == 21)
                        {
                            _Player.Money += Convert.ToInt32(_Player.HandMoney * 2);
                            return $"{_Player.Name} heeft {Convert.ToInt32(_Player.HandMoney * 2)} gewonnen!\n";
                        }
                        else //(_player.CalculateValue() != 21)
                        {
                            _Player.Money += Convert.ToInt32(_Player.HandMoney * 1.5);
                            return $"{_Player.Name} heeft {Convert.ToInt32(_Player.HandMoney * 1.5)} gewonnen!\n";
                        }
                    }
                    else //(_player.CalculateValue() < house.CalculateValue())
                    {
                        return $"{_Player.Name} heeft {Convert.ToInt32(_Player.HandMoney)} verloren.\n";
                    }
                }
                else //(house.CalculateValue() > 21)
                {
                    _Player.Money += Convert.ToInt32(_Player.HandMoney * 1.5);
                    return $"{_Player.Name} heeft {Convert.ToInt32(_Player.HandMoney * 2)} gewonnen!\n";
                }
            }
            else //(_player.CalculateValue() > 21)
            {
                return $"{_Player.Name} heeft {Convert.ToInt32(_Player.HandMoney)} verloren.\n";
            }
        }
    }
}

