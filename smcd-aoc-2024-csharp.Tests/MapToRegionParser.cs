namespace smcd_aoc_2024_csharp.Tests;

static class MapToRegionParser {
    
    public static List<Region> Parse(string map)
    {
        var rows = map.Split("\n");
        
        var regions = IdentifyRegionsInRow(rows[0]);
        
        if(rows.Length > 1)
        {
            var regions2 = IdentifyRegionsInRow(rows[1]);
            
            regions = MergeRegions(regions, regions2);
        }

        return regions;
    }

    private static List<Region> MergeRegions(List<Region> first, List<Region> second)
    {
        List<Region> result = [..first];

        result[0].Area += second[0].Area;

        if ( second.Count > 1) {
            result[1].Area += second[1].Area;
        }

        return result;
    }

    private static List<Region> IdentifyRegionsInRow(string row)
    {
        var regions = new List<Region>();
        var column = 0;
        while(column < row.Length)
        {
            var plantType = row[column];

            var region = new Region(1, 4);
            var newPlantType = plantType;

            do
            {
                column++;
                if ( column < row.Length) {
                    newPlantType = row[column];

                    if (newPlantType == plantType)
                    {
                        region.Perimeter += 2;
                        region.Area += 1;
                    }
                }

            } while (column < row.Length && plantType == newPlantType);
            
            regions.Add ( region );
        }

        return regions;
    }
}




