using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseballPlayer mallory = new BaseballPlayer();
            CricketPlayer courtney = new CricketPlayer();
            AluminumBat aluminumBat = new AluminumBat();
            WoodenBat woodenBat = new WoodenBat();
            Mallet mallet = new Mallet();
            CompositeBat compositeBat = new CompositeBat();

            mallory.TakeTurn(woodenBat);
            mallory.TakeTurn(aluminumBat);
            mallory.TakeTurn(compositeBat);
            courtney.TakeTurn(mallet);
        }
    }
}
