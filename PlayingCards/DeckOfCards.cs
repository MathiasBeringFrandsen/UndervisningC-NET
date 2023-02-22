using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class DeckOfCards
    {
        public List<Card> Cards = new List<Card>();

        public void AddCard(Suits suit, Numbers number)
        {
            Cards.Add(new Card(suit, number));
        }

        public List<Card> FilterDeck(FilterDeckDelegate filter)
        {
            List<Card> FilteredCards = new List<Card>();
            foreach (Card card in Cards)
            {
                if (filter(card))
                {
                    FilteredCards.Add(card);
                }
            }
            return FilteredCards;
        }

        public void PrintCards()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
