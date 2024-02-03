using DeckOfCardsDemo;

//Console.WriteLine(string.Join(",", DeckOfCards.ShuffleDeck()));
BenchmarkDotNet.Running.BenchmarkRunner.Run(typeof(Benchmarks));

foreach(var c in "test")
{
    Console.WriteLine(c);
}