﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarOfCards.Classes
{
    public class Player
    {
        public string Name { get; set; }
        public  Queue<Card> Deck { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public  Queue<Card> SplitCards(Queue<Card> cards)
        {
            Queue<Card> player1cards = new Queue<Card>();
            Queue<Card> player2cards = new Queue<Card>();

        
            int counter = 2;
            while (cards.Any())
            {
                if (counter % 2 == 0)
                {
                    player2cards.Enqueue(cards.Dequeue());
                }
                else
                {
                    player1cards.Enqueue(cards.Dequeue());
                }
                counter++;
            }


            Deck = player1cards;
            return player2cards;
        }
    }
}
