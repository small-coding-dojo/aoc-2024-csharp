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

    [Theory]
    [InlineData("a", 4)]
    [InlineData("aa", 6)]
    public void TestPerimeterOfSinglePlot(string mapString, int expectedPerimeter)
    {
        // When
        var map = MapToRegionParser.Parse(mapString);
    
        // Then
        Assert.Equal(expectedPerimeter, map[0].Perimeter);
    }
    
    [Fact]
    public void TestAreaOfSinglePlot()
    {
        // Given
        var mapString = "a";

        // When
        var map = MapToRegionParser.Parse(mapString);
    
        // Then
        Assert.Equal(1, map[0].Area);
    }
}