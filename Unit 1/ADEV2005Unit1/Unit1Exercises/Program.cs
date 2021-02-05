using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace Unit1Exercises
{
    class Program
    {
        static void Main(string[] args)
        { 

            PlayingCard cardAce = new PlayingCard(CardRank.Ace, CardSuit.Spade);
            PlayingCard cardTwo = new PlayingCard(CardRank.Two, CardSuit.Heart, false);

            Console.WriteLine(cardAce);
            Console.WriteLine(cardTwo);

            cardAce.Flip();
            cardTwo.Flip();

            Console.WriteLine(cardAce);
            Console.WriteLine(cardTwo);
            Console.ReadKey();
        }
    }
}
