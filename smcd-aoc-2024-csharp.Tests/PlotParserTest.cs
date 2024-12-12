namespace smcd_aoc_2024_csharp.Tests;

public class PlotParserTest
{
    [Fact]
    public void IdentifySinglePlot1x1()
    {
        var actual = PlotParser.Parse("A");
        Assert.Single(actual);
    }

    [Fact]
    public void TestName()
    {
        // given
        var mapString = "ab";

        // when
        var map = PlotParser.Parse(mapString);
        
        // then
        Assert.Equal(2, map.Count());
    }
}