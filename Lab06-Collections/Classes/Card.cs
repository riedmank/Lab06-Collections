using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Collections.Classes
{
    class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }

    enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    enum Value
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
