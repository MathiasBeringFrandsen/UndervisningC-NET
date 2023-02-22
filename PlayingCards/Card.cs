namespace PlayingCards
{
    public enum Suits
    {
        Clubs,
        Spades,
        Hearts,
        Diamonds
    }

    public enum Numbers
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public delegate bool FilterDeckDelegate(Card card);
    public class Card
    {
      
        public Suits Suit { get; set; }
        public Numbers Number { get; set; }

        public Card(Suits suit, Numbers number)
        {
            Suit = suit;
            Number = number;
        }

        public override string ToString()
        {
            return Number + " of " + Suit;
        }
    }
}