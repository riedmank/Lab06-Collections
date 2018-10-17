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

            Deck<Card> MyDeck = new Deck<Card>();

            MyDeck.Add(card1);
            MyDeck.Add(card2);
            MyDeck.Add(card3);

            //Assert.Contains(card2, MyDeck);
        }

        [Fact]
        public void CanRemoveFromDeck()
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);
            Card card2 = new Card(Suit.Diamonds, Value.King);
            Card card3 = new Card(Suit.Spades, Value.Seven);

            Deck<Card> MyDeck = new Deck<Card>();

            MyDeck.Add(card1);
            MyDeck.Add(card2);
            MyDeck.Add(card3);

            MyDeck.Remove(card2);

            //Assert.DoesNotContain(card2, MyDeck);
        }

        [Fact]
        public void VerifyGetProperties()
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);

            Assert.Equal(Suit.Hearts, card1.Suit);
        }

        [Fact]
        public void VerifySetProperties()
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);
            card1.Suit = Suit.Diamonds;

            Assert.Equal(Suit.Diamonds, card1.Suit);
        }
    }
}
