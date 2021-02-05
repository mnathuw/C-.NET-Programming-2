using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace Unit4Exercuses
{
    class Program
    {
        static void PlayingCardFlipped(object sender, EventArgs e)
        {
            Console.WriteLine("Playing card was flipped!");
        }
        static void Main(string[] args)
        {
            ///Construct an instance of PlayingCard class
            PlayingCard playingCard = new PlayingCard(CardRank.Ace, CardSuit.Club);

            ///Print the instance created in step 1
            Console.WriteLine(playingCard);
            ///Subscription statement
            playingCard.Flipped += new EventHandler(PlayingCardFlipped);
            ///Flip the playing card
            playingCard.Flip();

            Console.WriteLine("Press any key to continute...");
            Console.ReadKey();
        }

    }
}
