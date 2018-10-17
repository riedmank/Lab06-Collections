using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Collections.Classes
{
    class Deck<T>
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

    }
}
