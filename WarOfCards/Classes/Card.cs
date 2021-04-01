using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WarOfCards.Classes.Deck;

namespace WarOfCards.Classes
{
    public class Card
    {
        // Members/Fields
        public Suit suit;
        private readonly FaceValue faceVal;

        // Properties
        public Suit Suit { get { return suit; } }
        public FaceValue FaceVal { get { return faceVal; } }

        public int value { get; set; }

        // Constructor
        public Card(Suit suit, int faceVal)
        {
            this.suit = suit;
            this.faceVal = (FaceValue)faceVal;
        }

        public override string ToString()
        {
            return "The " + faceVal.ToString() + " of " + suit.ToString();
        }
    }
}
