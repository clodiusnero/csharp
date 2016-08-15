using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace black_jack
{
    class MediaFun
    { 
        private void Audio()
        {
            var soundtrack = new SoundPlayer(@"c:\blackjack.wav");
            soundtrack.PlaySync();
            soundtrack.PlayLooping();
        }
    }
}
