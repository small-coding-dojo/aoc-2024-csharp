namespace smcd_aoc_2024_csharp.Tests;

static class MapToRegionParser {
    public static List<Region> Parse(string map)
    {
        var regions = new List<Region>();
        var column = 0;
        while(column < map.Length)
        {
            var plantType = map[column];
            
            var region = new Region(1, 4);
            column++;
            do
            {

            } while (plantType = newPlantType);
            
            regions.Add ( region );
            column++;
        }

        return regions;
    }
}
