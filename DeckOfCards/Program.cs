using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card myCard = new Card();

            Deck myDeck = new Deck();

            var counter = 0;

            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {

                    string faceValue;

                    if (i < 11) faceValue = i.ToString();

                    else if (i == 11) faceValue = "Jack";

                    else if (i == 12) faceValue = "Queen";

                    else if (i == 13) faceValue = "King";

                    else faceValue = "Ace";

                    string suit;

                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Clubs";
                    else if (j == 3) suit = "Diamonds";
                    else suit = "Spades";

                    myDeck.Cards[counter] = new Card
                    {
                        FaceValue = faceValue,
                        Suit = suit
                    };
                    counter++;
                }

            }

            var card = myDeck.Draw();

            Console.WriteLine(card.GetFullName());

            Console.ReadLine();
        }
    }

}
