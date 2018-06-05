using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class CricketPlayer : IPlayer
    {
        public string Name { get; set; }

        public void Swing()
        {
           
        }

        public void TakeTurn(Mallet mallet)
        {
            mallet.Swing();
        }
    }
}
