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

            Card testCard = MyDeck.FindCardInDeck(1);

            Assert.Equal(card2, testCard);
        }

        [Fact]
        public void CanRemoveFromDeckCardExists()
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);
            Card card2 = new Card(Suit.Diamonds, Value.King);
            Card card3 = new Card(Suit.Spades, Value.Seven);

            Deck<Card> MyDeck = new Deck<Card>();

            MyDeck.Add(card1);
            MyDeck.Add(card2);
            MyDeck.Add(card3);

            MyDeck.Remove(card2);

            Card testCard = MyDeck.FindCardInDeck(2);

            Assert.Equal(default(Card), testCard);
        }

        [Fact]
        public void CanRemoveFromDeckCardDoesNotExist()
        {
            Card card1 = new Card(Suit.Hearts, Value.Ace);
            Card card2 = new Card(Suit.Diamonds, Value.King);
            Card card3 = new Card(Suit.Spades, Value.Seven);
            Card card4 = new Card(Suit.Clubs, Value.Ten);

            Deck<Card> MyDeck = new Deck<Card>();

            MyDeck.Add(card1);
            MyDeck.Add(card2);
            MyDeck.Add(card3);

            MyDeck.Remove(card4);

            Card testCard = MyDeck.FindCardInDeck(4);

            Assert.Equal(default(Card), testCard);
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
