namespace smcd_aoc_2024_csharp.Tests;

public class PlotParserTest
{
    [Fact]
    public void Test1()
    {
        var actual = PlotParser.Parse("A");
        Assert.Single(actual);
    }
}