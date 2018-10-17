﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] deck = new T[5];
        int counter = 0;

        public void Add(T card)
        {
            if (counter == deck.Length)
            {
                Array.Resize(ref deck, deck.Length * 2);
            }
            deck[counter++] = card;
        }

        public void Remove(T card)
        {
            for (int i = 0; i < counter - 1; i++)
            {
                if (deck[i].Equals(card))
                {
                    deck[i] = deck[i + 1];
                }
            }
            counter--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {
                yield return deck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();   
        }
    }
}