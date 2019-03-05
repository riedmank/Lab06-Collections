using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Collections.Classes
{
    public class Card
    {
        public Suit Suit { get; set; }
        public virtual Value Value { get; set; }

        /// <summary>
        /// Card Constructor
        /// </summary>
        /// <param name="suit">Suit of the Card</param>
        /// <param name="value">Value of the Card</param>
        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Value
    {
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
        King,
        Ace
    }
}
