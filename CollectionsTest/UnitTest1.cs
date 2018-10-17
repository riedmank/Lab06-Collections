using System;
using Xunit;
using Lab06_Collections.Classes;
using System.Collections.Generic;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToDeck()
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

            //Assert.Contains(card1, MyDeck);
        }

        [Fact]
        public void VerifyProperties()
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);

            Assert.Equal(Suit.Hearts, card1.Suit);
        }
    }
}
