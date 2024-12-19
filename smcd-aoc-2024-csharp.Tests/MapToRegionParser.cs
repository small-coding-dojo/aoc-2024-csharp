namespace smcd_aoc_2024_csharp.Tests;

static class MapToRegionParser {
    public static List<Region> Parse(string map)
    {
        var regions = new List<Region>();

        foreach ( var item in map) {
            var region = new Region(1, 4);
            regions.Add ( region );
        }

        return regions;
    }
}
