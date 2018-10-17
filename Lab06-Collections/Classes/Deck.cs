using System;
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
            bool check = deck[0].Equals(card);
            for (int i = 0; i < counter; i++)
            {
                if (!check)
                {
                    deck[i] = deck[i];
                    if (i + 1 == counter)
                    {
                        return;
                    }
                    else
                    {
                    check = deck[i + 1].Equals(card);
                    }
                }
                else
                {
                    deck[i] = deck[i + 1];
                }
            }
            counter--;
        }

        public T FindCardInDeck(int index)
        {
            if (index > counter)
            {
                return default(T);
            }
            else
            {
            return deck[index];
            }
        }

        //public T ReturnSuit(T suit)
        //{
        //    return T;
        //}

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
