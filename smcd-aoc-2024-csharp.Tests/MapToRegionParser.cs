namespace smcd_aoc_2024_csharp.Tests;

static class MapToRegionParser {
    public static IEnumerable<Region> Parse(string map)
    {
        var regions = new List<Region>();

        foreach ( var item in map) {
            var region = new Region{};
            regions.Add ( region );
        }

        return regions;
    }
}
