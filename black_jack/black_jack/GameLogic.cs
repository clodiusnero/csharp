using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack
{

    class GameLogic
    {
        public class Hand
        {
            private readonly List<Card> cards = new List<Card>();

            public int totalHand()
            {
                {
                    int total = cards.ConvertAll(Convert.ToInt32).Sum();
                    int soft;
                    var aces = cards.Count(c => c.Rank == Rank.Ace);

                    for (int i = 0; i < cards.Count; ++i)
                    {
                        total += aces;
                    }
                    if (aces + total < 12)
                    {
                        soft = 1;
                        total += 10;
                    }
                    return total;

                }

            }
        }
    }
}
