using System;

namespace GameLibrary
{
    /// <summary>
    /// Represents a PlayingCard object
    /// </summary>
    class PlayingCard
    {
        private CardRank rank;
        private CardSuit suit;
        private bool isFaceUp;

        /// <summary>
        /// Initializes a PlayingCard with the specified rand and suit. The card will be face up.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suit"></param>
        public PlayingCard(CardRank rank, CardSuit suit) : this(rank, suit, true)
        {
        }

        public PlayingCard(CardRank rank, CardSuit suit, bool isFaceUp)
        {
            this.rank = rank;
            this.suit = suit;
            this.isFaceUp = isFaceUp;
        }

        public CardRank GetRank()
        {
            return this.rank;
        }

        public CardSuit GetSuit()
        {
            return this.suit;
        }

        public bool IsFaceUp()
        {
            return this.isFaceUp;
        }

        public void Flip()
        {
            isFaceUp = !isFaceUp;

            /// Raising the event
            OnFlipped();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} [Face {2}]", this.rank, this.suit, this.isFaceUp ? "Up" : "Down");
        }
        

        /// <summary>
        /// declare an event
        /// </summary>
        public event EventHandler Flipped;

        /// <summary>
        /// Create an "On" method for the event
        /// Declare a method called "OnFlipped"
        /// </summary>
        protected virtual void OnFlipped()
        {

            ///code the implementation of OnFlipped method
            if(Flipped != null)
            {
                Flipped(this, new EventArgs());
            }
        }

        /// Ex 07
        /// Ex 08
        /// Ex 09

    }
}