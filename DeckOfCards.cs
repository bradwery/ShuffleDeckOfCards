namespace DeckOfCardsDemo;

public static class DeckOfCards
{
    public static List<string> Cards => [
        "A♥","2♥","3♥","4♥","5♥","6♥","7♥","8♥","9♥","10♥","J♥","Q♥","K♥",
        "A♠","2♠","3♠","4♠","5♠","6♠","7♠","8♠","9♠","10♠","J♠","Q♠","K♠",
        "A♣","2♣","3♣","4♣","5♣","6♣","7♣","8♣","9♣","10♣","J♣","Q♣","K♣",
        "A♦","2♦","3♦","4♦","5♦","6♦","7♦","8♦","9♦","10♦","J♦","Q♦","K♦",
    ];

    public static List<string> ShuffleDeck2()
    {
        return Cards.Select(card => (card, sort: Guid.NewGuid()))
                    .OrderBy(a => a.sort)
                    .Select(a => a.card)
                    .ToList();
    }

    public static List<string> ShuffleDeck()
    {
        return Cards.OrderBy(_ => Guid.NewGuid())
                    .ToList();
    }
}