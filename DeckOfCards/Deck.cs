using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck
    {
        public Card[] Cards { get; set; }

        public Deck()
        {
            Cards = new Card[52];
        }

        public Card Draw()
        {
            Random rnd = new Random();

            Card randomCard = Cards[rnd.Next(Cards.Length)];

            return randomCard;
        }
    }
}
