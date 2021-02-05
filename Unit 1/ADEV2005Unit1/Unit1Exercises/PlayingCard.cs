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
        }

        public override string ToString()
        {
            return string.Format("{0} {1} [Face {2}]", this.rank, this.suit, this.isFaceUp ? "Up" : "Down");
        }
    }
}