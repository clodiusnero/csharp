using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack
{
    class Card
    {
        public Suite Suite;
        public Rank Rank;
        public Card(Rank rank, Suite suite)
        {
            this.Rank = rank;
            this.Suite = suite;
        }
        public override string ToString()
        {
            char suite = '?';

            switch (this.Suite)
            {
                case Suite.Club:
                    suite = '♣';
                    break;
                case Suite.Diamond:
                    suite = '♦';
                    break;
                case Suite.Heart:
                    suite = '♥';
                    break;
                case Suite.Spades:
                    suite = '♠';
                    break;
            }
            var num = (int)this.Rank > 1 && (int)this.Rank < 11 ?
                ((int)this.Rank).ToString() :
                Enum.GetName(typeof(Rank), this.Rank).Substring(0, 1);

            return num + " " + suite;
        }
    }
}
