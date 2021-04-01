using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarOfCards.Classes;

namespace WarOfCards.Classes
{
    public static class Deck
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum FaceValue
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }
        //prop of type list<card>
        public static Queue<Card> Cards { get; set; }
     
        
        public static Queue<Card> GenerateCards()
        {
            Queue<Card> cards = new Queue<Card>();
            for (int c = 2; c <= 14; c++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Card(suit, c)
                    {
                        suit = suit,
                        value = c
                    });
                }
            }
            

           return Shuffle(cards);
        }
         private static Queue<Card> Shuffle(Queue<Card> cards)
        {
            //Shuffle using Fisher-Yates Modern
            List<Card> deck = cards.ToList();
            Random r = new Random();
            for (int n = deck.Count - 1; n > 0; --n)
            {
                // Randomly pick a card which has not been shuffled
                int k = r.Next(n + 1);

                // Swap the selected card with the last unselected card 
                Card temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }

            Queue<Card> shuffledDeck = new Queue<Card>();
            foreach(var card in deck)
            {
                shuffledDeck.Enqueue(card);
            }

            return shuffledDeck;
        }

    }

}

