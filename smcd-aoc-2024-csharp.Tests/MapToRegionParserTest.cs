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
    public void ReturnTwoRegions()
    {
        // given
        var mapString = "ab";

        // when
        var map = MapToRegionParser.Parse(mapString);
        
        // then
        Assert.Equal(2, map.Count());
    }

    [Fact]
    public void ReturnCorrectAreaOfTwoRegions()
    {
        var testData = "AB";
        var map = MapToRegionParser.Parse(testData);

        Assert.Equal(1, map.First().Area);
        Assert.Equal(1, map.Last().Area);
    }

    [Fact]
    public void ReturnCorrectAreaOfTwoBiggerRegions()
    {
        var testData = "AAABBBBB";
        var map = MapToRegionParser.Parse(testData);

        Assert.Equal(3, map.First().Area);
        Assert.Equal(5, map.Last().Area);
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

    [Fact]
    public void ReturnCorrectAreaOfOneSpanningRegion1x2()
    {
        var mapString = "A\nA";
        var map = MapToRegionParser.Parse(mapString);
        Assert.Equal(2, map[0].Area);
    }
    
    [Fact]
    public void ReturnCorrectAreaOfOneSpanningRegion2x2()
    {
        var mapString = "AA\nAA";
        var map = MapToRegionParser.Parse(mapString);
        Assert.Equal(4, map[0].Area);
    }

    [Fact]
    public void ReturnCorrectAreaOfTwoSpanningRegions2x2()
    {
        var mapString = "AB\nAB";

        var map = MapToRegionParser.Parse(mapString);

        Assert.True(2 == map[0].Area, $"A area should have size 2, but has {map[0].Area}");
        Assert.True(2 == map[1].Area, $"B area should have size 2, but has {map[1].Area}");

    }  
}