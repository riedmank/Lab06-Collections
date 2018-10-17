using System;
using Xunit;
using Lab06_Collections.Classes;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);
            Card card2 = new Card(Suit.Diamonds, Value.King);
            Card card3 = new Card(Suit.Spades, Value.Seven);
            Card card4 = new Card(Suit.Clubs, Value.Ten);

            Deck<Card> MyDeck = new Deck<Card>();

            MyDeck.Add(card1);
            MyDeck.Add(card2);
            MyDeck.Add(card3);
            MyDeck.Add(card4);

            Assert.Contains("Hearts", MyDeck.ToString());
        }
    }
}
