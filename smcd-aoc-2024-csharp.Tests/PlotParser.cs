namespace smcd_aoc_2024_csharp.Tests;

static class PlotParser {
    public static IEnumerable<Plot> Parse(string map)
    {
        var plots = [];

        foreach ( var item in map.Split()) {
            var plot = new Plot{};
            plots.Add ( plot );
        }

        return plots;
    }
}
