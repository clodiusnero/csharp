using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack
{
    public class Deck
    {
        List<Card> cards = new List<Card>(52);

        public Deck()
        {
            PopulateDeck();
        }

        public void PopulateDeck()
        {
            cards.Clear();
            cards.AddRange(
                Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13).Select(n => new Card((Rank)n, (Suite)s))));
        }

        public void Shuffle()
        {
            Random random = new System.Random();
            Card shuffle;
            int j;

            for (int i = 0; i < cards.Count; i++)
            {
                j = random.Next(cards.Count);
                shuffle = cards[i];
                cards[i] = cards[j];
                cards[j] = shuffle;
            }
        }

        }
    }

