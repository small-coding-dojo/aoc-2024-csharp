namespace smcd_aoc_2024_csharp.Tests;

public class MapToRegionParserTest
{
    [Fact]
    public void IdentifySinglePlot1x1()
    {
        var actual = MapToRegionParser.Parse("A");
        Assert.Single(actual);
    }

    [Fact]
    public void TestName()
    {
        // given
        var mapString = "ab";

        // when
        var map = MapToRegionParser.Parse(mapString);
        
        // then
        Assert.Equal(2, map.Count());
    }
}