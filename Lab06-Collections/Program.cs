using System;
using Lab06_Collections.Classes;

namespace Lab06_Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);
            Card card2 = new Card(Suit.Diamonds, Value.King);
            Card card3 = new Card(Suit.Spades, Value.Seven);
            Card card4 = new Card(Suit.Clubs, Value.Ten);
            Card card5 = new Card(Suit.Hearts, Value.Two);
            Card card6 = new Card(Suit.Diamonds, Value.Five);
            Card card7 = new Card(Suit.Spades, Value.Six);
            Card card8 = new Card(Suit.Clubs, Value.Queen);
            Card card9 = new Card(Suit.Hearts, Value.Three);
            Card card10 = new Card(Suit.Diamonds, Value.Eight);
            Card card11 = new Card(Suit.Spades, Value.Four);
            Card card12 = new Card(Suit.Clubs, Value.Jack);

            Deck<Card> MyDeck = new Deck<Card>();

            MyDeck.Add(card1);
            MyDeck.Add(card2);
            MyDeck.Add(card3);
            MyDeck.Add(card4);
            MyDeck.Add(card5);
            MyDeck.Add(card6);
            MyDeck.Add(card7);
            MyDeck.Add(card8);
            MyDeck.Add(card9);
            MyDeck.Add(card10);
            MyDeck.Add(card11);
            MyDeck.Add(card12);
        }
    }
}
