using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace DeckOfCardsDemo;

[MemoryDiagnoser(false)]
[Config(typeof(StyleConfig))]
public class Benchmarks
{
    [Benchmark(Baseline = true)]
    public void ShuffleDeck()
    {
        DeckOfCards.ShuffleDeck();
    }

    [Benchmark]
    public void ShuffleDeck2()
    {
        DeckOfCards.ShuffleDeck2();
    }
}

public class StyleConfig : ManualConfig
{
    public StyleConfig()
    {
        SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
    }
}