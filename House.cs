using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackFormsApp
{
    internal class House : Player
    {
        public House(int _Money, string _PlayerName) : base(_Money, _PlayerName)
        {
        }
        public void HousePlay(List<CardDeck> _DeckList)
        {
            deckList = _DeckList;
            while (CalculateValue() < 17)
            {
                PullPlayerCard();
            }
        }
    }
}
